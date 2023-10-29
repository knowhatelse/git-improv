namespace GitImprov.UI
{
    partial class frmInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo));
            pnlContentHolder = new Panel();
            pnlBorder = new Panel();
            txtAbout = new TextBox();
            pnlContentHolder.SuspendLayout();
            pnlBorder.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContentHolder
            // 
            pnlContentHolder.Controls.Add(pnlBorder);
            pnlContentHolder.Location = new Point(10, 10);
            pnlContentHolder.Name = "pnlContentHolder";
            pnlContentHolder.Size = new Size(796, 527);
            pnlContentHolder.TabIndex = 0;
            // 
            // pnlBorder
            // 
            pnlBorder.BackColor = Color.FromArgb(70, 70, 70);
            pnlBorder.Controls.Add(txtAbout);
            pnlBorder.Location = new Point(5, 68);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(786, 351);
            pnlBorder.TabIndex = 0;
            // 
            // txtAbout
            // 
            txtAbout.BackColor = Color.FromArgb(32, 32, 32);
            txtAbout.BorderStyle = BorderStyle.None;
            txtAbout.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAbout.ForeColor = Color.White;
            txtAbout.Location = new Point(1, 1);
            txtAbout.Margin = new Padding(1);
            txtAbout.Multiline = true;
            txtAbout.Name = "txtAbout";
            txtAbout.ReadOnly = true;
            txtAbout.ScrollBars = ScrollBars.Both;
            txtAbout.Size = new Size(784, 349);
            txtAbout.TabIndex = 0;
            txtAbout.Text = resources.GetString("txtAbout.Text");
            // 
            // frmInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(816, 547);
            Controls.Add(pnlContentHolder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInfo";
            Text = "frmInfo";
            pnlContentHolder.ResumeLayout(false);
            pnlBorder.ResumeLayout(false);
            pnlBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContentHolder;
        private Panel pnlBorder;
        private TextBox txtAbout;
    }
}