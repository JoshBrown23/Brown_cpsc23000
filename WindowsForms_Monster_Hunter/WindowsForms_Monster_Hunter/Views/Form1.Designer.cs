namespace WindowsForms_Monster_Hunter.Views
{
    partial class MonsterHunterWeaponForm
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
            lblWeaponName = new Label();
            lblWeaponClass = new Label();
            lblDamageValue = new Label();
            lblMotionValue = new Label();
            lblSharpnessColor = new Label();
            txtDamageValue = new TextBox();
            txtMotionValue = new TextBox();
            txtWeaponName = new TextBox();
            PanControls = new Panel();
            lblSelectWeapon = new Label();
            rtbWeaponDisplay = new RichTextBox();
            cbWeapons = new ComboBox();
            lbRanks = new ListBox();
            lblRank = new Label();
            cbSharpnessColor = new ComboBox();
            cbWeaponClass = new ComboBox();
            btnAddWeapon = new Button();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            miOpen = new ToolStripMenuItem();
            miSave = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            miAbout = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            btnModifyWeapons = new Button();
            pxbWeapon = new PictureBox();
            PanControls.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pxbWeapon).BeginInit();
            SuspendLayout();
            // 
            // lblWeaponName
            // 
            lblWeaponName.AutoSize = true;
            lblWeaponName.Location = new Point(47, 54);
            lblWeaponName.Name = "lblWeaponName";
            lblWeaponName.Size = new Size(49, 20);
            lblWeaponName.TabIndex = 0;
            lblWeaponName.Text = "Name";
            // 
            // lblWeaponClass
            // 
            lblWeaponClass.AutoSize = true;
            lblWeaponClass.Location = new Point(47, 88);
            lblWeaponClass.Name = "lblWeaponClass";
            lblWeaponClass.Size = new Size(42, 20);
            lblWeaponClass.TabIndex = 1;
            lblWeaponClass.Text = "Class";
            // 
            // lblDamageValue
            // 
            lblDamageValue.AutoSize = true;
            lblDamageValue.Location = new Point(47, 121);
            lblDamageValue.Name = "lblDamageValue";
            lblDamageValue.Size = new Size(106, 20);
            lblDamageValue.TabIndex = 2;
            lblDamageValue.Text = "Damage Value";
            // 
            // lblMotionValue
            // 
            lblMotionValue.AutoSize = true;
            lblMotionValue.Location = new Point(47, 154);
            lblMotionValue.Name = "lblMotionValue";
            lblMotionValue.Size = new Size(97, 20);
            lblMotionValue.TabIndex = 3;
            lblMotionValue.Text = "Motion Value";
            // 
            // lblSharpnessColor
            // 
            lblSharpnessColor.AutoSize = true;
            lblSharpnessColor.Location = new Point(47, 188);
            lblSharpnessColor.Name = "lblSharpnessColor";
            lblSharpnessColor.Size = new Size(115, 20);
            lblSharpnessColor.TabIndex = 4;
            lblSharpnessColor.Text = "Sharpness Color";
            // 
            // txtDamageValue
            // 
            txtDamageValue.Location = new Point(241, 114);
            txtDamageValue.Name = "txtDamageValue";
            txtDamageValue.Size = new Size(151, 27);
            txtDamageValue.TabIndex = 6;
            // 
            // txtMotionValue
            // 
            txtMotionValue.Location = new Point(241, 147);
            txtMotionValue.Name = "txtMotionValue";
            txtMotionValue.Size = new Size(151, 27);
            txtMotionValue.TabIndex = 7;
            // 
            // txtWeaponName
            // 
            txtWeaponName.Location = new Point(241, 47);
            txtWeaponName.Name = "txtWeaponName";
            txtWeaponName.Size = new Size(151, 27);
            txtWeaponName.TabIndex = 9;
            // 
            // PanControls
            // 
            PanControls.Controls.Add(lblSelectWeapon);
            PanControls.Controls.Add(rtbWeaponDisplay);
            PanControls.Controls.Add(cbWeapons);
            PanControls.Controls.Add(lbRanks);
            PanControls.Controls.Add(lblRank);
            PanControls.Controls.Add(cbSharpnessColor);
            PanControls.Controls.Add(cbWeaponClass);
            PanControls.Controls.Add(txtWeaponName);
            PanControls.Controls.Add(lblWeaponName);
            PanControls.Controls.Add(lblWeaponClass);
            PanControls.Controls.Add(txtMotionValue);
            PanControls.Controls.Add(lblDamageValue);
            PanControls.Controls.Add(txtDamageValue);
            PanControls.Controls.Add(lblMotionValue);
            PanControls.Controls.Add(lblSharpnessColor);
            PanControls.Dock = DockStyle.Fill;
            PanControls.Location = new Point(0, 0);
            PanControls.Name = "PanControls";
            PanControls.Size = new Size(448, 624);
            PanControls.TabIndex = 10;
            // 
            // lblSelectWeapon
            // 
            lblSelectWeapon.AutoSize = true;
            lblSelectWeapon.Location = new Point(47, 292);
            lblSelectWeapon.Name = "lblSelectWeapon";
            lblSelectWeapon.Size = new Size(127, 20);
            lblSelectWeapon.TabIndex = 14;
            lblSelectWeapon.Text = "Select a weapon...";
            // 
            // rtbWeaponDisplay
            // 
            rtbWeaponDisplay.Location = new Point(47, 318);
            rtbWeaponDisplay.Name = "rtbWeaponDisplay";
            rtbWeaponDisplay.ReadOnly = true;
            rtbWeaponDisplay.Size = new Size(345, 303);
            rtbWeaponDisplay.TabIndex = 16;
            rtbWeaponDisplay.Text = "";
            // 
            // cbWeapons
            // 
            cbWeapons.FormattingEnabled = true;
            cbWeapons.Location = new Point(201, 284);
            cbWeapons.Name = "cbWeapons";
            cbWeapons.Size = new Size(191, 28);
            cbWeapons.TabIndex = 15;
            cbWeapons.SelectedIndexChanged += cbWeapons_SelectedIndexChanged;
            // 
            // lbRanks
            // 
            lbRanks.FormattingEnabled = true;
            lbRanks.Items.AddRange(new object[] { "low rank", "high rank", "master rank" });
            lbRanks.Location = new Point(241, 214);
            lbRanks.Name = "lbRanks";
            lbRanks.Size = new Size(151, 64);
            lbRanks.TabIndex = 20;
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Location = new Point(47, 214);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(41, 20);
            lblRank.TabIndex = 19;
            lblRank.Text = "Rank";
            // 
            // cbSharpnessColor
            // 
            cbSharpnessColor.FormattingEnabled = true;
            cbSharpnessColor.Items.AddRange(new object[] { "red", "orange", "yellow", "green", "blue", "white" });
            cbSharpnessColor.Location = new Point(241, 180);
            cbSharpnessColor.Name = "cbSharpnessColor";
            cbSharpnessColor.Size = new Size(151, 28);
            cbSharpnessColor.TabIndex = 15;
            // 
            // cbWeaponClass
            // 
            cbWeaponClass.AllowDrop = true;
            cbWeaponClass.FormattingEnabled = true;
            cbWeaponClass.Items.AddRange(new object[] { "Great Sword", "Long Sword", "Sword and Shield", "Dual Blades", "Hunting Horn", "Hammer", "Lance", "Gunlance", "Insect Glaive", "Switch Axe", "Charge Blade", "Light Bowgun", "Heavy Bowgun", "Bow" });
            cbWeaponClass.Location = new Point(241, 80);
            cbWeaponClass.Name = "cbWeaponClass";
            cbWeaponClass.Size = new Size(151, 28);
            cbWeaponClass.TabIndex = 15;
            // 
            // btnAddWeapon
            // 
            btnAddWeapon.Location = new Point(47, 23);
            btnAddWeapon.Name = "btnAddWeapon";
            btnAddWeapon.Size = new Size(130, 29);
            btnAddWeapon.TabIndex = 10;
            btnAddWeapon.Text = "Add Weapon";
            btnAddWeapon.UseVisualStyleBackColor = true;
            btnAddWeapon.Click += btnAddWeapon_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1016, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { miOpen, miSave, miExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // miOpen
            // 
            miOpen.Name = "miOpen";
            miOpen.ShortcutKeys = Keys.Control | Keys.O;
            miOpen.Size = new Size(181, 26);
            miOpen.Text = "Open";
            miOpen.Click += miOpen_Click;
            // 
            // miSave
            // 
            miSave.Name = "miSave";
            miSave.ShortcutKeys = Keys.Control | Keys.S;
            miSave.Size = new Size(181, 26);
            miSave.Text = "Save";
            miSave.Click += miSave_Click;
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.ShortcutKeys = Keys.Control | Keys.X;
            miExit.Size = new Size(181, 26);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { miAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(55, 24);
            mnuHelp.Text = "Help";
            // 
            // miAbout
            // 
            miAbout.Name = "miAbout";
            miAbout.ShortcutKeys = Keys.Control | Keys.I;
            miAbout.Size = new Size(179, 26);
            miAbout.Text = "About";
            miAbout.Click += miAbout_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pxbWeapon);
            splitContainer1.Size = new Size(1016, 692);
            splitContainer1.SplitterDistance = 448;
            splitContainer1.TabIndex = 16;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(PanControls);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnModifyWeapons);
            splitContainer2.Panel2.Controls.Add(btnAddWeapon);
            splitContainer2.Size = new Size(448, 692);
            splitContainer2.SplitterDistance = 624;
            splitContainer2.TabIndex = 11;
            // 
            // btnModifyWeapons
            // 
            btnModifyWeapons.Location = new Point(262, 23);
            btnModifyWeapons.Name = "btnModifyWeapons";
            btnModifyWeapons.Size = new Size(130, 29);
            btnModifyWeapons.TabIndex = 11;
            btnModifyWeapons.Text = "Modify Weapons";
            btnModifyWeapons.UseVisualStyleBackColor = true;
            btnModifyWeapons.Click += btnModifyWeapons_Click;
            // 
            // pxbWeapon
            // 
            pxbWeapon.Dock = DockStyle.Fill;
            pxbWeapon.Location = new Point(0, 0);
            pxbWeapon.Name = "pxbWeapon";
            pxbWeapon.Size = new Size(564, 692);
            pxbWeapon.SizeMode = PictureBoxSizeMode.CenterImage;
            pxbWeapon.TabIndex = 0;
            pxbWeapon.TabStop = false;
            // 
            // MonsterHunterWeaponForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 692);
            Controls.Add(menuStrip1);
            Controls.Add(splitContainer1);
            MainMenuStrip = menuStrip1;
            Name = "MonsterHunterWeaponForm";
            Text = "Monster Hunter Weapon";
            PanControls.ResumeLayout(false);
            PanControls.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pxbWeapon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWeaponName;
        private Label lblWeaponClass;
        private Label lblDamageValue;
        private Label lblMotionValue;
        private Label lblSharpnessColor;
        private TextBox txtDamageValue;
        private TextBox txtMotionValue;
        private TextBox txtWeaponName;
        private Panel PanControls;
        private Button btnAddWeapon;
        private ComboBox cbSharpnessColor;
        private ComboBox cbWeaponClass;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem miOpen;
        private ToolStripMenuItem miSave;
        private ToolStripMenuItem miExit;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem miAbout;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        public RichTextBox rtbWeaponDisplay;
        private Label lblSelectWeapon;
        private ComboBox cbWeapons;
        private Label lblRank;
        private ListBox lbRanks;
        private Button btnModifyWeapons;
        private PictureBox pxbWeapon;
    }
}
