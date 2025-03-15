using System.Data;
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

        //This event handler deals with exiting the program. You might need to try it a few times hahaha.
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                DialogResult = MessageBox.Show("Are you really sure you want to exit?", "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    DialogResult = MessageBox.Show("Are you really really sure you want to exit?", "Confirmation??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult == DialogResult.Yes)
                    {
                        DialogResult = MessageBox.Show("Are you really really really sure you want to exit?", "Confirmation???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult == DialogResult.Yes)
                        {
                            MessageBox.Show("Fine, you don't have to be mean about it...", ":(", MessageBoxButtons.OK, MessageBoxIcon.None);
                            Application.Exit();
                        }
                    }
                }
            }
        }

        //This event handler deals with adding a new weapon to your collection.
        //First, it validates the information you entered to ensure nothing is left blank
        //Next, it creates the new weapon object, generates a textual description of it, and adds it to the display on the right side of the window.
        //Before finishing, this event handler also clears the text fields and populates the combo box on the right side of the window with weapon names.
        private void btnAddWeapon_Click(object sender, EventArgs e)
        {
            if (controller.ValidateEntries(txtWeaponName.Text, cbWeaponClass.Text, txtDamageValue.Text, txtMotionValue.Text, cbSharpnessColor.Text))
            {
                controller.AddWeapon(txtWeaponName.Text, cbWeaponClass.Text, int.Parse(txtDamageValue.Text), double.Parse(txtMotionValue.Text), cbSharpnessColor.Text);
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
        }

        //This function handles the refilling of the text fields. This is called when a name is selected in the combo box
        private void FillControls(Dictionary<string, string> details)
        {
            txtWeaponName.Text = details["name"];
            cbWeaponClass.Text = details["weapon class"];
            txtDamageValue.Text = details["damage value"];
            txtMotionValue.Text = details["motion value"];
            cbSharpnessColor.Text = details["sharpness color"];
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
    }
}
