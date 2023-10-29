namespace GitImprov.UI
{
    partial class FrmBackingTracks
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            pnlDgvBorder = new Panel();
            dgvBackingTracks = new DataGridView();
            BackingTrackName = new DataGridViewTextBoxColumn();
            ActiveText = new DataGridViewTextBoxColumn();
            btnOnOff = new DataGridViewButtonColumn();
            BtnLoad = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            pnlContentHolder = new Panel();
            btnRemoveAll = new Button();
            pnlDgvBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBackingTracks).BeginInit();
            pnlContentHolder.SuspendLayout();
            SuspendLayout();
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
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // pnlDgvBorder
            // 
            pnlDgvBorder.Anchor = AnchorStyles.None;
            pnlDgvBorder.BackColor = Color.FromArgb(70, 70, 70);
            pnlDgvBorder.Controls.Add(dgvBackingTracks);
            pnlDgvBorder.Location = new Point(5, 68);
            pnlDgvBorder.Margin = new Padding(5, 30, 5, 0);
            pnlDgvBorder.Name = "pnlDgvBorder";
            pnlDgvBorder.Size = new Size(786, 351);
            pnlDgvBorder.TabIndex = 1;
            // 
            // dgvBackingTracks
            // 
            dgvBackingTracks.AllowUserToAddRows = false;
            dgvBackingTracks.AllowUserToDeleteRows = false;
            dgvBackingTracks.Anchor = AnchorStyles.None;
            dgvBackingTracks.BackgroundColor = Color.FromArgb(32, 32, 32);
            dgvBackingTracks.BorderStyle = BorderStyle.None;
            dgvBackingTracks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBackingTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBackingTracks.ColumnHeadersHeight = 35;
            dgvBackingTracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBackingTracks.Columns.AddRange(new DataGridViewColumn[] { BackingTrackName, ActiveText, btnOnOff, BtnLoad, BtnDelete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle6.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvBackingTracks.DefaultCellStyle = dataGridViewCellStyle6;
            dgvBackingTracks.EnableHeadersVisualStyles = false;
            dgvBackingTracks.GridColor = Color.FromArgb(68, 68, 68);
            dgvBackingTracks.Location = new Point(1, 1);
            dgvBackingTracks.Margin = new Padding(1);
            dgvBackingTracks.Name = "dgvBackingTracks";
            dgvBackingTracks.ReadOnly = true;
            dgvBackingTracks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvBackingTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvBackingTracks.RowHeadersVisible = false;
            dgvBackingTracks.RowHeadersWidth = 40;
            dgvBackingTracks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBackingTracks.RowTemplate.Height = 40;
            dgvBackingTracks.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvBackingTracks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBackingTracks.Size = new Size(784, 349);
            dgvBackingTracks.TabIndex = 2;
            dgvBackingTracks.CellContentClick += DgvBackingTracks_CellContentClick;
            // 
            // BackingTrackName
            // 
            BackingTrackName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BackingTrackName.DataPropertyName = "Name";
            BackingTrackName.HeaderText = "Backing tracks ";
            BackingTrackName.Name = "BackingTrackName";
            BackingTrackName.ReadOnly = true;
            // 
            // ActiveText
            // 
            ActiveText.DataPropertyName = "ActiveText";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ActiveText.DefaultCellStyle = dataGridViewCellStyle2;
            ActiveText.HeaderText = "Active";
            ActiveText.Name = "ActiveText";
            ActiveText.ReadOnly = true;
            // 
            // btnOnOff
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 166, 166);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 166, 166);
            btnOnOff.DefaultCellStyle = dataGridViewCellStyle3;
            btnOnOff.FlatStyle = FlatStyle.Flat;
            btnOnOff.HeaderText = "";
            btnOnOff.MinimumWidth = 125;
            btnOnOff.Name = "btnOnOff";
            btnOnOff.ReadOnly = true;
            btnOnOff.Text = "On / Off";
            btnOnOff.UseColumnTextForButtonValue = true;
            btnOnOff.Width = 125;
            // 
            // BtnLoad
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 166, 166);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 166, 166);
            BtnLoad.DefaultCellStyle = dataGridViewCellStyle4;
            BtnLoad.FlatStyle = FlatStyle.Flat;
            BtnLoad.HeaderText = "";
            BtnLoad.MinimumWidth = 125;
            BtnLoad.Name = "BtnLoad";
            BtnLoad.ReadOnly = true;
            BtnLoad.Text = "Load";
            BtnLoad.UseColumnTextForButtonValue = true;
            BtnLoad.Width = 125;
            // 
            // BtnDelete
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle5.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(0, 166, 166);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 166, 166);
            BtnDelete.DefaultCellStyle = dataGridViewCellStyle5;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.HeaderText = "";
            BtnDelete.MinimumWidth = 125;
            BtnDelete.Name = "BtnDelete";
            BtnDelete.ReadOnly = true;
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            BtnDelete.Width = 125;
            // 
            // pnlContentHolder
            // 
            pnlContentHolder.Anchor = AnchorStyles.None;
            pnlContentHolder.BackColor = Color.FromArgb(32, 32, 32);
            pnlContentHolder.Controls.Add(btnRemoveAll);
            pnlContentHolder.Controls.Add(txtSearch);
            pnlContentHolder.Controls.Add(pnlDgvBorder);
            pnlContentHolder.Location = new Point(10, 10);
            pnlContentHolder.Margin = new Padding(1);
            pnlContentHolder.Name = "pnlContentHolder";
            pnlContentHolder.Size = new Size(796, 527);
            pnlContentHolder.TabIndex = 6;
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
            // FrmBackingTracks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(816, 547);
            Controls.Add(pnlContentHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBackingTracks";
            Tag = "Backing track";
            Text = "frmBackingTracks";
            Load += FrmBackingTracks_Load;
            pnlDgvBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBackingTracks).EndInit();
            pnlContentHolder.ResumeLayout(false);
            pnlContentHolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private Panel pnlDgvBorder;
        private DataGridView dgvBackingTracks;
        private Panel pnlContentHolder;
        private Button btnRemoveAll;
        private DataGridViewTextBoxColumn BackingTrackName;
        private DataGridViewTextBoxColumn ActiveText;
        private DataGridViewButtonColumn btnOnOff;
        private DataGridViewButtonColumn BtnLoad;
        private DataGridViewButtonColumn BtnDelete;
    }
}