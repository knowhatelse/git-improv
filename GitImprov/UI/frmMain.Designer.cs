namespace GitImprov.UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pnlSideBar = new Panel();
            btnTechniques = new Button();
            btnModes = new Button();
            btnInfo = new Button();
            btnGuitarPlayers = new Button();
            btnBackingTracks = new Button();
            btnHome = new Button();
            pnlNav = new Panel();
            lblNavText = new Label();
            pnlContent = new Panel();
            pnlSideBar.SuspendLayout();
            pnlNav.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(51, 51, 51);
            pnlSideBar.Controls.Add(btnTechniques);
            pnlSideBar.Controls.Add(btnModes);
            pnlSideBar.Controls.Add(btnInfo);
            pnlSideBar.Controls.Add(btnGuitarPlayers);
            pnlSideBar.Controls.Add(btnBackingTracks);
            pnlSideBar.Controls.Add(btnHome);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(50, 661);
            pnlSideBar.TabIndex = 0;
            // 
            // btnTechniques
            // 
            btnTechniques.BackgroundImageLayout = ImageLayout.Center;
            btnTechniques.Cursor = Cursors.Hand;
            btnTechniques.Dock = DockStyle.Top;
            btnTechniques.FlatAppearance.BorderColor = Color.FromArgb(23, 23, 23);
            btnTechniques.FlatAppearance.BorderSize = 0;
            btnTechniques.FlatStyle = FlatStyle.Flat;
            btnTechniques.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTechniques.ForeColor = Color.FromArgb(23, 23, 23);
            btnTechniques.Image = Properties.Resources.guitar_pick;
            btnTechniques.Location = new Point(0, 400);
            btnTechniques.Name = "btnTechniques";
            btnTechniques.Size = new Size(50, 100);
            btnTechniques.TabIndex = 5;
            btnTechniques.Tag = "Techniques";
            btnTechniques.UseVisualStyleBackColor = true;
            // 
            // btnModes
            // 
            btnModes.BackgroundImageLayout = ImageLayout.Center;
            btnModes.Cursor = Cursors.Hand;
            btnModes.Dock = DockStyle.Top;
            btnModes.FlatAppearance.BorderColor = Color.FromArgb(23, 23, 23);
            btnModes.FlatAppearance.BorderSize = 0;
            btnModes.FlatStyle = FlatStyle.Flat;
            btnModes.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnModes.ForeColor = Color.FromArgb(23, 23, 23);
            btnModes.Image = Properties.Resources.modes;
            btnModes.Location = new Point(0, 300);
            btnModes.Name = "btnModes";
            btnModes.Size = new Size(50, 100);
            btnModes.TabIndex = 4;
            btnModes.Tag = "Modes";
            btnModes.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.BackgroundImageLayout = ImageLayout.Center;
            btnInfo.Cursor = Cursors.Hand;
            btnInfo.Dock = DockStyle.Bottom;
            btnInfo.FlatAppearance.BorderColor = Color.FromArgb(23, 23, 23);
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Image = Properties.Resources.info;
            btnInfo.Location = new Point(0, 631);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(50, 30);
            btnInfo.TabIndex = 3;
            btnInfo.Tag = "Info";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnGuitarPlayers
            // 
            btnGuitarPlayers.BackgroundImageLayout = ImageLayout.Center;
            btnGuitarPlayers.Cursor = Cursors.Hand;
            btnGuitarPlayers.Dock = DockStyle.Top;
            btnGuitarPlayers.FlatAppearance.BorderColor = Color.FromArgb(23, 23, 23);
            btnGuitarPlayers.FlatAppearance.BorderSize = 0;
            btnGuitarPlayers.FlatStyle = FlatStyle.Flat;
            btnGuitarPlayers.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuitarPlayers.ForeColor = Color.FromArgb(23, 23, 23);
            btnGuitarPlayers.Image = Properties.Resources.guitar_player;
            btnGuitarPlayers.Location = new Point(0, 200);
            btnGuitarPlayers.Name = "btnGuitarPlayers";
            btnGuitarPlayers.Size = new Size(50, 100);
            btnGuitarPlayers.TabIndex = 2;
            btnGuitarPlayers.Tag = "Guitar players";
            btnGuitarPlayers.UseVisualStyleBackColor = true;
            // 
            // btnBackingTracks
            // 
            btnBackingTracks.BackgroundImageLayout = ImageLayout.Center;
            btnBackingTracks.Cursor = Cursors.Hand;
            btnBackingTracks.Dock = DockStyle.Top;
            btnBackingTracks.FlatAppearance.BorderColor = Color.FromArgb(23, 23, 23);
            btnBackingTracks.FlatAppearance.BorderSize = 0;
            btnBackingTracks.FlatStyle = FlatStyle.Flat;
            btnBackingTracks.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackingTracks.ForeColor = Color.FromArgb(23, 23, 23);
            btnBackingTracks.Image = Properties.Resources.backing_tracks;
            btnBackingTracks.Location = new Point(0, 100);
            btnBackingTracks.Name = "btnBackingTracks";
            btnBackingTracks.Size = new Size(50, 100);
            btnBackingTracks.TabIndex = 1;
            btnBackingTracks.Tag = "Backing tracks";
            btnBackingTracks.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.BackgroundImageLayout = ImageLayout.Center;
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(23, 23, 23);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.FromArgb(23, 23, 23);
            btnHome.Image = Properties.Resources.home_accent;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(50, 100);
            btnHome.TabIndex = 0;
            btnHome.Tag = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Teal;
            pnlNav.Controls.Add(lblNavText);
            pnlNav.Dock = DockStyle.Top;
            pnlNav.Location = new Point(50, 0);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(834, 100);
            pnlNav.TabIndex = 1;
            // 
            // lblNavText
            // 
            lblNavText.AutoSize = true;
            lblNavText.FlatStyle = FlatStyle.Flat;
            lblNavText.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblNavText.ForeColor = Color.White;
            lblNavText.Location = new Point(8, 52);
            lblNavText.Margin = new Padding(5, 5, 5, 10);
            lblNavText.Name = "lblNavText";
            lblNavText.Size = new Size(110, 38);
            lblNavText.TabIndex = 0;
            lblNavText.Text = "Home";
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.None;
            pnlContent.Location = new Point(58, 104);
            pnlContent.Margin = new Padding(1);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(816, 547);
            pnlContent.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(884, 661);
            Controls.Add(pnlContent);
            Controls.Add(pnlNav);
            Controls.Add(pnlSideBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(900, 700);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GitImprov";
            pnlSideBar.ResumeLayout(false);
            pnlNav.ResumeLayout(false);
            pnlNav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSideBar;
        private Button btnTechniques;
        private Button btnModes;
        private Button btnInfo;
        private Button btnGuitarPlayers;
        private Button btnBackingTracks;
        private Button btnHome;
        private Panel pnlNav;
        private Panel pnlContent;
        private Label lblNavText;
    }
}