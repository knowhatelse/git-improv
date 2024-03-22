using GitImprov.Generators;
using GitImprov.Helpers;
using GitImprov.Models;
using System.Data;

namespace GitImprov.UI
{
    public partial class FrmTechnique : Form
    {
        private const int ACTIVITY_INDEX = 2;
        private const int DELETE_INDEX = 3;

        private readonly FrmDialog _frmDialog;
        private readonly TechniqueService _techniqueService;

        private List<Technique>? _techniques;


        public FrmTechnique()
        {
            InitializeComponent();

            dgvTechniques.AutoGenerateColumns = false;

            _techniqueService = TechniqueService.GetInstance();

            _frmDialog = new FrmDialog(this.Tag!.ToString()!);
            _frmDialog.EntityAdded += LoadTechniques;
        }

        private void FrmTechnique_Load(object sender, EventArgs e)
        {
            LoadTechniques();
        }

        public void LoadTechniques()
        {
            _techniques = _techniqueService.GetAllTechniques();

            dgvTechniques.DataSource = _techniques;
            dgvTechniques.Refresh();
        }

        private void UpdateDataGridView(string searchText)
        {
            var filteredTracks = _techniques?
                .Where(gp => gp.Name!.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dgvTechniques.DataSource = filteredTracks;
            dgvTechniques.Refresh();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.Trim();
            UpdateDataGridView(searchText);
        }

        private void DgvTechniques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedTechnique = dgvTechniques.SelectedRows[0].DataBoundItem as Technique;

            if (e.ColumnIndex == ACTIVITY_INDEX)
            {
                _techniqueService.ChangeActiveStatus(selectedTechnique!);
            }

            if (e.ColumnIndex == DELETE_INDEX)
            {
                if (MessageBox.Show(Messages.TechniqueDeletedBody, Messages.ModeDeletedTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _techniqueService.RemoveTechnique(selectedTechnique!);
                }
            }

            LoadTechniques();
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Messages.AllTechniquesDeletedBody, Messages.AllModesDeletedTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _techniqueService.RemoveAllTechniques();
                LoadTechniques();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _frmDialog.ShowDialog();
        }

    }
}
