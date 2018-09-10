using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AVI_Indigo
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            var LoginFrm = new Login();
            LoginFrm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var mainUIFrm = new MainUI();
            mainUIFrm.Show();
            this.Hide();
        }

        private void btnUserAdmin_Click(object sender, EventArgs e)
        {
            var UserAdminFrm = new UserAdmin();
            UserAdminFrm.Show();
            this.Hide();
        }

        private void btnAssetAdmin_Click(object sender, EventArgs e)
        {
            var AssetAdminFrm = new AssetAdmin();
            AssetAdminFrm.Show();
            this.Hide();

        }

      

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
