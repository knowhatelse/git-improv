using GitImprov.Generators;
using GitImprov.Helpers;
using TimerController = GitImprov.Controllers.TimerController;

namespace GitImprov.UI
{
    public partial class FrmDialog : Form
    {
        private const string HOME = "Home";
        private const string GUITAR_PLAYER = "Guitar player";
        private const string MODE = "Mode";
        private const string TECHNIQUE = "Technique";

        private readonly string _type;

        private readonly GuitarPlayerService _guitarPlayerService;
        private readonly ModeService _modeService;
        private readonly TechniqueService _techniqueService;

        public delegate void EntityAddedDelegate();
        public event EntityAddedDelegate? EntityAdded;


        public FrmDialog(string fromTag)
        {
            InitializeComponent();
            
            _type = fromTag;

            _guitarPlayerService = GuitarPlayerService.GetInstance();
            _modeService = ModeService.GetInstance();
            _techniqueService = TechniqueService.GetInstance();
        }

        private void FrmAddNew_Load(object sender, EventArgs e)
        {
            TitleBarSettings.UseImmersiveDarkMode(this.Handle, true);

            if (_type == HOME)
            {
                this.Text = "Timer settings";
                lblText.Text = "Set improvisation time: ";
                btnAdd.Text = "Set time";
            }
            else
            {
                this.Text = $"Add new {_type.ToLower()}";
                lblText.Text = $"Enter {_type.ToLower()} name:";
            }
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var response = true;

            switch (_type)
            {
                case GUITAR_PLAYER:
                    {
                        response = _guitarPlayerService.AddGuitarPlayer(txtName.Text);
                        break;
                    }
                case MODE:
                    {
                        response = _modeService.AddMode(txtName.Text);
                        break;
                    }
                case TECHNIQUE:
                    {
                        response = _techniqueService.AddTechnique(txtName.Text);
                        break;
                    }
                default:
                    {
                        TimerController.SetTimer(int.Parse(txtName.Text));
                        this.Close();
                        break;
                    }
            }

            if (!response)
            {
                MessageBox.Show(Messages.AllreadyExistsBody, Messages.AllreadyExistsTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OnEntityAdded();
                txtName.Clear();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            this.Close();
        }

        protected virtual void OnEntityAdded()
        {
            EntityAdded?.Invoke();
        }

    }
}
