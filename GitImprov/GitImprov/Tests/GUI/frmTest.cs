using GitImprov.DataBase;
using GitImprov.Helpers;
using GitImprov.Tests.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitImprov.Tests.GUI
{
    public partial class frmTest : Form
    {
        private int loopCounter = 0;

        public frmTest()
        {
            InitializeComponent(); 
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            AudiofilePlayer.Play();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            AudiofilePlayer.Load();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            AudiofilePlayer.Stop();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (loopCounter % 2 == 0) { AudiofilePlayer.Loop = true; }
            else {AudiofilePlayer.Loop = false;}

            loopCounter++;
        }
    }
}
