using GitImprov.Controllers;
using GitImprov.Generators;
using GitImprov.Helpers;
using GitImprov.Models;
using System.Data;

namespace GitImprov.UI
{
    public partial class FrmBackingTracks : Form
    {
        private const int ACTIVITY_INDEX = 2;
        private const int LOAD_INDEX = 3;
        private const int DELETE_INDEX = 4;

        private readonly FrmDialog _frmDialog;
        private readonly BackingTrackService _backingTrackService;

        private List<BackingTrack>? _backingTracks;


        public FrmBackingTracks()
        {
            InitializeComponent();

            dgvBackingTracks.AutoGenerateColumns = false;

            _backingTrackService = BackingTrackService.GetInstance();

            _frmDialog = new FrmDialog(this.Tag.ToString()!);
            _frmDialog.EntityAdded += LoadBackingTracks;
        }

        private void FrmBackingTracks_Load(object sender, EventArgs e)
        {
            LoadBackingTracks();
        }

        private void LoadBackingTracks()
        {
            _backingTracks = _backingTrackService.GetAllBakingTracks();

            dgvBackingTracks.DataSource = _backingTracks;
            dgvBackingTracks.Refresh();
        }

        private void UpdateDataGridView(string searchText)
        {
            var filteredTracks = _backingTracks!
                .Where(track => track.Name!.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvBackingTracks.DataSource = filteredTracks;
            dgvBackingTracks.Refresh();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.Trim();
            UpdateDataGridView(searchText);
        }

        private void DgvBackingTracks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedBackingTrack = dgvBackingTracks.SelectedRows[0].DataBoundItem as BackingTrack;

            if (e.ColumnIndex == ACTIVITY_INDEX)
            {
                _backingTrackService.ChangeActiveStatus(selectedBackingTrack!);
            }

            if (e.ColumnIndex == LOAD_INDEX)
            {
                if (AudioFilePlayerController.LoadFromDataBase(selectedBackingTrack!))
                {
                    MessageBox.Show(Messages.LoadBackingTrackBody, Messages.LoadBackingTrackTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Messages.NoAudioFileLoadedBody, Messages.NoAudioFileLoadedTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (e.ColumnIndex == DELETE_INDEX)
            {
                if (MessageBox.Show(Messages.BackingTrackDeletedBody, Messages.GuitarPlayerDeletedTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AudioFilePlayerController.Dispose();
                    _backingTrackService.RemoveBackingTrack(selectedBackingTrack!);
                }
            }

            LoadBackingTracks();
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Messages.AllBackingTracksDeletedBody, Messages.AllBackingTracksDeletedTitle , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _backingTrackService.RemoveAllBackingTracks();
                LoadBackingTracks();
            }
        }

    }
}
