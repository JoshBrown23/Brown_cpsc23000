namespace SimpleDrawingApp
{
    partial class DrawingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panDrawing = new Panel();
            panel1 = new Panel();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panDrawing);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 379;
            splitContainer1.TabIndex = 0;
            // 
            // panDrawing
            // 
            panDrawing.BackColor = SystemColors.ControlLightLight;
            panDrawing.Dock = DockStyle.Fill;
            panDrawing.Location = new Point(0, 0);
            panDrawing.Name = "panDrawing";
            panDrawing.Size = new Size(800, 379);
            panDrawing.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonShadow;
            btnClear.Dock = DockStyle.Fill;
            btnClear.ForeColor = SystemColors.Desktop;
            btnClear.Location = new Point(0, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(800, 67);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // DrawingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "DrawingForm";
            Text = "Drawing Form";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        public Panel panDrawing;
        private Button btnClear;
        private Panel panel1;
    }
}
