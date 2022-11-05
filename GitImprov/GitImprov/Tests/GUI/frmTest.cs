using GitImprov.DataBase;
using GitImprov.Tests.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitImprov.Tests.GUI
{
    public partial class frmTest : Form
    {
        private GitImprovContext db = new GitImprovContext();
        private List<Test>? tempTestList;
  
        public frmTest()
        {
            InitializeComponent(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var tempTest = new Test()
            {
                Text = txtInput.Text
            };

            db.Tests?.Add(tempTest);
            db.SaveChanges();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            tempTestList = db.Tests?.ToList();
            txtOutput.Text = tempTestList?[0].Text;
        }
    }
}
