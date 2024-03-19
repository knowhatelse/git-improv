namespace GitImprov.UI
{
    partial class FrmDialog
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
            lblText = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            pnlContent = new Panel();
            btnClose = new Button();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblText.ForeColor = Color.FromArgb(229, 229, 229);
            lblText.Location = new Point(14, 24);
            lblText.Margin = new Padding(5, 15, 5, 5);
            lblText.Name = "lblText";
            lblText.Size = new Size(133, 18);
            lblText.TabIndex = 1;
            lblText.Text = "Enter X name:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BackColor = Color.FromArgb(237, 237, 237);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(23, 23, 23);
            txtName.Location = new Point(14, 67);
            txtName.Margin = new Padding(5, 20, 5, 10);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(356, 26);
            txtName.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(237, 237, 237);
            btnAdd.Location = new Point(300, 112);
            btnAdd.Margin = new Padding(5, 0, 5, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 25);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(btnClose);
            pnlContent.Controls.Add(lblText);
            pnlContent.Controls.Add(btnAdd);
            pnlContent.Controls.Add(txtName);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Margin = new Padding(0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(384, 161);
            pnlContent.TabIndex = 10;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.FromArgb(68, 68, 68);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(237, 237, 237);
            btnClose.Location = new Point(220, 112);
            btnClose.Margin = new Padding(5, 0, 5, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 25);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // frmDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(384, 161);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new";
            Load += FrmAddNew_Load;
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblText;
        private TextBox txtName;
        private Button btnAdd;
        private Panel pnlContent;
        private Button btnClose;
    }
}