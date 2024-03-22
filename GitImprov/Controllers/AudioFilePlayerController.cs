using GitImprov.Generators;
using GitImprov.Helpers;
using GitImprov.Models;
using NAudio.Wave;

namespace GitImprov.Controllers
{
    internal class AudioFilePlayerController
    {
        private const float MAX_VOLUME = 0.9f;
        private const float MIN_VOLUME = 0.1f;
        private const float INCREASE_VOLUME = 0.09f;
        private const string FILE_DIALOG_FILETER = "Audio Files|*.wav;*.mp3;*.aac;*.aiff;*.flac;*.ogg;*.midi;*.wma;*.pcm|All Files|*.*";

        private static readonly BackingTrackService _backingTrackService = BackingTrackService.GetInstance();

        private static bool _isPlaying = false;
        private static float _audioVolume = 0.5f;
        private static string _audioFilePath = string.Empty;
        private static string _backingTrackName = string.Empty;

        private static WaveOutEvent? _outputDevice;
        private static AudioFileReader? _audioFile;

        public static event EventHandler? AudioStopped;
        public static event EventHandler? BackingTrackNameChanged;

        public static string BackingTrackName { get { return _backingTrackName; } }
        public static bool IsLoaded { get { return string.IsNullOrEmpty(_audioFilePath); } }
        public static bool IsPlaying { get { return _isPlaying; } }
        public static bool Loop { get; set; }
        public static bool Shuffle { get; set; }


        private static void OnAudioFilePlayed()
        {
            AudioStopped?.Invoke(null, EventArgs.Empty);
        }

        private static void OnBackingTrackNameChanged()
        {
            BackingTrackNameChanged?.Invoke(null, EventArgs.Empty);
        }

        private static void OnPlayBackStopped(object? sender, StoppedEventArgs e)
        {
            Dispose();

            if (Shuffle)
            {
                var randomBackingTrack = _backingTrackService.GetRandomBackingTrack();

                if (randomBackingTrack is null)
                {
                    OnAudioFilePlayed();
                    return;
                }

                _audioFilePath = randomBackingTrack.Location!;
                _backingTrackName = randomBackingTrack.Name!;

                OnBackingTrackNameChanged();
                Play();
            }

            if (Loop)
            {
                Play();
            }

            if (!Loop && !Shuffle)
            {
                OnAudioFilePlayed();
            }
        }

        private static bool InitializeAudioFilePlayer()
        {
            try
            {
                _audioFile = new AudioFileReader(_audioFilePath);
                _outputDevice = new WaveOutEvent { Volume = _audioVolume };
                _outputDevice.Init(_audioFile);
                _outputDevice.PlaybackStopped += OnPlayBackStopped;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool LoadFromDataBase(BackingTrack backingTrack)
        {
            var response = _backingTrackService.GetBackingTrack(backingTrack);

            _audioFilePath = response.Location!;
            _backingTrackName = response.Name!;

            return InitializeAudioFilePlayer();
        }

        public static bool Load()
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = FILE_DIALOG_FILETER;

            if (!(ofd.ShowDialog() == DialogResult.OK))
            {
                return false;
            }

            _audioFilePath = ofd.FileName;
            _backingTrackName = NameGenerator.GetBackingTrackName(_audioFilePath);

            var response = _backingTrackService.GetBackingTrack(new BackingTrack { Name = _backingTrackName });

            if (response is null || response.Name == string.Empty)
            {
                _backingTrackService.AddBackingTrack(_backingTrackName, _audioFilePath);
            }

            return InitializeAudioFilePlayer();
        }

        public static void Play()
        {
            if (_outputDevice?.PlaybackState != PlaybackState.Playing)
            {
                _isPlaying = true;

                InitializeAudioFilePlayer();

                var audioFileExists = File.Exists(_audioFilePath);

                if (audioFileExists)
                {
                    _outputDevice?.Play();
                }
            }
        }

        public static void Stop()
        {
            if (_outputDevice != null)
            {
                Loop = false;
                Shuffle = false;
                _isPlaying = false;

                _outputDevice?.Stop();
            }
        }

        public static void Pause()
        {
            if (_outputDevice is not null && _outputDevice.PlaybackState == PlaybackState.Playing)
            {
                _outputDevice.Pause();
            }
        }

        public static void Resume()
        {
            if (_outputDevice is not null && _outputDevice.PlaybackState == PlaybackState.Paused)
            {
                _outputDevice.Play();
            }
        }

        public static void PlayLooping()
        {
            Loop = !Loop;
        }

        public static void PlayShuffle()
        {
            Shuffle = !Shuffle;
        }

        public static void VolumeUp()
        {
            if (_outputDevice is not null && _outputDevice.Volume < MAX_VOLUME)
            {
                _outputDevice.Volume += INCREASE_VOLUME;
                _audioVolume = _outputDevice.Volume;
            }
        }

        public static void VolumeDown()
        {
            if (_outputDevice is not null && _outputDevice.Volume > MIN_VOLUME)
            {
                _outputDevice.Volume -= INCREASE_VOLUME;
                _audioVolume = _outputDevice.Volume;
            }
        }

        public static void Dispose()
        {
            _outputDevice?.Dispose();
            _outputDevice = null;

            _audioFile?.Dispose();
            _audioFile = null;
        }

    }
}
