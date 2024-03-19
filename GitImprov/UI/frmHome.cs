using GitImprov.Controllers;
using GitImprov.DTO;
using GitImprov.Generators;
using GitImprov.Helpers;
using TimerController = GitImprov.Controllers.TimerController;

namespace GitImprov.UI
{
    public partial class FrmHome : Form
    {
        private const string TRUE = "true";
        private const string FALSE = "false";

        private readonly ControlsDto _controls;

        public FrmHome()
        {
            InitializeComponent();

            _controls = new ControlsDto
            {
                Timer = btnTimerText,
                GuitarPlayer = btnGuitarPlayerText,
                Mode = btnModeText,
                Technique = btnTechniqueText,
                Notes = btnNoteText
            };

            btnResume.Enabled = false;
            btnPause.Enabled = false;
            btnStop.Enabled = false;

            AudioFilePlayerController.AudioStopped += AudioFileStoppedPlaying!;
            AudioFilePlayerController.BackingTrackNameChanged += ChangeBackingTrackName!;
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            txtBackingTrackName.Text = AudioFilePlayerController.BackingTrackName;
        }

        private void AudioFileStoppedPlaying(object sender, EventArgs e)
        {
            TimerController.Stop();

            ChangeButtonColorAndIcon(btnPlay, Colors.LighterGray, Properties.Resources.play);

            btnPlay.Enabled = true;
            btnStop.Enabled = false;
            btnPause.Enabled = false;
        }

        private void ChangeBackingTrackName(object sender, EventArgs e)
        {
            txtBackingTrackName.Text = AudioFilePlayerController.BackingTrackName;
        }

        private static void ChangeButtonColorAndIcon(Button button, string color, Bitmap? icon = null)
        {
            button.BackColor = ColorTranslator.FromHtml(color);

            if (icon is not null)
            {
                button.Image = icon;
            }
        }

