namespace GitImprov.UI
{
    partial class FrmGuitarPlayers
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
            pnlContetnHolder = new Panel();
            btnAdd = new Button();
            btnRemoveAll = new Button();
            pnlDgvBorder = new Panel();
            dgvGuitarPlayers = new DataGridView();
            txtSearch = new TextBox();
            GuitarPlayerName = new DataGridViewTextBoxColumn();
            ActiveStatus = new DataGridViewTextBoxColumn();
            BtnOnOff = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            pnlContetnHolder.SuspendLayout();
            pnlDgvBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuitarPlayers).BeginInit();
            SuspendLayout();
            // 
            // pnlContetnHolder
            // 
            pnlContetnHolder.Anchor = AnchorStyles.None;
            pnlContetnHolder.BackColor = Color.FromArgb(32, 32, 32);
            pnlContetnHolder.Controls.Add(btnAdd);
            pnlContetnHolder.Controls.Add(btnRemoveAll);
            pnlContetnHolder.Controls.Add(pnlDgvBorder);
            pnlContetnHolder.Controls.Add(txtSearch);
            pnlContetnHolder.Location = new Point(10, 10);
            pnlContetnHolder.Margin = new Padding(1);
            pnlContetnHolder.Name = "pnlContetnHolder";
            pnlContetnHolder.Size = new Size(796, 527);
            pnlContetnHolder.TabIndex = 8;
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
            btnAdd.TabIndex = 7;
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
            btnRemoveAll.TabIndex = 6;
            btnRemoveAll.UseVisualStyleBackColor = false;
            btnRemoveAll.Click += BtnRemoveAll_Click;
            // 
            // pnlDgvBorder
            // 
            pnlDgvBorder.Anchor = AnchorStyles.None;
            pnlDgvBorder.BackColor = Color.FromArgb(70, 70, 70);
            pnlDgvBorder.Controls.Add(dgvGuitarPlayers);
            pnlDgvBorder.Location = new Point(5, 68);
            pnlDgvBorder.Margin = new Padding(5, 30, 5, 0);
            pnlDgvBorder.Name = "pnlDgvBorder";
            pnlDgvBorder.Size = new Size(786, 351);
            pnlDgvBorder.TabIndex = 2;
            // 
            // dgvGuitarPlayers
            // 
            dgvGuitarPlayers.AllowUserToAddRows = false;
            dgvGuitarPlayers.AllowUserToDeleteRows = false;
            dgvGuitarPlayers.Anchor = AnchorStyles.None;
            dgvGuitarPlayers.BackgroundColor = Color.FromArgb(32, 32, 32);
            dgvGuitarPlayers.BorderStyle = BorderStyle.None;
            dgvGuitarPlayers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGuitarPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGuitarPlayers.ColumnHeadersHeight = 35;
            dgvGuitarPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvGuitarPlayers.Columns.AddRange(new DataGridViewColumn[] { GuitarPlayerName, ActiveStatus, BtnOnOff, BtnDelete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle5.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvGuitarPlayers.DefaultCellStyle = dataGridViewCellStyle5;
            dgvGuitarPlayers.EnableHeadersVisualStyles = false;
            dgvGuitarPlayers.GridColor = Color.FromArgb(68, 68, 68);
            dgvGuitarPlayers.Location = new Point(1, 1);
            dgvGuitarPlayers.Margin = new Padding(1);
            dgvGuitarPlayers.Name = "dgvGuitarPlayers";
            dgvGuitarPlayers.ReadOnly = true;
            dgvGuitarPlayers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvGuitarPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvGuitarPlayers.RowHeadersVisible = false;
            dgvGuitarPlayers.RowHeadersWidth = 40;
            dgvGuitarPlayers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvGuitarPlayers.RowTemplate.Height = 40;
            dgvGuitarPlayers.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvGuitarPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuitarPlayers.Size = new Size(784, 349);
            dgvGuitarPlayers.TabIndex = 3;
            dgvGuitarPlayers.CellContentClick += DgvGuitarPlayers_CellContentClick;
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
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // GuitarPlayerName
            // 
            GuitarPlayerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GuitarPlayerName.DataPropertyName = "Name";
            GuitarPlayerName.HeaderText = "Guitar player";
            GuitarPlayerName.Name = "GuitarPlayerName";
            GuitarPlayerName.ReadOnly = true;
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
            // FrmGuitarPlayers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(816, 547);
            Controls.Add(pnlContetnHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGuitarPlayers";
            Tag = "Guitar player";
            Text = "frmGuitarPlayers";
            Load += FrmGuitarPlayers_Load;
            pnlContetnHolder.ResumeLayout(false);
            pnlContetnHolder.PerformLayout();
            pnlDgvBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGuitarPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlContetnHolder;
        private TextBox txtSearch;
        private Panel pnlDgvBorder;
        private DataGridView dgvGuitarPlayers;
        private Button btnRemoveAll;
        private Button btnAdd;
        private DataGridViewTextBoxColumn GuitarPlayerName;
        private DataGridViewTextBoxColumn ActiveStatus;
        private DataGridViewButtonColumn BtnOnOff;
        private DataGridViewButtonColumn BtnDelete;
    }
}