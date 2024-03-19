using GitImprov.Generators;
using GitImprov.Helpers;
using GitImprov.Models;

namespace GitImprov.UI
{
    public partial class FrmModes : Form
    {
        private const int ACTIVITY_INDEX = 2;
        private const int DELETE_INDEX = 3;

        private readonly FrmDialog _frmDialog;
        private readonly ModeService _modeService;

        private List<Mode>? _modes;


        public FrmModes()
        {
            InitializeComponent();

            dgvModes.AutoGenerateColumns = false;

            _modeService = ModeService.GetInstance();

            _frmDialog = new FrmDialog(this.Tag.ToString()!);
            _frmDialog.EntityAdded += LoadModes;
        }

        private void FrmModes_Load(object sender, EventArgs e)
        {
            LoadModes();
        }

        private void LoadModes()
        {
            _modes = _modeService.GetAllModes();

            dgvModes.DataSource = _modes;
            dgvModes.Refresh();
        }

        private void UpdateDataGridView(string searchText)
        {
            var filteredTracks = _modes?
                .Where(gp => gp.Name!.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvModes.DataSource = filteredTracks;
            dgvModes.Refresh();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.Trim();
            UpdateDataGridView(searchText);
        }

        private void DgvModes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedMode = dgvModes.SelectedRows[0].DataBoundItem as Mode;

            if (e.ColumnIndex == ACTIVITY_INDEX)
            {
                _modeService.ChangeActiveStatus(selectedMode!);
                LoadModes();
            }

            if (e.ColumnIndex == DELETE_INDEX)
            {
                if (MessageBox.Show(Messages.ModeDeletedBody, Messages.ModeDeletedTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _modeService.RemoveMode(selectedMode!);
                }
            }

            LoadModes();
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Messages.AllModesDeletedBody, Messages.AllModesDeletedTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _modeService.RemoveAllModes();
                LoadModes();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _frmDialog.ShowDialog();
        }

    }
}