        private static void ChangeTurnOffSettings(Button btnOff, Control text, Control header)
        {
            if (btnOff.Tag?.ToString() == TRUE)
            {
                btnOff.Tag = FALSE;
                text.ForeColor = ColorTranslator.FromHtml(Colors.DarkGray);
                header.ForeColor = ColorTranslator.FromHtml(Colors.DarkTeal);

                ChangeButtonColorAndIcon(btnOff, Colors.SelectedGray);
            }
            else
            {
                btnOff.Tag = TRUE;
                text.ForeColor = ColorTranslator.FromHtml(Colors.White);
                header.ForeColor = ColorTranslator.FromHtml(Colors.TealText);

                ChangeButtonColorAndIcon(btnOff, Colors.DarkGray);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            btnLoad.BackColor = ColorTranslator.FromHtml(Colors.GrayWhite);

            if (AudioFilePlayerController.Load())
            {
                txtBackingTrackName.Text = AudioFilePlayerController.BackingTrackName;
            }
            else
            {
                MessageBox.Show(Messages.NoAudioFileLoadedBody, Messages.NoAudioFileLoadedTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnLoad.BackColor = ColorTranslator.FromHtml(Colors.LighterGray);
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            ChangeButtonColorAndIcon(btnResume, Colors.LighterGray, Properties.Resources.resume);
            ChangeButtonColorAndIcon(btnPlay, Colors.Teal, Properties.Resources.play_accent);

            btnPlay.Enabled = true;

            AudioFilePlayerController.Resume();
            TimerController.Resume();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            ChangeButtonColorAndIcon(btnResume, Colors.GrayWhite, Properties.Resources.resume_accent);
            ChangeButtonColorAndIcon(btnPlay, Colors.LighterGray, Properties.Resources.play);

            btnPlay.Enabled = false;
            btnStop.Enabled = true;
            btnResume.Enabled = true;

            AudioFilePlayerController.Pause();
            TimerController.Pause();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (!AudioFilePlayerController.IsLoaded)
            {
                ChangeButtonColorAndIcon(btnPlay, Colors.Teal, Properties.Resources.play_accent);

                btnPause.Enabled = true;
                btnLoad.Enabled = false;
                btnStop.Enabled = true;
                btnPlay.Enabled = false;

                AudioFilePlayerController.Play();
                TimerController.Start(_controls, this);
            }
            else
            {
                MessageBox.Show(Messages.NoAudioFileLoadedBody, Messages.NoAudioFileLoadedTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ChangeButtonColorAndIcon(btnPlay, Colors.LighterGray, Properties.Resources.play);
            ChangeButtonColorAndIcon(btnLoop, Colors.LighterGray, Properties.Resources.loop);
            ChangeButtonColorAndIcon(btnSuffle, Colors.LighterGray, Properties.Resources.shuffle);
            ChangeButtonColorAndIcon(btnResume, Colors.LighterGray, Properties.Resources.resume);

            btnLoad.Enabled = true;
            btnPause.Enabled = false;
            btnResume.Enabled = false;
            btnPlay.Enabled = true;
            btnStop.Enabled = false;

            AudioFilePlayerController.Stop();
            TimerController.Stop();
        }

        private void BtnLoop_Click(object sender, EventArgs e)
        {
            AudioFilePlayerController.PlayLooping();
            AudioFilePlayerController.Shuffle = false;

            if (AudioFilePlayerController.Loop)
            {
                ChangeButtonColorAndIcon(btnLoop, Colors.Teal, Properties.Resources.loop_accent);
                ChangeButtonColorAndIcon(btnSuffle, Colors.LighterGray, Properties.Resources.shuffle);
            }
            else
            {
                ChangeButtonColorAndIcon(btnLoop, Colors.LighterGray, Properties.Resources.loop);
            }
        }

        private void BtnSuffle_Click(object sender, EventArgs e)
        {
            AudioFilePlayerController.PlayShuffle();
            AudioFilePlayerController.Loop = false;

            if (AudioFilePlayerController.Shuffle)
            {
                ChangeButtonColorAndIcon(btnSuffle, Colors.Teal, Properties.Resources.shuffle_accent);
                ChangeButtonColorAndIcon(btnLoop, Colors.LighterGray, Properties.Resources.loop);
            }
            else
            {
                ChangeButtonColorAndIcon(btnSuffle, Colors.LighterGray, Properties.Resources.shuffle);
            }
        }

        private void BtnVolumeUp_Click(object sender, EventArgs e)
        {
            AudioFilePlayerController.VolumeUp();
        }

        private void BtnVolumeDown_Click(object sender, EventArgs e)
        {
            AudioFilePlayerController.VolumeDown();
        }

        private void BtnTimerSettings_Click(object sender, EventArgs e)
        {
            var form = new FrmDialog(this.Tag.ToString()!);
            form.ShowDialog();
        }

        private void BtnTimerOff_Click(object sender, EventArgs e)
        {
            if (btnTimerOff.Tag?.ToString() == TRUE)
            {
                TimerController.Pause();
            }
            else
            {
                TimerController.Resume();
            }

            ChangeTurnOffSettings(btnTimerOff, btnTimerText, btnTimerHeader);
        }

        private void BtnGuitarPlayerOff_Click(object sender, EventArgs e)
        {
            ChangeTurnOffSettings(btnGuitarPlayerOff, btnGuitarPlayerText, btnGuitarPlayerHeader);
        }

        private void BtnModeOff_Click(object sender, EventArgs e)
        {
            ChangeTurnOffSettings(btnModeOff, btnModeText, btnModeHeader);
        }

        private void BtnTechniqueOff_Click(object sender, EventArgs e)
        {
            ChangeTurnOffSettings(btnTechniqueOff, btnTechniqueText, btnTechniqueHeader);
        }

        private void BtnNotesOff_Click(object sender, EventArgs e)
        {
            ChangeTurnOffSettings(btnNotesOff, btnNoteText, btnNoteHeader);
        }

    }
}
