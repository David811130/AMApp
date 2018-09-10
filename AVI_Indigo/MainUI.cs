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
    public partial class MainUI : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DAVIDBRITS\SQLEXPRESS;Initial Catalog=Indigo;Integrated Security=True ");
        SqlCommand cmd;
        SqlCommand cmdtwo;
        SqlDataAdapter adapt;
        DataTable dt;

        public MainUI()
        {
            InitializeComponent();
        }

 

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var AdminFrm = new Admin();
            AdminFrm.Show();
            this.Hide();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            var LoginFrm = new Login();
            LoginFrm.Show();
            this.Close();
        }

        private void btnAssetView_Click(object sender, EventArgs e)
        {
            var AssetViewFrm = new ViewAssets();
            AssetViewFrm.Show();
            this.Hide();
        }

        private void btnTransferAsset_Click(object sender, EventArgs e)
        {
            if (tbMoveTo.Text != "")
            {
                cmd = new SqlCommand("UPDATE Assets SET LocationCurrent=@current WHERE AssetNum='"+ tbAssetNumber.Text +"'", sqlcon);
                cmdtwo = new SqlCommand("UPDATE Assets SET LocationOld=@old WHERE AssetNum='" + tbAssetNumber.Text + "'", sqlcon);
                sqlcon.Open();             
                cmd.Parameters.AddWithValue("@current", tbMoveTo.Text);
                cmdtwo.Parameters.AddWithValue("@old", tbCurrentLocation.Text);
                cmd.ExecuteNonQuery();
                cmdtwo.ExecuteNonQuery();
                MessageBox.Show("The asset has been moved to "+ tbMoveTo.Text);
                sqlcon.Close();
                //DisplayData();
                tbMoveTo.Text = "";
            }
            else
            {
                MessageBox.Show("Asset did not move");
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            //Code Comment Below is to AutoFill Combobox with Warehouse names in now obsolete Warehouse DataTable
           /* sqlcon.Open();
            
            adapt = new SqlDataAdapter("SELECT Name FROM Warehouses ORDER BY Name desc", sqlcon);
            //DataTable dt;
            //dt = new DataTable();
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();
            adapt.Fill(dt);
            sqlcon.Close();

            cbAssetTo.Items.Clear();
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name FROM Warehouses order by Name asc";
            cmd.ExecuteNonQuery();
            
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            foreach (DataRow dr in dt.Rows)


            {
                cbAssetTo.Items.Add(dr["Name"].ToString());

            }
            sqlcon.Close();*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string SearchQuery = "SELECT Assetnum,LocationCurrent FROM Assets WHERE Assetnum = '" + tbAssetNumber.Text + "'";
                SqlCommand cmd = new SqlCommand(SearchQuery, sqlcon);

                SqlDataReader sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    string currentLocation = (string)sqlReader["LocationCurrent"];

                    tbCurrentLocation.Text = currentLocation.ToString();
             
                }

                sqlReader.Close();
                cmd.Dispose();
                sqlcon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbMoveTo.Focus();
        }

        private void cbAssetTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
