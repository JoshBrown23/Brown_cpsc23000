using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_Monster_Hunter.Models;
using WindowsForms_Monster_Hunter.Controllers;
using WindowsForms_Monster_Hunter.Views;

namespace WindowsForms_Monster_Hunter.Views
{
    public partial class DataGridWeaponsForm : Form
    {
        private WeaponController controller;
        private List<MonsterHunterWeapon> dgWeaponsList;
        public DataGridWeaponsForm(WeaponController wc)
        {
            InitializeComponent();
            controller = wc;
            dgWeaponsList = controller.GetWeapons();
            dgWeapons.DataSource = dgWeaponsList;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            List<MonsterHunterWeapon> existingWeapons = controller.GetWeapons();
            controller.UpdateRTBWeapons(existingWeapons);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void updateDamageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<MonsterHunterWeapon> updatedDamage = controller.UpdateWeaponDamage(dgWeaponsList);
            dgWeapons.DataSource = updatedDamage;
            dgWeapons.Refresh();
        }

        private void updateSharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<MonsterHunterWeapon> updatedSharpness = controller.UpdateWeaponSharpness(dgWeaponsList);
            dgWeapons.DataSource = updatedSharpness;
            dgWeapons.Refresh();
        }

        private void dgWeapons_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string colName = dgWeapons.Columns[e.ColumnIndex].DataPropertyName;
            if (colName == "Name")
            {
                //repopulate with the list sorted by Name
                dgWeapons.DataSource = controller.GetWeapons("Name");
            }
            else if (colName == "DamageValue")
            {
                //repopulate with the list sorted by DamageValue
                dgWeapons.DataSource = controller.GetWeapons("DamageValue");
            }
        }
    }
}
