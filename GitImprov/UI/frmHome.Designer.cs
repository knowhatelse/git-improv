namespace GitImprov.UI
{
    partial class FrmHome
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
            pnlContent = new Panel();
            pnlTimerBorder = new Panel();
            pnlTimer = new Panel();
            btnTimerText = new Button();
            panel1 = new Panel();
            btnTimerOff = new Button();
            btnTimerSettings = new Button();
            btnTimerHeader = new Button();
            pnlGeneratorBorder = new Panel();
            pnlNotes = new Panel();
            btnNoteText = new Button();
            btnNotesOff = new Button();
            btnNoteHeader = new Button();
            pnlTechnique = new Panel();
            btnTechniqueText = new Button();
            btnTechniqueHeader = new Button();
            btnTechniqueOff = new Button();
            pnlMode = new Panel();
            btnModeText = new Button();
            btnModeHeader = new Button();
            btnModeOff = new Button();
            pnlGuitarPlayer = new Panel();
            btnGuitarPlayerText = new Button();
            btnGuitarPlayerHeader = new Button();
            btnGuitarPlayerOff = new Button();
            pnlControls = new Panel();
            btnSuffle = new Button();
            btnLoop = new Button();
            btnStop = new Button();
            btnPlay = new Button();
            btnPause = new Button();
            btnResume = new Button();
            btnLoad = new Button();
            pnlVolumes = new Panel();
            btnVolumeDown = new Button();
            btnVolumeUp = new Button();
            txtBackingTrackName = new TextBox();
            pnlContent.SuspendLayout();
            pnlTimerBorder.SuspendLayout();
            pnlTimer.SuspendLayout();
            panel1.SuspendLayout();
            pnlGeneratorBorder.SuspendLayout();
            pnlNotes.SuspendLayout();
            pnlTechnique.SuspendLayout();
            pnlMode.SuspendLayout();
            pnlGuitarPlayer.SuspendLayout();
            pnlControls.SuspendLayout();
            pnlVolumes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.None;
            pnlContent.Controls.Add(pnlTimerBorder);
            pnlContent.Controls.Add(pnlGeneratorBorder);
            pnlContent.Controls.Add(pnlControls);
            pnlContent.Controls.Add(txtBackingTrackName);
            pnlContent.Location = new Point(10, 10);
            pnlContent.Margin = new Padding(1);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(796, 527);
            pnlContent.TabIndex = 0;
            // 
            // pnlTimerBorder
            // 
            pnlTimerBorder.Anchor = AnchorStyles.None;
            pnlTimerBorder.BackColor = Color.FromArgb(70, 70, 70);
            pnlTimerBorder.Controls.Add(pnlTimer);
            pnlTimerBorder.Location = new Point(5, 68);
            pnlTimerBorder.Margin = new Padding(5, 30, 5, 20);
            pnlTimerBorder.Name = "pnlTimerBorder";
            pnlTimerBorder.Size = new Size(786, 211);
            pnlTimerBorder.TabIndex = 3;
            // 
            // pnlTimer
            // 
            pnlTimer.BackColor = Color.FromArgb(32, 32, 32);
            pnlTimer.Controls.Add(btnTimerText);
            pnlTimer.Controls.Add(panel1);
            pnlTimer.Controls.Add(btnTimerHeader);
            pnlTimer.Location = new Point(2, 2);
            pnlTimer.Margin = new Padding(2);
            pnlTimer.Name = "pnlTimer";
            pnlTimer.Size = new Size(783, 207);
            pnlTimer.TabIndex = 0;
            // 
            // btnTimerText
            // 
            btnTimerText.Anchor = AnchorStyles.None;
            btnTimerText.FlatAppearance.BorderSize = 0;
            btnTimerText.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnTimerText.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnTimerText.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnTimerText.FlatStyle = FlatStyle.Flat;
            btnTimerText.Font = new Font("Verdana", 64F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimerText.ForeColor = Color.White;
            btnTimerText.Location = new Point(0, 35);
            btnTimerText.Name = "btnTimerText";
            btnTimerText.Size = new Size(783, 147);
            btnTimerText.TabIndex = 8;
            btnTimerText.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimerOff);
            panel1.Controls.Add(btnTimerSettings);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 25);
            panel1.TabIndex = 9;
            // 
            // btnTimerOff
            // 
            btnTimerOff.Anchor = AnchorStyles.None;
            btnTimerOff.Cursor = Cursors.Hand;
            btnTimerOff.FlatAppearance.BorderSize = 0;
            btnTimerOff.FlatStyle = FlatStyle.Flat;
            btnTimerOff.Image = Properties.Resources.turn_off;
            btnTimerOff.Location = new Point(393, 0);
            btnTimerOff.Margin = new Padding(0);
            btnTimerOff.Name = "btnTimerOff";
            btnTimerOff.Size = new Size(390, 25);
            btnTimerOff.TabIndex = 1;
            btnTimerOff.Tag = "true";
            btnTimerOff.UseVisualStyleBackColor = true;
            btnTimerOff.Click += BtnTimerOff_Click;
            // 
            // btnTimerSettings
            // 
            btnTimerSettings.Anchor = AnchorStyles.None;
            btnTimerSettings.Cursor = Cursors.Hand;
            btnTimerSettings.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnTimerSettings.FlatAppearance.BorderSize = 0;
            btnTimerSettings.FlatStyle = FlatStyle.Flat;
            btnTimerSettings.Image = Properties.Resources.settings;
            btnTimerSettings.Location = new Point(0, 0);
            btnTimerSettings.Margin = new Padding(0);
            btnTimerSettings.Name = "btnTimerSettings";
            btnTimerSettings.Size = new Size(390, 25);
            btnTimerSettings.TabIndex = 0;
            btnTimerSettings.UseVisualStyleBackColor = true;
            btnTimerSettings.Click += BtnTimerSettings_Click;
            // 
            // btnTimerHeader
            // 
            btnTimerHeader.Anchor = AnchorStyles.None;
            btnTimerHeader.FlatAppearance.BorderSize = 0;
            btnTimerHeader.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnTimerHeader.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnTimerHeader.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnTimerHeader.FlatStyle = FlatStyle.Flat;
            btnTimerHeader.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimerHeader.ForeColor = Color.FromArgb(0, 166, 166);
            btnTimerHeader.Location = new Point(0, 0);
            btnTimerHeader.Name = "btnTimerHeader";
            btnTimerHeader.Size = new Size(783, 35);
            btnTimerHeader.TabIndex = 8;
            btnTimerHeader.Text = "Timer";
            btnTimerHeader.UseVisualStyleBackColor = true;
            // 
            // pnlGeneratorBorder
            // 
            pnlGeneratorBorder.Anchor = AnchorStyles.None;
            pnlGeneratorBorder.BackColor = Color.FromArgb(70, 70, 70);
            pnlGeneratorBorder.Controls.Add(pnlNotes);
            pnlGeneratorBorder.Controls.Add(pnlTechnique);
            pnlGeneratorBorder.Controls.Add(pnlMode);
            pnlGeneratorBorder.Controls.Add(pnlGuitarPlayer);
            pnlGeneratorBorder.Location = new Point(5, 299);
            pnlGeneratorBorder.Margin = new Padding(5, 0, 5, 30);
            pnlGeneratorBorder.Name = "pnlGeneratorBorder";
            pnlGeneratorBorder.Size = new Size(786, 120);
            pnlGeneratorBorder.TabIndex = 2;
            // 
            // pnlNotes
            // 
            pnlNotes.Anchor = AnchorStyles.None;
            pnlNotes.BackColor = Color.FromArgb(32, 32, 32);
            pnlNotes.Controls.Add(btnNoteText);
            pnlNotes.Controls.Add(btnNotesOff);
            pnlNotes.Controls.Add(btnNoteHeader);
            pnlNotes.Location = new Point(590, 2);
            pnlNotes.Margin = new Padding(2);
            pnlNotes.Name = "pnlNotes";
            pnlNotes.Size = new Size(194, 116);
            pnlNotes.TabIndex = 2;
            // 
            // btnNoteText
            // 
            btnNoteText.Dock = DockStyle.Fill;
            btnNoteText.FlatAppearance.BorderSize = 0;
            btnNoteText.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnNoteText.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnNoteText.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnNoteText.FlatStyle = FlatStyle.Flat;
            btnNoteText.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnNoteText.ForeColor = Color.White;
            btnNoteText.Location = new Point(0, 30);
            btnNoteText.Name = "btnNoteText";
            btnNoteText.Size = new Size(194, 61);
            btnNoteText.TabIndex = 6;
            btnNoteText.UseVisualStyleBackColor = true;
            // 
            // btnNotesOff
            // 
            btnNotesOff.Cursor = Cursors.Hand;
            btnNotesOff.Dock = DockStyle.Bottom;
            btnNotesOff.FlatAppearance.BorderSize = 0;
            btnNotesOff.FlatStyle = FlatStyle.Flat;
            btnNotesOff.Image = Properties.Resources.turn_off;
            btnNotesOff.Location = new Point(0, 91);
            btnNotesOff.Name = "btnNotesOff";
            btnNotesOff.Size = new Size(194, 25);
            btnNotesOff.TabIndex = 7;
            btnNotesOff.Tag = "true";
            btnNotesOff.UseVisualStyleBackColor = true;
            btnNotesOff.Click += BtnNotesOff_Click;
            // 
            // btnNoteHeader
            // 
            btnNoteHeader.Dock = DockStyle.Top;
            btnNoteHeader.FlatAppearance.BorderSize = 0;
            btnNoteHeader.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnNoteHeader.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnNoteHeader.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnNoteHeader.FlatStyle = FlatStyle.Flat;
            btnNoteHeader.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNoteHeader.ForeColor = Color.FromArgb(0, 166, 166);
            btnNoteHeader.Location = new Point(0, 0);
            btnNoteHeader.Name = "btnNoteHeader";
            btnNoteHeader.Size = new Size(194, 30);
            btnNoteHeader.TabIndex = 6;
            btnNoteHeader.Text = "Notes per beat";
            btnNoteHeader.UseVisualStyleBackColor = true;
            // 
            // pnlTechnique
            // 
            pnlTechnique.Anchor = AnchorStyles.None;
            pnlTechnique.BackColor = Color.FromArgb(32, 32, 32);
            pnlTechnique.Controls.Add(btnTechniqueText);
            pnlTechnique.Controls.Add(btnTechniqueHeader);
            pnlTechnique.Controls.Add(btnTechniqueOff);
            pnlTechnique.Location = new Point(396, 2);
            pnlTechnique.Margin = new Padding(2);
            pnlTechnique.Name = "pnlTechnique";
            pnlTechnique.Size = new Size(190, 116);
            pnlTechnique.TabIndex = 1;
            // 
            // btnTechniqueText
            // 
            btnTechniqueText.Dock = DockStyle.Fill;
            btnTechniqueText.FlatAppearance.BorderSize = 0;
            btnTechniqueText.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnTechniqueText.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnTechniqueText.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnTechniqueText.FlatStyle = FlatStyle.Flat;
            btnTechniqueText.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnTechniqueText.ForeColor = Color.White;
            btnTechniqueText.Location = new Point(0, 30);
            btnTechniqueText.Name = "btnTechniqueText";
            btnTechniqueText.Size = new Size(190, 61);
            btnTechniqueText.TabIndex = 4;
            btnTechniqueText.UseVisualStyleBackColor = true;
            // 
            // btnTechniqueHeader
            // 
            btnTechniqueHeader.Dock = DockStyle.Top;
            btnTechniqueHeader.FlatAppearance.BorderSize = 0;
            btnTechniqueHeader.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnTechniqueHeader.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnTechniqueHeader.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnTechniqueHeader.FlatStyle = FlatStyle.Flat;
            btnTechniqueHeader.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTechniqueHeader.ForeColor = Color.FromArgb(0, 166, 166);
            btnTechniqueHeader.Location = new Point(0, 0);
            btnTechniqueHeader.Name = "btnTechniqueHeader";
            btnTechniqueHeader.Size = new Size(190, 30);
            btnTechniqueHeader.TabIndex = 5;
            btnTechniqueHeader.Text = "Technique";
            btnTechniqueHeader.UseVisualStyleBackColor = true;
            // 
            // btnTechniqueOff
            // 
            btnTechniqueOff.Cursor = Cursors.Hand;
            btnTechniqueOff.Dock = DockStyle.Bottom;
            btnTechniqueOff.FlatAppearance.BorderSize = 0;
            btnTechniqueOff.FlatStyle = FlatStyle.Flat;
            btnTechniqueOff.Image = Properties.Resources.turn_off;
            btnTechniqueOff.Location = new Point(0, 91);
            btnTechniqueOff.Name = "btnTechniqueOff";
            btnTechniqueOff.Size = new Size(190, 25);
            btnTechniqueOff.TabIndex = 4;
            btnTechniqueOff.Tag = "true";
            btnTechniqueOff.UseVisualStyleBackColor = true;
            btnTechniqueOff.Click += BtnTechniqueOff_Click;
            // 
            // pnlMode
            // 
            pnlMode.Anchor = AnchorStyles.None;
            pnlMode.BackColor = Color.FromArgb(32, 32, 32);
            pnlMode.Controls.Add(btnModeText);
            pnlMode.Controls.Add(btnModeHeader);
            pnlMode.Controls.Add(btnModeOff);
            pnlMode.Location = new Point(200, 2);
            pnlMode.Margin = new Padding(2);
            pnlMode.Name = "pnlMode";
            pnlMode.Size = new Size(192, 116);
            pnlMode.TabIndex = 1;
            // 
            // btnModeText
            // 
            btnModeText.Dock = DockStyle.Fill;
            btnModeText.FlatAppearance.BorderSize = 0;
            btnModeText.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnModeText.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnModeText.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnModeText.FlatStyle = FlatStyle.Flat;
            btnModeText.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnModeText.ForeColor = Color.White;
            btnModeText.Location = new Point(0, 30);
            btnModeText.Name = "btnModeText";
            btnModeText.Size = new Size(192, 61);
            btnModeText.TabIndex = 3;
            btnModeText.UseVisualStyleBackColor = true;
            // 
            // btnModeHeader
            // 
            btnModeHeader.Dock = DockStyle.Top;
            btnModeHeader.FlatAppearance.BorderSize = 0;
            btnModeHeader.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnModeHeader.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnModeHeader.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnModeHeader.FlatStyle = FlatStyle.Flat;
            btnModeHeader.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModeHeader.ForeColor = Color.FromArgb(0, 166, 166);
            btnModeHeader.Location = new Point(0, 0);
            btnModeHeader.Name = "btnModeHeader";
            btnModeHeader.Size = new Size(192, 30);
            btnModeHeader.TabIndex = 3;
            btnModeHeader.Text = "Mode";
            btnModeHeader.UseVisualStyleBackColor = true;
            // 
            // btnModeOff
            // 
            btnModeOff.Cursor = Cursors.Hand;
            btnModeOff.Dock = DockStyle.Bottom;
            btnModeOff.FlatAppearance.BorderSize = 0;
            btnModeOff.FlatStyle = FlatStyle.Flat;
            btnModeOff.Image = Properties.Resources.turn_off;
            btnModeOff.Location = new Point(0, 91);
            btnModeOff.Name = "btnModeOff";
            btnModeOff.Size = new Size(192, 25);
            btnModeOff.TabIndex = 2;
            btnModeOff.Tag = "true";
            btnModeOff.UseVisualStyleBackColor = true;
            btnModeOff.Click += BtnModeOff_Click;
            // 
            // pnlGuitarPlayer
            // 
            pnlGuitarPlayer.Anchor = AnchorStyles.None;
            pnlGuitarPlayer.BackColor = Color.FromArgb(32, 32, 32);
            pnlGuitarPlayer.Controls.Add(btnGuitarPlayerText);
            pnlGuitarPlayer.Controls.Add(btnGuitarPlayerHeader);
            pnlGuitarPlayer.Controls.Add(btnGuitarPlayerOff);
            pnlGuitarPlayer.Location = new Point(2, 2);
            pnlGuitarPlayer.Margin = new Padding(2);
            pnlGuitarPlayer.Name = "pnlGuitarPlayer";
            pnlGuitarPlayer.Size = new Size(194, 116);
            pnlGuitarPlayer.TabIndex = 0;
            // 
            // btnGuitarPlayerText
            // 
            btnGuitarPlayerText.Dock = DockStyle.Fill;
            btnGuitarPlayerText.FlatAppearance.BorderSize = 0;
            btnGuitarPlayerText.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnGuitarPlayerText.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnGuitarPlayerText.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnGuitarPlayerText.FlatStyle = FlatStyle.Flat;
            btnGuitarPlayerText.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuitarPlayerText.ForeColor = Color.White;
            btnGuitarPlayerText.Location = new Point(0, 30);
            btnGuitarPlayerText.Name = "btnGuitarPlayerText";
            btnGuitarPlayerText.Size = new Size(194, 61);
            btnGuitarPlayerText.TabIndex = 2;
            btnGuitarPlayerText.UseVisualStyleBackColor = true;
            // 
            // btnGuitarPlayerHeader
            // 
            btnGuitarPlayerHeader.Dock = DockStyle.Top;
            btnGuitarPlayerHeader.FlatAppearance.BorderSize = 0;
            btnGuitarPlayerHeader.FlatAppearance.CheckedBackColor = Color.FromArgb(32, 32, 32);
            btnGuitarPlayerHeader.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 32, 32);
            btnGuitarPlayerHeader.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
            btnGuitarPlayerHeader.FlatStyle = FlatStyle.Flat;
            btnGuitarPlayerHeader.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuitarPlayerHeader.ForeColor = Color.FromArgb(0, 166, 166);
            btnGuitarPlayerHeader.Location = new Point(0, 0);
            btnGuitarPlayerHeader.Name = "btnGuitarPlayerHeader";
            btnGuitarPlayerHeader.Size = new Size(194, 30);
            btnGuitarPlayerHeader.TabIndex = 1;
            btnGuitarPlayerHeader.Text = "Guitar player";
            btnGuitarPlayerHeader.UseVisualStyleBackColor = true;
            // 
            // btnGuitarPlayerOff
            // 
            btnGuitarPlayerOff.Cursor = Cursors.Hand;
            btnGuitarPlayerOff.Dock = DockStyle.Bottom;
            btnGuitarPlayerOff.FlatAppearance.BorderSize = 0;
            btnGuitarPlayerOff.FlatStyle = FlatStyle.Flat;
            btnGuitarPlayerOff.Image = Properties.Resources.turn_off;
            btnGuitarPlayerOff.Location = new Point(0, 91);
            btnGuitarPlayerOff.Name = "btnGuitarPlayerOff";
            btnGuitarPlayerOff.Size = new Size(194, 25);
            btnGuitarPlayerOff.TabIndex = 0;
            btnGuitarPlayerOff.Tag = "true";
            btnGuitarPlayerOff.UseVisualStyleBackColor = true;
            btnGuitarPlayerOff.Click += BtnGuitarPlayerOff_Click;
            // 
            // pnlControls
            // 
            pnlControls.Anchor = AnchorStyles.None;
            pnlControls.Controls.Add(btnSuffle);
            pnlControls.Controls.Add(btnLoop);
            pnlControls.Controls.Add(btnStop);
            pnlControls.Controls.Add(btnPlay);
            pnlControls.Controls.Add(btnPause);
            pnlControls.Controls.Add(btnResume);
            pnlControls.Controls.Add(btnLoad);
            pnlControls.Controls.Add(pnlVolumes);
            pnlControls.Location = new Point(5, 452);
            pnlControls.Margin = new Padding(5, 0, 5, 15);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(786, 60);
            pnlControls.TabIndex = 1;
            // 
            // btnSuffle
            // 
            btnSuffle.BackColor = Color.FromArgb(70, 70, 70);
            btnSuffle.Cursor = Cursors.Hand;
            btnSuffle.Dock = DockStyle.Left;
            btnSuffle.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnSuffle.FlatStyle = FlatStyle.Flat;
            btnSuffle.Image = Properties.Resources.shuffle;
            btnSuffle.Location = new Point(603, 0);
            btnSuffle.Name = "btnSuffle";
            btnSuffle.Size = new Size(105, 60);
            btnSuffle.TabIndex = 7;
            btnSuffle.UseVisualStyleBackColor = false;
            btnSuffle.Click += BtnSuffle_Click;
            // 
            // btnLoop
            // 
            btnLoop.BackColor = Color.FromArgb(70, 70, 70);
            btnLoop.Cursor = Cursors.Hand;
            btnLoop.Dock = DockStyle.Left;
            btnLoop.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnLoop.FlatStyle = FlatStyle.Flat;
            btnLoop.Image = Properties.Resources.loop;
            btnLoop.Location = new Point(498, 0);
            btnLoop.Name = "btnLoop";
            btnLoop.Size = new Size(105, 60);
            btnLoop.TabIndex = 6;
            btnLoop.UseVisualStyleBackColor = false;
            btnLoop.Click += BtnLoop_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(70, 70, 70);
            btnStop.Cursor = Cursors.Hand;
            btnStop.Dock = DockStyle.Left;
            btnStop.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Image = Properties.Resources.stop;
            btnStop.Location = new Point(393, 0);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(105, 60);
            btnStop.TabIndex = 5;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += BtnStop_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(70, 70, 70);
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.Dock = DockStyle.Left;
            btnPlay.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Image = Properties.Resources.play;
            btnPlay.Location = new Point(288, 0);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(105, 60);
            btnPlay.TabIndex = 4;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += BtnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.FromArgb(70, 70, 70);
            btnPause.Cursor = Cursors.Hand;
            btnPause.Dock = DockStyle.Left;
            btnPause.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Image = Properties.Resources.pause;
            btnPause.Location = new Point(183, 0);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(105, 60);
            btnPause.TabIndex = 3;
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += BtnPause_Click;
            // 
            // btnResume
            // 
            btnResume.BackColor = Color.FromArgb(70, 70, 70);
            btnResume.Cursor = Cursors.Hand;
            btnResume.Dock = DockStyle.Left;
            btnResume.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnResume.FlatStyle = FlatStyle.Flat;
            btnResume.Image = Properties.Resources.resume;
            btnResume.Location = new Point(78, 0);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(105, 60);
            btnResume.TabIndex = 2;
            btnResume.UseVisualStyleBackColor = false;
            btnResume.Click += BtnResume_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(70, 70, 70);
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.Dock = DockStyle.Left;
            btnLoad.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Image = Properties.Resources.up_load;
            btnLoad.Location = new Point(0, 0);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(78, 60);
            btnLoad.TabIndex = 1;
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += BtnLoad_Click;
            // 
            // pnlVolumes
            // 
            pnlVolumes.Controls.Add(btnVolumeDown);
            pnlVolumes.Controls.Add(btnVolumeUp);
            pnlVolumes.Dock = DockStyle.Right;
            pnlVolumes.Location = new Point(708, 0);
            pnlVolumes.Margin = new Padding(0);
            pnlVolumes.Name = "pnlVolumes";
            pnlVolumes.Size = new Size(78, 60);
            pnlVolumes.TabIndex = 0;
            // 
            // btnVolumeDown
            // 
            btnVolumeDown.BackColor = Color.FromArgb(70, 70, 70);
            btnVolumeDown.Cursor = Cursors.Hand;
            btnVolumeDown.Dock = DockStyle.Bottom;
            btnVolumeDown.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnVolumeDown.FlatStyle = FlatStyle.Flat;
            btnVolumeDown.Image = Properties.Resources.volume_down;
            btnVolumeDown.Location = new Point(0, 30);
            btnVolumeDown.Name = "btnVolumeDown";
            btnVolumeDown.Size = new Size(78, 30);
            btnVolumeDown.TabIndex = 1;
            btnVolumeDown.UseVisualStyleBackColor = false;
            btnVolumeDown.Click += BtnVolumeDown_Click;
            // 
            // btnVolumeUp
            // 
            btnVolumeUp.BackColor = Color.FromArgb(70, 70, 70);
            btnVolumeUp.Cursor = Cursors.Hand;
            btnVolumeUp.Dock = DockStyle.Top;
            btnVolumeUp.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            btnVolumeUp.FlatStyle = FlatStyle.Flat;
            btnVolumeUp.Image = Properties.Resources.volume_up;
            btnVolumeUp.Location = new Point(0, 0);
            btnVolumeUp.Name = "btnVolumeUp";
            btnVolumeUp.Size = new Size(78, 30);
            btnVolumeUp.TabIndex = 0;
            btnVolumeUp.UseVisualStyleBackColor = false;
            btnVolumeUp.Click += BtnVolumeUp_Click;
            // 
            // txtBackingTrackName
            // 
            txtBackingTrackName.Anchor = AnchorStyles.None;
            txtBackingTrackName.BackColor = Color.FromArgb(229, 229, 229);
            txtBackingTrackName.BorderStyle = BorderStyle.None;
            txtBackingTrackName.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtBackingTrackName.ForeColor = Color.FromArgb(32, 32, 32);
            txtBackingTrackName.Location = new Point(5, 15);
            txtBackingTrackName.Margin = new Padding(5, 15, 5, 0);
            txtBackingTrackName.Name = "txtBackingTrackName";
            txtBackingTrackName.ReadOnly = true;
            txtBackingTrackName.Size = new Size(786, 23);
            txtBackingTrackName.TabIndex = 0;
            txtBackingTrackName.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(816, 547);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHome";
            Tag = "Home";
            Text = "frmHome";
            Load += FrmHome_Load;
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlTimerBorder.ResumeLayout(false);
            pnlTimer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlGeneratorBorder.ResumeLayout(false);
            pnlNotes.ResumeLayout(false);
            pnlTechnique.ResumeLayout(false);
            pnlMode.ResumeLayout(false);
            pnlGuitarPlayer.ResumeLayout(false);
            pnlControls.ResumeLayout(false);
            pnlVolumes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private TextBox txtBackingTrackName;
        private Panel pnlControls;
        private Button btnSuffle;
        private Button btnLoop;
        private Button btnStop;
        private Button btnPlay;
        private Button btnPause;
        private Button btnResume;
        private Button btnLoad;
        private Panel pnlVolumes;
        private Button btnVolumeDown;
        private Button btnVolumeUp;
        private Panel pnlTimerBorder;
        private Panel pnlGeneratorBorder;
        private Panel pnlGuitarPlayer;
        private Panel pnlNotes;
        private Panel pnlTechnique;
        private Panel pnlMode;
        private Panel pnlTimer;
        private Button btnNoteHeader;
        private Button btnTechniqueHeader;
        private Button btnTechniqueOff;
        private Button btnModeHeader;
        private Button btnModeOff;
        private Button btnGuitarPlayerHeader;
        private Button btnGuitarPlayerOff;
        private Button btnTimerHeader;
        private Button btnNotesOff;
        private Panel panel1;
        private Button btnTimerOff;
        private Button btnTimerSettings;
        private Button btnTimerText;
        private Button btnNoteText;
        private Button btnTechniqueText;
        private Button btnModeText;
        private Button btnGuitarPlayerText;
    }
}