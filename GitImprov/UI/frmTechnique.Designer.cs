namespace GitImprov.UI
{
    partial class FrmTechnique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlContentHolder = new Panel();
            btnAdd = new Button();
            btnRemoveAll = new Button();
            txtSearch = new TextBox();
            pnlDgvBorder = new Panel();
            dgvTechniques = new DataGridView();
            TechniqueName = new DataGridViewTextBoxColumn();
            ActiveStatus = new DataGridViewTextBoxColumn();
            BtnOnOff = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            pnlContentHolder.SuspendLayout();
            pnlDgvBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTechniques).BeginInit();
            SuspendLayout();
            // 
            // pnlContentHolder
            // 
            pnlContentHolder.Controls.Add(btnAdd);
            pnlContentHolder.Controls.Add(btnRemoveAll);
            pnlContentHolder.Controls.Add(txtSearch);
            pnlContentHolder.Controls.Add(pnlDgvBorder);
            pnlContentHolder.Location = new Point(10, 10);
            pnlContentHolder.Margin = new Padding(1);
            pnlContentHolder.Name = "pnlContentHolder";
            pnlContentHolder.Size = new Size(796, 527);
            pnlContentHolder.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(70, 70, 70);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.Location = new Point(675, 478);
            btnAdd.Margin = new Padding(5, 0, 5, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(35, 35);
            btnAdd.TabIndex = 8;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Anchor = AnchorStyles.None;
            btnRemoveAll.BackColor = Color.Teal;
            btnRemoveAll.Cursor = Cursors.Hand;
            btnRemoveAll.FlatAppearance.BorderSize = 0;
            btnRemoveAll.FlatStyle = FlatStyle.Flat;
            btnRemoveAll.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveAll.ForeColor = Color.White;
            btnRemoveAll.Image = Properties.Resources.bin;
            btnRemoveAll.Location = new Point(720, 477);
            btnRemoveAll.Margin = new Padding(5, 0, 5, 15);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(70, 35);
            btnRemoveAll.TabIndex = 7;
            btnRemoveAll.UseVisualStyleBackColor = false;
            btnRemoveAll.Click += BtnRemoveAll_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.BackColor = Color.FromArgb(237, 237, 237);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.ForeColor = Color.FromArgb(23, 23, 23);
            txtSearch.Location = new Point(5, 15);
            txtSearch.Margin = new Padding(5, 15, 5, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(786, 23);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // pnlDgvBorder
            // 
            pnlDgvBorder.BackColor = Color.FromArgb(70, 70, 70);
            pnlDgvBorder.Controls.Add(dgvTechniques);
            pnlDgvBorder.Location = new Point(5, 68);
            pnlDgvBorder.Margin = new Padding(3, 30, 3, 3);
            pnlDgvBorder.Name = "pnlDgvBorder";
            pnlDgvBorder.Size = new Size(786, 351);
            pnlDgvBorder.TabIndex = 5;
            // 
            // dgvTechniques
            // 
            dgvTechniques.AllowUserToAddRows = false;
            dgvTechniques.AllowUserToDeleteRows = false;
            dgvTechniques.Anchor = AnchorStyles.None;
            dgvTechniques.BackgroundColor = Color.FromArgb(32, 32, 32);
            dgvTechniques.BorderStyle = BorderStyle.None;
            dgvTechniques.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTechniques.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTechniques.ColumnHeadersHeight = 35;
            dgvTechniques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTechniques.Columns.AddRange(new DataGridViewColumn[] { TechniqueName, ActiveStatus, BtnOnOff, BtnDelete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle5.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvTechniques.DefaultCellStyle = dataGridViewCellStyle5;
            dgvTechniques.EnableHeadersVisualStyles = false;
            dgvTechniques.GridColor = Color.FromArgb(68, 68, 68);
            dgvTechniques.Location = new Point(1, 1);
            dgvTechniques.Margin = new Padding(1);
            dgvTechniques.Name = "dgvTechniques";
            dgvTechniques.ReadOnly = true;
            dgvTechniques.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvTechniques.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvTechniques.RowHeadersVisible = false;
            dgvTechniques.RowHeadersWidth = 40;
            dgvTechniques.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTechniques.RowTemplate.Height = 40;
            dgvTechniques.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvTechniques.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTechniques.Size = new Size(784, 349);
            dgvTechniques.TabIndex = 4;
            dgvTechniques.CellContentClick += DgvTechniques_CellContentClick;
            // 
            // TechniqueName
            // 
            TechniqueName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TechniqueName.DataPropertyName = "Name";
            TechniqueName.HeaderText = "Technique";
            TechniqueName.Name = "TechniqueName";
            TechniqueName.ReadOnly = true;
            // 
            // ActiveStatus
            // 
            ActiveStatus.DataPropertyName = "ActiveText";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ActiveStatus.DefaultCellStyle = dataGridViewCellStyle2;
            ActiveStatus.HeaderText = "Active";
            ActiveStatus.Name = "ActiveStatus";
            ActiveStatus.ReadOnly = true;
            // 
            // BtnOnOff
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 166, 166);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 166, 166);
            BtnOnOff.DefaultCellStyle = dataGridViewCellStyle3;
            BtnOnOff.FlatStyle = FlatStyle.Flat;
            BtnOnOff.HeaderText = "";
            BtnOnOff.MinimumWidth = 125;
            BtnOnOff.Name = "BtnOnOff";
            BtnOnOff.ReadOnly = true;
            BtnOnOff.Text = "On / Off";
            BtnOnOff.UseColumnTextForButtonValue = true;
            BtnOnOff.Width = 125;
            // 
            // BtnDelete
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 166, 166);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 166, 166);
            BtnDelete.DefaultCellStyle = dataGridViewCellStyle4;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.HeaderText = "";
            BtnDelete.MinimumWidth = 125;
            BtnDelete.Name = "BtnDelete";
            BtnDelete.ReadOnly = true;
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            BtnDelete.Width = 125;
            // 
            // FrmTechnique
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(816, 547);
            Controls.Add(pnlContentHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTechnique";
            Tag = "Technique";
            Text = "frmTechnique";
            Load += FrmTechnique_Load;
            pnlContentHolder.ResumeLayout(false);
            pnlContentHolder.PerformLayout();
            pnlDgvBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTechniques).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContentHolder;
        private Panel pnlDgvBorder;
        private TextBox txtSearch;
        private DataGridView dgvTechniques;
        private Button btnRemoveAll;
        private Button btnAdd;
        private DataGridViewTextBoxColumn TechniqueName;
        private DataGridViewTextBoxColumn ActiveStatus;
        private DataGridViewButtonColumn BtnOnOff;
        private DataGridViewButtonColumn BtnDelete;
    }
}