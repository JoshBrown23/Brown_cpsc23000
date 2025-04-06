namespace WindowsForms_Monster_Hunter.Views
{
    partial class DataGridWeaponsForm
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            dgWeapons = new DataGridView();
            cmnuUpdate = new ContextMenuStrip(components);
            updateDamageToolStripMenuItem = new ToolStripMenuItem();
            updateSharpnessToolStripMenuItem = new ToolStripMenuItem();
            btnDiscardChanges = new Button();
            btnSaveChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgWeapons).BeginInit();
            cmnuUpdate.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnDiscardChanges);
            splitContainer1.Panel2.Controls.Add(btnSaveChanges);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 387;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgWeapons);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 387);
            panel1.TabIndex = 0;
            // 
            // dgWeapons
            // 
            dgWeapons.AllowUserToAddRows = false;
            dgWeapons.AllowUserToDeleteRows = false;
            dgWeapons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgWeapons.ContextMenuStrip = cmnuUpdate;
            dgWeapons.Dock = DockStyle.Fill;
            dgWeapons.Location = new Point(0, 0);
            dgWeapons.Name = "dgWeapons";
            dgWeapons.RowHeadersWidth = 51;
            dgWeapons.Size = new Size(800, 387);
            dgWeapons.TabIndex = 19;
            dgWeapons.ColumnHeaderMouseClick += dgWeapons_ColumnHeaderMouseClick;
            // 
            // cmnuUpdate
            // 
            cmnuUpdate.ImageScalingSize = new Size(20, 20);
            cmnuUpdate.Items.AddRange(new ToolStripItem[] { updateDamageToolStripMenuItem, updateSharpnessToolStripMenuItem });
            cmnuUpdate.Name = "cmnuUpdate";
            cmnuUpdate.Size = new Size(198, 52);
            cmnuUpdate.Text = "Update Weapon Values";
            // 
            // updateDamageToolStripMenuItem
            // 
            updateDamageToolStripMenuItem.Name = "updateDamageToolStripMenuItem";
            updateDamageToolStripMenuItem.Size = new Size(197, 24);
            updateDamageToolStripMenuItem.Text = "Update Damage";
            updateDamageToolStripMenuItem.Click += updateDamageToolStripMenuItem_Click;
            // 
            // updateSharpnessToolStripMenuItem
            // 
            updateSharpnessToolStripMenuItem.Name = "updateSharpnessToolStripMenuItem";
            updateSharpnessToolStripMenuItem.Size = new Size(197, 24);
            updateSharpnessToolStripMenuItem.Text = "Update Sharpness";
            updateSharpnessToolStripMenuItem.Click += updateSharpnessToolStripMenuItem_Click;
            // 
            // btnDiscardChanges
            // 
            btnDiscardChanges.Location = new Point(406, 18);
            btnDiscardChanges.Name = "btnDiscardChanges";
            btnDiscardChanges.Size = new Size(128, 29);
            btnDiscardChanges.TabIndex = 1;
            btnDiscardChanges.Text = "Discard Changes";
            btnDiscardChanges.UseVisualStyleBackColor = true;
            btnDiscardChanges.Click += btnDiscardChanges_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(282, 18);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(118, 29);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // DataGridWeaponsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "DataGridWeaponsForm";
            Text = "Edit Weapons";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgWeapons).EndInit();
            cmnuUpdate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        public DataGridView dgWeapons;
        private Button btnSaveChanges;
        private Button btnDiscardChanges;
        private ContextMenuStrip cmnuUpdate;
        private ToolStripMenuItem updateDamageToolStripMenuItem;
        private ToolStripMenuItem updateSharpnessToolStripMenuItem;
    }
}