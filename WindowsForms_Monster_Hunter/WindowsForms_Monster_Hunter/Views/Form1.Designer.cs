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
            cbSharpnessColor = new ComboBox();
            cbWeaponClass = new ComboBox();
            btnAddWeapon = new Button();
            lblSelectWeapon = new Label();
            cbWeapons = new ComboBox();
            rtbWeaponDisplay = new RichTextBox();
            btnExit = new Button();
            PanControls.SuspendLayout();
            SuspendLayout();
            // 
            // lblWeaponName
            // 
            lblWeaponName.AutoSize = true;
            lblWeaponName.Location = new Point(71, 55);
            lblWeaponName.Name = "lblWeaponName";
            lblWeaponName.Size = new Size(49, 20);
            lblWeaponName.TabIndex = 0;
            lblWeaponName.Text = "Name";
            // 
            // lblWeaponClass
            // 
            lblWeaponClass.AutoSize = true;
            lblWeaponClass.Location = new Point(71, 120);
            lblWeaponClass.Name = "lblWeaponClass";
            lblWeaponClass.Size = new Size(42, 20);
            lblWeaponClass.TabIndex = 1;
            lblWeaponClass.Text = "Class";
            // 
            // lblDamageValue
            // 
            lblDamageValue.AutoSize = true;
            lblDamageValue.Location = new Point(71, 189);
            lblDamageValue.Name = "lblDamageValue";
            lblDamageValue.Size = new Size(106, 20);
            lblDamageValue.TabIndex = 2;
            lblDamageValue.Text = "Damage Value";
            // 
            // lblMotionValue
            // 
            lblMotionValue.AutoSize = true;
            lblMotionValue.Location = new Point(71, 253);
            lblMotionValue.Name = "lblMotionValue";
            lblMotionValue.Size = new Size(97, 20);
            lblMotionValue.TabIndex = 3;
            lblMotionValue.Text = "Motion Value";
            // 
            // lblSharpnessColor
            // 
            lblSharpnessColor.AutoSize = true;
            lblSharpnessColor.Location = new Point(71, 317);
            lblSharpnessColor.Name = "lblSharpnessColor";
            lblSharpnessColor.Size = new Size(115, 20);
            lblSharpnessColor.TabIndex = 4;
            lblSharpnessColor.Text = "Sharpness Color";
            // 
            // txtDamageValue
            // 
            txtDamageValue.Location = new Point(213, 182);
            txtDamageValue.Name = "txtDamageValue";
            txtDamageValue.Size = new Size(151, 27);
            txtDamageValue.TabIndex = 6;
            // 
            // txtMotionValue
            // 
            txtMotionValue.Location = new Point(213, 246);
            txtMotionValue.Name = "txtMotionValue";
            txtMotionValue.Size = new Size(151, 27);
            txtMotionValue.TabIndex = 7;
            // 
            // txtWeaponName
            // 
            txtWeaponName.Location = new Point(213, 48);
            txtWeaponName.Name = "txtWeaponName";
            txtWeaponName.Size = new Size(151, 27);
            txtWeaponName.TabIndex = 9;
            // 
            // PanControls
            // 
            PanControls.Controls.Add(cbSharpnessColor);
            PanControls.Controls.Add(cbWeaponClass);
            PanControls.Controls.Add(btnAddWeapon);
            PanControls.Controls.Add(txtWeaponName);
            PanControls.Controls.Add(lblWeaponName);
            PanControls.Controls.Add(lblWeaponClass);
            PanControls.Controls.Add(txtMotionValue);
            PanControls.Controls.Add(lblDamageValue);
            PanControls.Controls.Add(txtDamageValue);
            PanControls.Controls.Add(lblMotionValue);
            PanControls.Controls.Add(lblSharpnessColor);
            PanControls.Location = new Point(12, 12);
            PanControls.Name = "PanControls";
            PanControls.Size = new Size(460, 426);
            PanControls.TabIndex = 10;
            // 
            // cbSharpnessColor
            // 
            cbSharpnessColor.FormattingEnabled = true;
            cbSharpnessColor.Items.AddRange(new object[] { "red", "orange", "yellow", "green", "blue", "white" });
            cbSharpnessColor.Location = new Point(213, 309);
            cbSharpnessColor.Name = "cbSharpnessColor";
            cbSharpnessColor.Size = new Size(151, 28);
            cbSharpnessColor.TabIndex = 15;
            // 
            // cbWeaponClass
            // 
            cbWeaponClass.AllowDrop = true;
            cbWeaponClass.FormattingEnabled = true;
            cbWeaponClass.Items.AddRange(new object[] { "Great Sword", "Long Sword", "Sword and Shield", "Dual Blades", "Hunting Horn", "Hammer", "Lance", "Gunlance", "Insect Glaive", "Switch Axe", "Charge Blade", "Light Bowgun", "Heavy Bowgun", "Bow" });
            cbWeaponClass.Location = new Point(213, 112);
            cbWeaponClass.Name = "cbWeaponClass";
            cbWeaponClass.Size = new Size(151, 28);
            cbWeaponClass.TabIndex = 15;
            // 
            // btnAddWeapon
            // 
            btnAddWeapon.Location = new Point(156, 378);
            btnAddWeapon.Name = "btnAddWeapon";
            btnAddWeapon.Size = new Size(130, 29);
            btnAddWeapon.TabIndex = 10;
            btnAddWeapon.Text = "Add Weapon";
            btnAddWeapon.UseVisualStyleBackColor = true;
            btnAddWeapon.Click += btnAddWeapon_Click;
            // 
            // lblSelectWeapon
            // 
            lblSelectWeapon.AutoSize = true;
            lblSelectWeapon.Location = new Point(534, 29);
            lblSelectWeapon.Name = "lblSelectWeapon";
            lblSelectWeapon.Size = new Size(127, 20);
            lblSelectWeapon.TabIndex = 11;
            lblSelectWeapon.Text = "Select a weapon...";
            // 
            // cbWeapons
            // 
            cbWeapons.FormattingEnabled = true;
            cbWeapons.Location = new Point(745, 21);
            cbWeapons.Name = "cbWeapons";
            cbWeapons.Size = new Size(191, 28);
            cbWeapons.TabIndex = 12;
            cbWeapons.SelectedIndexChanged += cbWeapons_SelectedIndexChanged;
            // 
            // rtbWeaponDisplay
            // 
            rtbWeaponDisplay.Location = new Point(534, 65);
            rtbWeaponDisplay.Name = "rtbWeaponDisplay";
            rtbWeaponDisplay.Size = new Size(402, 315);
            rtbWeaponDisplay.TabIndex = 13;
            rtbWeaponDisplay.Text = "";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(672, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MonsterHunterWeaponForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 450);
            Controls.Add(btnExit);
            Controls.Add(rtbWeaponDisplay);
            Controls.Add(cbWeapons);
            Controls.Add(lblSelectWeapon);
            Controls.Add(PanControls);
            Name = "MonsterHunterWeaponForm";
            Text = "Monster Hunter Weapon";
            PanControls.ResumeLayout(false);
            PanControls.PerformLayout();
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
        private Label lblSelectWeapon;
        private ComboBox cbWeapons;
        private RichTextBox rtbWeaponDisplay;
        private Button btnExit;
        private ComboBox cbSharpnessColor;
        private ComboBox cbWeaponClass;
    }
}
