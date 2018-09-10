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
    public partial class UserAdmin : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DAVIDBRITS\SQLEXPRESS;Initial Catalog=Indigo;Integrated Security=True ");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //cellID variable used in updating and deleting records
        int cellID = 0;
       
        public UserAdmin()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView
        private void DisplayData()
        {
            sqlcon.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Authentication1", sqlcon);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }

        //Clear Data
        private void ClearData()
        {
            tbUserNameCreate.Text = "";
            tbPWCreate.Text = "";
            tbPWCreateRe.Text = "";
            cellID = 0;
        }

        private void UserAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'authenticationDataSet.Authentication1' table. You can move, or remove it, as needed.
            this.authentication1TableAdapter.Fill(this.authenticationDataSet.Authentication1);

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (tbPWCreate.Text == tbPWCreateRe.Text && tbPWCreate.Text != "")
            {
                cmd = new SqlCommand("insert into Authentication1(Username,Password) values(@Username,@Password)", sqlcon);
                sqlcon.Open();
                cmd.Parameters.AddWithValue("Username", tbUserNameCreate.Text);
                cmd.Parameters.AddWithValue("Password", tbPWCreate.Text);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("You have succesfully added a new user");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please confirm that the password field isn't blank and that both password fields match");
            }
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            var MainMenuFrm = new MainUI();
            MainMenuFrm.Show();
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            cellID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbUserNameCreate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (cellID != 0)
            {
                cmd = new SqlCommand("delete Authentication1 where ID=@id", sqlcon);
                sqlcon.Open();
                cmd.Parameters.AddWithValue("@id", cellID);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("User Succesfully Deleted");
                DisplayData();
                ClearData();
                this.Update();

            }
            else
            {
                MessageBox.Show("Double Click on a Username in the above box before clicking the Delete User button");
            }
        }
    }
}
