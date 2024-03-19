using GitImprov.Generators;
using GitImprov.Helpers;
using GitImprov.Models;
using System.Data;

namespace GitImprov.UI
{
    public partial class FrmGuitarPlayers : Form
    {
        private const int ACTIVITY_INDEX = 2;
        private const int DELETE_INDEX = 3;

        private readonly FrmDialog _frmDialog;
        private readonly GuitarPlayerService _guitarPlayerService;

        private List<GuitarPlayer>? _guitarPlayers;


        public FrmGuitarPlayers()
        {
            InitializeComponent();

            dgvGuitarPlayers.AutoGenerateColumns = false;

            _guitarPlayerService = GuitarPlayerService.GetInstance();

            _frmDialog = new FrmDialog(this.Tag.ToString()!);
            _frmDialog.EntityAdded += LoadGuitarPlayers;
        }

        private void FrmGuitarPlayers_Load(object sender, EventArgs e)
        {
            LoadGuitarPlayers();
        }

        private void LoadGuitarPlayers()
        {
            _guitarPlayers = _guitarPlayerService.GetAllGuitarPlayers();

            dgvGuitarPlayers.DataSource = _guitarPlayers;
            dgvGuitarPlayers.Refresh();
        }

        private void UpdateDataGridView(string searchText)
        {
            var filteredTracks = _guitarPlayers?
                .Where(gp => gp.Name!.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvGuitarPlayers.DataSource = filteredTracks;
            dgvGuitarPlayers.Refresh();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.Trim();
            UpdateDataGridView(searchText);
        }

        private void DgvGuitarPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedGuitarPlayer = dgvGuitarPlayers.SelectedRows[0].DataBoundItem as GuitarPlayer;

            if (e.ColumnIndex == ACTIVITY_INDEX)
            {
                _guitarPlayerService.ChangeActiveStatus(selectedGuitarPlayer!);
            }

            if (e.ColumnIndex == DELETE_INDEX)
            {
                if (MessageBox.Show(Messages.GuitarPlayerDeletedBody, Messages.GuitarPlayerDeletedTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _guitarPlayerService.RemoveGuitarPlayer(selectedGuitarPlayer!);
                }

            }

            LoadGuitarPlayers();
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Messages.AllGuitarPlayersDeletedBody, Messages.AllGuitarPlayersDeletedTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _guitarPlayerService.RemoveAllGuitarPlayers();

                LoadGuitarPlayers();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _frmDialog.ShowDialog();
        }

    }
}
