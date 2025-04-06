using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using WindowsForms_Monster_Hunter.Models;
using WindowsForms_Monster_Hunter.Properties;

namespace WindowsForms_Monster_Hunter.Views
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            rtbAbout.Rtf = Properties.Resources.AboutLabel;
            pxbAbout.Image = Properties.Resources.MonHunt;
        }

        private void btnAboutOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
