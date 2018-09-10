using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AVI_Indigo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Admin" && tbPW.Text == "Admin")
            {
                MessageBox.Show("Admin User Logged In!");
                var MainUI = new MainUI();
                MainUI.Show();
                this.Hide();

            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DAVIDBRITS\SQLEXPRESS;Initial Catalog=Indigo;Integrated Security=True ");
                string query = "Select * from Authentication1 Where Username = '" + tbUserName.Text.Trim() + "' and Password = '" + tbPW.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    var mainUI = new MainUI();
                    mainUI.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid username and password");
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
