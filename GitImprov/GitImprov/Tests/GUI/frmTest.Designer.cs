namespace GitImprov.Tests.GUI
{
    partial class frmTest
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
            btnRecentlyPlayed = new Button();
            btnPlay = new Button();
            btnStop = new Button();
            btnLoop = new Button();
            txtSongName = new TextBox();
            dgvBackingtracks = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            btnLoad = new Button();
            txtTime = new TextBox();
            lblTimer = new Label();
            lblGuitarPlayer = new Label();
            lblMode = new Label();
            lblTechnique = new Label();
            groupBox1 = new GroupBox();
            dgvGuitarPLayers = new DataGridView();
            btnLoadGuitarPlayers = new Button();
            dgvModes = new DataGridView();
            btnLoadModes = new Button();
            btnLoadTechniques = new Button();
            dgvTechniques = new DataGridView();
            textBox1 = new TextBox();
            btnAddGuitarPlayer = new Button();
            Name = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBackingtracks).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuitarPLayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvModes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTechniques).BeginInit();
            SuspendLayout();
            // 
            // btnRecentlyPlayed
            // 
            btnRecentlyPlayed.Location = new Point(12, 41);
            btnRecentlyPlayed.Name = "btnRecentlyPlayed";
            btnRecentlyPlayed.Size = new Size(75, 23);
            btnRecentlyPlayed.TabIndex = 0;
            btnRecentlyPlayed.Text = "Recently";
            btnRecentlyPlayed.UseVisualStyleBackColor = true;
            btnRecentlyPlayed.Click += btnRecentlyPlayed_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(174, 41);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(255, 41);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnLoop
            // 
            btnLoop.Location = new Point(336, 41);
            btnLoop.Name = "btnLoop";
            btnLoop.Size = new Size(75, 23);
            btnLoop.TabIndex = 3;
            btnLoop.Text = "Loop";
            btnLoop.UseVisualStyleBackColor = true;
            btnLoop.Click += btnLoop_Click;
            // 
            // txtSongName
            // 
            txtSongName.Location = new Point(12, 12);
            txtSongName.Name = "txtSongName";
            txtSongName.ReadOnly = true;
            txtSongName.Size = new Size(399, 23);
            txtSongName.TabIndex = 4;
            txtSongName.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvBackingtracks
            // 
            dgvBackingtracks.AllowUserToAddRows = false;
            dgvBackingtracks.AllowUserToDeleteRows = false;
            dgvBackingtracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBackingtracks.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvBackingtracks.Location = new Point(12, 70);
            dgvBackingtracks.Name = "dgvBackingtracks";
            dgvBackingtracks.ReadOnly = true;
            dgvBackingtracks.RowTemplate.Height = 25;
            dgvBackingtracks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBackingtracks.Size = new Size(399, 150);
            dgvBackingtracks.TabIndex = 5;
            dgvBackingtracks.CellContentClick += dgvBackingtracks_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Name";
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "Location";
            Column2.HeaderText = "Location";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Load";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(93, 41);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(6, 22);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(84, 23);
            txtTime.TabIndex = 7;
            txtTime.TextChanged += txtTime_TextChanged;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.Location = new Point(6, 65);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(84, 37);
            lblTimer.TabIndex = 8;
            lblTimer.Text = "Timer";
            // 
            // lblGuitarPlayer
            // 
            lblGuitarPlayer.AutoSize = true;
            lblGuitarPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGuitarPlayer.Location = new Point(222, 33);
            lblGuitarPlayer.Name = "lblGuitarPlayer";
            lblGuitarPlayer.Size = new Size(96, 21);
            lblGuitarPlayer.TabIndex = 9;
            lblGuitarPlayer.Text = "GuitarPlayer";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMode.Location = new Point(222, 54);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(50, 21);
            lblMode.TabIndex = 10;
            lblMode.Text = "Mode";
            // 
            // lblTechnique
            // 
            lblTechnique.AutoSize = true;
            lblTechnique.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTechnique.Location = new Point(222, 78);
            lblTechnique.Name = "lblTechnique";
            lblTechnique.Size = new Size(79, 21);
            lblTechnique.TabIndex = 11;
            lblTechnique.Text = "Technique";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTime);
            groupBox1.Controls.Add(lblTechnique);
            groupBox1.Controls.Add(lblTimer);
            groupBox1.Controls.Add(lblMode);
            groupBox1.Controls.Add(lblGuitarPlayer);
            groupBox1.Location = new Point(12, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 117);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // dgvGuitarPLayers
            // 
            dgvGuitarPLayers.AllowUserToAddRows = false;
            dgvGuitarPLayers.AllowUserToDeleteRows = false;
            dgvGuitarPLayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuitarPLayers.Columns.AddRange(new DataGridViewColumn[] { Name });
            dgvGuitarPLayers.Location = new Point(12, 369);
            dgvGuitarPLayers.Name = "dgvGuitarPLayers";
            dgvGuitarPLayers.ReadOnly = true;
            dgvGuitarPLayers.RowTemplate.Height = 25;
            dgvGuitarPLayers.Size = new Size(399, 150);
            dgvGuitarPLayers.TabIndex = 13;
            // 
            // btnLoadGuitarPlayers
            // 
            btnLoadGuitarPlayers.Location = new Point(336, 525);
            btnLoadGuitarPlayers.Name = "btnLoadGuitarPlayers";
            btnLoadGuitarPlayers.Size = new Size(75, 23);
            btnLoadGuitarPlayers.TabIndex = 14;
            btnLoadGuitarPlayers.Text = "Load";
            btnLoadGuitarPlayers.UseVisualStyleBackColor = true;
            btnLoadGuitarPlayers.Click += btnLoadGuitarPlayers_Click;
            // 
            // dgvModes
            // 
            dgvModes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModes.Location = new Point(441, 70);
            dgvModes.Name = "dgvModes";
            dgvModes.RowTemplate.Height = 25;
            dgvModes.Size = new Size(399, 150);
            dgvModes.TabIndex = 15;
            // 
            // btnLoadModes
            // 
            btnLoadModes.Location = new Point(765, 226);
            btnLoadModes.Name = "btnLoadModes";
            btnLoadModes.Size = new Size(75, 23);
            btnLoadModes.TabIndex = 16;
            btnLoadModes.Text = "Load";
            btnLoadModes.UseVisualStyleBackColor = true;
            btnLoadModes.Click += btnLoadModes_Click;
            // 
            // btnLoadTechniques
            // 
            btnLoadTechniques.Location = new Point(765, 525);
            btnLoadTechniques.Name = "btnLoadTechniques";
            btnLoadTechniques.Size = new Size(75, 23);
            btnLoadTechniques.TabIndex = 17;
            btnLoadTechniques.Text = "Load";
            btnLoadTechniques.UseVisualStyleBackColor = true;
            // 
            // dgvTechniques
            // 
            dgvTechniques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTechniques.Location = new Point(441, 369);
            dgvTechniques.Name = "dgvTechniques";
            dgvTechniques.RowTemplate.Height = 25;
            dgvTechniques.Size = new Size(399, 150);
            dgvTechniques.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 526);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 19;
            // 
            // btnAddGuitarPlayer
            // 
            btnAddGuitarPlayer.Location = new Point(118, 526);
            btnAddGuitarPlayer.Name = "btnAddGuitarPlayer";
            btnAddGuitarPlayer.Size = new Size(75, 23);
            btnAddGuitarPlayer.TabIndex = 20;
            btnAddGuitarPlayer.Text = "button1";
            btnAddGuitarPlayer.UseVisualStyleBackColor = true;
            btnAddGuitarPlayer.Click += btnAddGuitarPlayer_Click;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Column4";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 807);
            Controls.Add(btnAddGuitarPlayer);
            Controls.Add(textBox1);
            Controls.Add(dgvTechniques);
            Controls.Add(btnLoadTechniques);
            Controls.Add(btnLoadModes);
            Controls.Add(dgvModes);
            Controls.Add(btnLoadGuitarPlayers);
            Controls.Add(dgvGuitarPLayers);
            Controls.Add(groupBox1);
            Controls.Add(btnLoad);
            Controls.Add(dgvBackingtracks);
            Controls.Add(txtSongName);
            Controls.Add(btnLoop);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Controls.Add(btnRecentlyPlayed);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTest";
            Load += frmTest_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBackingtracks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuitarPLayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvModes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTechniques).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRecentlyPlayed;
        private Button btnPlay;
        private Button btnStop;
        private Button btnLoop;
        private TextBox txtSongName;
        private DataGridView dgvBackingtracks;
        private Button btnLoad;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
        private TextBox txtTime;
        private Label lblTimer;
        private Label lblGuitarPlayer;
        private Label lblMode;
        private Label lblTechnique;
        private GroupBox groupBox1;
        private DataGridView dgvGuitarPLayers;
        private Button btnLoadGuitarPlayers;
        private DataGridView dgvModes;
        private Button btnLoadModes;
        private Button btnLoadTechniques;
        private DataGridView dgvTechniques;
        private TextBox textBox1;
        private Button btnAddGuitarPlayer;
        private DataGridViewTextBoxColumn Name;
    }
}