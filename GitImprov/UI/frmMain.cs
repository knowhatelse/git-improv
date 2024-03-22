using GitImprov.Controllers;
using GitImprov.Helpers;
using TimerController = GitImprov.Controllers.TimerController;

namespace GitImprov.UI
{
    public partial class FrmMain : Form
    {
        private const string BACKING_TRACKS = "Backing tracks";
        private const string GUITAR_PLAYERS = "Guitar players";
        private const string MODES = "Modes";
        private const string TECHNIQUES = "Techniques";
        private const string INFO = "Info";

        private readonly List<Button> _sideBarButtons;
        private Form _activeForm;


        public FrmMain()
        {
            InitializeComponent();

            _sideBarButtons = new List<Button>();
            _activeForm = new Form();

            InitializeSideBarButtons();
            OpenChildForm(new FrmHome());

            TitleBarSettings.UseImmersiveDarkMode(this.Handle, true);
        }

        private void InitializeSideBarButtons()
        {
            var buttonsFromSideBar = pnlSideBar.Controls.OfType<Button>().ToList();

            foreach (var button in buttonsFromSideBar)
            {
                button.Click += ButtonBehaviour!;
                _sideBarButtons.Add(button);
            }
        }

        private void ButtonBehaviour(object sender, EventArgs e)
        {
            StopBackingTrackAndTimer();

            Button clickedButton = (Button)sender;
            clickedButton.BackColor = ColorTranslator.FromHtml(Colors.GrayWhite);
            ButtonAccentImage(clickedButton);
            lblNavText.Text = clickedButton.Tag!.ToString();

            UpdateOtherButtons(clickedButton);
            OpenForm(clickedButton.Tag.ToString());
        }

        private static void StopBackingTrackAndTimer()
        {
            if (AudioFilePlayerController.IsPlaying is true)
            {
                AudioFilePlayerController.Stop();
                TimerController.Stop();
            }
        }

        private static void ButtonAccentImage(Button clicledButton)
        {
            clicledButton.Image = clicledButton.Tag switch
            {
                BACKING_TRACKS => Properties.Resources.backing_tracks_accent,
                GUITAR_PLAYERS => Properties.Resources.guitar_player_accent,
                MODES => Properties.Resources.modes_accent,
                TECHNIQUES => Properties.Resources.guitar_pick_accent,
                INFO => Properties.Resources.info_accent,
                _ => Properties.Resources.home_accent,
            };
        }

        private static void ButtonDefaultImage(Button clicledButton)
        {
            clicledButton.Image = clicledButton.Tag switch
            {
                BACKING_TRACKS => Properties.Resources.backing_tracks,
                GUITAR_PLAYERS => Properties.Resources.guitar_player,
                MODES => Properties.Resources.modes,
                TECHNIQUES => Properties.Resources.guitar_pick,
                INFO => Properties.Resources.info,
                _ => Properties.Resources.home,
            };
        }

        private void UpdateOtherButtons(Button clickedButton)
        {
            foreach (var button in _sideBarButtons)
            {
                if (button != clickedButton)
                {
                    button.BackColor = ColorTranslator.FromHtml(Colors.Gray);
                    ButtonDefaultImage(button);
                }
            }
        }

        private void OpenForm(string? formTag)
        {
            switch (formTag)
            {
                case BACKING_TRACKS: OpenChildForm(new FrmBackingTracks()); break;
                case GUITAR_PLAYERS: OpenChildForm(new FrmGuitarPlayers()); break;
                case MODES: OpenChildForm(new FrmModes()); break;
                case TECHNIQUES: OpenChildForm(new FrmTechnique()); break;
                case INFO: OpenChildForm(new frmInfo()); break;
                default: OpenChildForm(new FrmHome()); break;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

    }
}