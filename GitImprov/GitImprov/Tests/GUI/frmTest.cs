using GitImprov.DataBase;
using GitImprov.DTO;
using GitImprov.Helpers;
using GitImprov.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = GitImprov.Helpers.Timer;

namespace GitImprov.Tests.GUI
{
    public partial class frmTest : Form
    {
        private LabelsDto _lables;


        public frmTest()
        {
            InitializeComponent();
            _lables = new LabelsDto()
            {
                Timer = lblTimer,
                GuitarPlayer = lblGuitarPlayer,
                Mode = lblMode,
                Technique = lblTechnique,
            };
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            dgvBackingtracks.AutoGenerateColumns = false;
        }

        private void btnRecentlyPlayed_Click(object sender, EventArgs e)
        {

            dgvBackingtracks.DataSource = null;
            dgvBackingtracks.DataSource = AudiofilePlayer.SetTracks();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            AudiofilePlayer.Load(txtSongName);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            AudiofilePlayer.Play();
            Timer.StartTimer(_lables, this);
            MessageBox.Show("Done -> btnPlay");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            AudiofilePlayer.Stop(this);
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            AudiofilePlayer.Looping();
        }

        private void dgvBackingtracks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var track = dgvBackingtracks.SelectedRows[0].DataBoundItem as Backingtrack;

                AudiofilePlayer.LoadFromRecentlyPlayed(track.Name, track.Location, txtSongName);
            }
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            Timer.SetTimer(int.Parse(txtTime.Text));
        }

        private void btnLoadModes_Click(object sender, EventArgs e)
        {
            lblGuitarPlayer.Enabled = false;
        }

        private void btnAddGuitarPlayer_Click(object sender, EventArgs e)
        {
            GuitarPlayerGenerator.AddGuitarPlayer(textBox1.Text);
        }

        private void btnLoadGuitarPlayers_Click(object sender, EventArgs e)
        {
            dgvGuitarPLayers.DataSource = GuitarPlayerGenerator.GetAllGuitarPlayers();
        }
    }
}
