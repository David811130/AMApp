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
    public partial class AssetAdmin : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DAVIDBRITS\SQLEXPRESS;Initial Catalog=Indigo;Integrated Security=True ");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //cellID variable used in updating and deleting records
        int cellID = 0;

        public AssetAdmin()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView
        private void DisplayData()
        {
            sqlcon.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Assets", sqlcon);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }

        //Clear Data
        private void ClearData()
        {
            tbAssetNumber.Text = "";
            tbMake.Text = "";
            tbModel.Text = "";
            tbSN.Text = "";
            cellID = 0;
        }
        private void AssetAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'indigoDataSet.Assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.indigoDataSet.Assets);

        }

        private void btnCreateAsset_Click(object sender, EventArgs e)
        {
            if (tbAssetNumber.Text != "" && tbMake.Text != "" && tbModel.Text != "" && tbSN.Text != "")
            {
                cmd = new SqlCommand("insert into Assets(AssetNum,Manufacturer,Model,SerialNum,LocationCurrent) values(@AssetNum,@Manufacturer,@Model,@SerialNum,@LocationCurrent)", sqlcon);
                sqlcon.Open();
                cmd.Parameters.AddWithValue("AssetNum", tbAssetNumber.Text);
                cmd.Parameters.AddWithValue("Manufacturer",tbMake.Text);
                cmd.Parameters.AddWithValue("Model", tbModel.Text);
                cmd.Parameters.AddWithValue("SerialNum", tbSN.Text);
                cmd.Parameters.AddWithValue("LocationCurrent", "Main");
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("You have succesfully added a new Asset");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please confirm that you have completed all fields");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbAssetNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbMake.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbModel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbSN.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            var MainUIFrm = new MainUI();
            MainUIFrm.Show();
            this.Hide();
        }

        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            if (cellID != 0)
            {
                cmd = new SqlCommand("delete Assets where ID=@id", sqlcon);
                sqlcon.Open();
                cmd.Parameters.AddWithValue("@id", cellID);
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Asset Succesfully Deleted");
                DisplayData();
                ClearData();
                this.Update();

            }
            else
            {
                MessageBox.Show("Double Click on an Asset in the above box before clicking the Delete Asset button");
            }
        }
    }
}
