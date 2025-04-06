using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
using WindowsForms_Monster_Hunter.Controllers;
using WindowsForms_Monster_Hunter.Models;
namespace WindowsForms_Monster_Hunter.Views
{
    public partial class MonsterHunterWeaponForm : Form
    {
        private WeaponController controller;
        public MonsterHunterWeaponForm(WeaponController wc)
        {
            InitializeComponent();
            controller = wc;
        }

        //This event handler deals with adding a new weapon to your collection.
        //First, it validates the information you entered to ensure nothing is left blank
        //Next, it creates the new weapon object, generates a textual description of it, and adds it to the display on the right side of the window.
        //Before finishing, this event handler also clears the text fields and populates the combo box on the right side of the window with weapon names.
        private void btnAddWeapon_Click(object sender, EventArgs e)
        {
            if (controller.ValidateEntries(txtWeaponName.Text, cbWeaponClass.Text, txtDamageValue.Text, txtMotionValue.Text, cbSharpnessColor.Text, lbRanks.Text))
            {
                controller.AddWeapon(txtWeaponName.Text, cbWeaponClass.Text, int.Parse(txtDamageValue.Text), double.Parse(txtMotionValue.Text), cbSharpnessColor.Text, lbRanks.Text);
                List<string> descriptions = controller.GetTextOfAllWeapons();
                rtbWeaponDisplay.Lines = descriptions.ToArray();
                ClearEntries();
                FillWeaponNamesComboBox();
            }
            else
            {
                MessageBox.Show("You must enter valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This event handler deals with index changes of the weapon names combo box
        //If a name is selected, it will refill the text fields with the selected weapons information
        private void cbWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> details = controller.GetWeaponDetails(cbWeapons.SelectedValue as string);
            if (details != null)
            {
                FillControls(details);
            }
        }

        //This function clears the text fields of all information for QOL
        private void ClearEntries()
        {
            txtWeaponName.Text = string.Empty;
            cbWeaponClass.Text = string.Empty;
            txtDamageValue.Text = string.Empty;
            txtMotionValue.Text = string.Empty;
            cbSharpnessColor.Text = string.Empty;
            lbRanks.ClearSelected();
            pxbWeapon.Image = null;
        }

        //This function handles the refilling of the text fields. This is called when a name is selected in the combo box
        private void FillControls(Dictionary<string, string> details)
        {
            txtWeaponName.Text = details["name"];
            cbWeaponClass.Text = details["weapon class"];
            txtDamageValue.Text = details["damage value"];
            txtMotionValue.Text = details["motion value"];
            cbSharpnessColor.Text = details["sharpness color"];
            if (details["rank"] == "low rank")
            {
                lbRanks.SelectedIndex = 0;
            }
            else if (details["rank"] == "high rank")
            {
                lbRanks.SelectedIndex = 1;
            }
            else
            {
                lbRanks.SelectedIndex = 2;
            }
            ChangeWeaponImage(details);
        }

        //This function populates the combo box with the names of the created weapons
        public void FillWeaponNamesComboBox()
        {
            List<string> names = controller.GetWeaponNames();
            List<string> items = new List<String>();
            items.Add(string.Empty);
            items.AddRange(names);
            cbWeapons.DataSource = items;
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\temp";
            ofd.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (controller.ReadWeapon(ofd.FileName))
                {
                    MessageBox.Show("Weapon data loaded successfully", "Load Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<string> descriptions = controller.GetTextOfAllWeapons();
                    rtbWeaponDisplay.Lines = descriptions.ToArray();
                    FillWeaponNamesComboBox();
                }
                else
                {
                    MessageBox.Show("Weapon data could not be loaded...", "Save Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"c:\temp";
            sfd.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Weapon data was saved successfully!", "Save Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controller.SaveWeapon(sfd.FileName);
            }
            else
            {
                MessageBox.Show("Weapon data could not be saved...", "Save Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This event handler deals with exiting the program.
        private void miExit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnModifyWeapons_Click(object sender, EventArgs e)
        {
            DataGridWeaponsForm dgWpnsFrm = new DataGridWeaponsForm(controller);
            if (dgWpnsFrm.ShowDialog() == DialogResult.OK)
            {
                List<string> descriptions = controller.GetTextOfAllWeapons();
                rtbWeaponDisplay.Lines = descriptions.ToArray();
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void ChangeWeaponImage(Dictionary<string, string> details)
        {
            if (details["weapon class"] == "Great Sword")
            {
                pxbWeapon.Image = Properties.Resources.GS;
            }
            else if (details["weapon class"] == "Hammer")
            {
                pxbWeapon.Image = Properties.Resources.Ham;
            }
            else if (details["weapon class"] == "Hunting Horn")
            {
                pxbWeapon.Image = Properties.Resources.HH;
            }
            else if (details["weapon class"] == "Long Sword")
            {
                pxbWeapon.Image = Properties.Resources.LS;
            }
            else if (details["weapon class"] == "Switch Axe")
            {
                pxbWeapon.Image = Properties.Resources.Swax;
            }
            else if (details["weapon class"] == "Charge Blade")
            {
                pxbWeapon.Image = Properties.Resources.CB;
            }
            else if (details["weapon class"] == "Sword and Shield")
            {
                pxbWeapon.Image = Properties.Resources.SnS;
            }
            else if (details["weapon class"] == "Dual Blades")
            {
                pxbWeapon.Image = Properties.Resources.DB;
            }
            else if (details["weapon class"] == "Bow")
            {
                pxbWeapon.Image = Properties.Resources.Bow;
            }
            else if (details["weapon class"] == "Light Bowgun")
            {
                pxbWeapon.Image = Properties.Resources.LBG;
            }
            else if (details["weapon class"] == "Heavy Bowgun")
            {
                pxbWeapon.Image = Properties.Resources.HBG;
            }
            else if (details["weapon class"] == "Insect Glaive")
            {
                pxbWeapon.Image = Properties.Resources.IG;
            }
            else if (details["weapon class"] == "Gunlance")
            {
                pxbWeapon.Image = Properties.Resources.GL;
            }
            else if (details["weapon class"] == "Lance")
            {
                pxbWeapon.Image = Properties.Resources.Lan;
            }
        }
    }
}