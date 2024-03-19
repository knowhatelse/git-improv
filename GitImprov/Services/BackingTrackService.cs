using GitImprov.Data.Connection;
using GitImprov.Models;
using System.Configuration;

namespace GitImprov.Generators
{
    public class BackingTrackService
    {
        private static BackingTrackService? _instance;

        private readonly Random _random;

        private List<BackingTrack>? _allBackingTracks;
        private List<BackingTrack>? _activeBackingTracks;


        private BackingTrackService()
        {
            UpdateBackingTracksList();
            _random = new Random();
        }

        private void UpdateBackingTracksList()
        {
            _allBackingTracks = DBConnect.DataBase.BackingTracks?.ToList();
            _activeBackingTracks = _allBackingTracks?.Where(bt => bt.Active is true).ToList();
            _allBackingTracks?.Reverse();
        }

        public static BackingTrackService GetInstance()
        {
            _instance ??= new BackingTrackService();
            return _instance;
        }

        public bool AddBackingTrack(string backingTrackName, string audioFileLocation)
        {
            var exists = _allBackingTracks?.Any(b => b.Name == backingTrackName);

            if (exists is null)
            {
                return false;
            }

            var audioFileFolderLocation = ConfigurationManager.AppSettings["AudioFileFolderLocationPath"]!;
            var audioFileFolderPath = Path.Combine(audioFileFolderLocation, backingTrackName);

            try
            {
                File.Copy(audioFileLocation, audioFileFolderPath, true);
            }
            catch { }

            var newBackingTrack = new BackingTrack
            {
                Name = backingTrackName,
                Location = audioFileFolderPath,
                Active = true,
            };

            DBConnect.DataBase.BackingTracks?.Add(newBackingTrack);
            DBConnect.DataBase.SaveChanges();

            UpdateBackingTracksList();

            return true;
        }

        public bool ChangeActiveStatus(BackingTrack backingTrack)
        {
            if (backingTrack is null)
            {
                return false;
            }

            backingTrack.Active = !backingTrack.Active;

            DBConnect.DataBase.SaveChanges();
            UpdateBackingTracksList();

            return true;
        }

        public List<BackingTrack>? GetAllBakingTracks()
        {
            return _allBackingTracks;
        }

        public BackingTrack GetBackingTrack(BackingTrack backingTrack)
        {
            return _allBackingTracks?.FirstOrDefault(b => b.Name == backingTrack.Name)!;
        }

        public BackingTrack? GetRandomBackingTrack()
        {      
            if( _activeBackingTracks?.Count == 0 || _activeBackingTracks is null)
            {
                return null;
            }

            var randomID = _random.Next(_activeBackingTracks!.Count - 1);
            return _activeBackingTracks![randomID];
        }

        public bool RemoveBackingTrack(BackingTrack backingTrack)
        {
            if(backingTrack is null)
            {
                return false;
            }

            if (File.Exists(backingTrack.Location))
            {
                try
                {
                    File.Delete(backingTrack.Location);
                }
                catch { }
               
            }

            DBConnect.DataBase.BackingTracks?.Remove(backingTrack);
            DBConnect.DataBase.SaveChanges();

            UpdateBackingTracksList();

            return true;
        }

        public bool RemoveAllBackingTracks()
        {
            if(_allBackingTracks?.Count == 0 || _allBackingTracks is null)
            {
                return false;
            }

            foreach (var backingTrack in _allBackingTracks)
            {
                RemoveBackingTrack(backingTrack);
            }

            return true;
        }
    }
}
