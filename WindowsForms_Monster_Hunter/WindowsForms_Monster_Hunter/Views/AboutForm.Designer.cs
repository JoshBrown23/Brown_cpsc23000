namespace WindowsForms_Monster_Hunter.Views
{
    partial class AboutForm
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
            panAbout = new Panel();
            pxbAbout = new PictureBox();
            btnAboutOk = new Button();
            rtbAbout = new RichTextBox();
            panAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pxbAbout).BeginInit();
            SuspendLayout();
            // 
            // panAbout
            // 
            panAbout.Controls.Add(pxbAbout);
            panAbout.Controls.Add(btnAboutOk);
            panAbout.Controls.Add(rtbAbout);
            panAbout.Dock = DockStyle.Fill;
            panAbout.Location = new Point(0, 0);
            panAbout.Name = "panAbout";
            panAbout.Size = new Size(800, 450);
            panAbout.TabIndex = 0;
            // 
            // pxbAbout
            // 
            pxbAbout.Location = new Point(12, 12);
            pxbAbout.Name = "pxbAbout";
            pxbAbout.Size = new Size(368, 352);
            pxbAbout.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbAbout.TabIndex = 2;
            pxbAbout.TabStop = false;
            // 
            // btnAboutOk
            // 
            btnAboutOk.Location = new Point(349, 393);
            btnAboutOk.Name = "btnAboutOk";
            btnAboutOk.Size = new Size(94, 29);
            btnAboutOk.TabIndex = 1;
            btnAboutOk.Text = "Ok";
            btnAboutOk.UseVisualStyleBackColor = true;
            btnAboutOk.Click += btnAboutOk_Click;
            // 
            // rtbAbout
            // 
            rtbAbout.Location = new Point(411, 12);
            rtbAbout.Name = "rtbAbout";
            rtbAbout.ReadOnly = true;
            rtbAbout.Size = new Size(377, 352);
            rtbAbout.TabIndex = 0;
            rtbAbout.Text = "";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panAbout);
            Name = "AboutForm";
            Text = "AboutForm";
            Load += AboutForm_Load;
            panAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pxbAbout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panAbout;
        private RichTextBox rtbAbout;
        private PictureBox pxbAbout;
        private Button btnAboutOk;
    }
}