using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace AVI_Indigo
{
    public partial class ViewAssets : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DAVIDBRITS\SQLEXPRESS;Initial Catalog=Indigo;Integrated Security=True ");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt = new DataTable();
        //cellID variable used in updating and deleting records
        int cellID = 0;
        public ViewAssets()
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

        private void ViewAssets_Load(object sender, EventArgs e)
        {
            sqlcon.Open();

            adapt = new SqlDataAdapter("SELECT DISTINCT LocationCurrent,Manufacturer,Model FROM Assets ", sqlcon);
            //DataTable dt;
            //dt = new DataTable();
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn();
            adapt.Fill(dt);
            sqlcon.Close();

            cbWH.Items.Clear();
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT distinct LocationOld FROM Assets";
            cmd.ExecuteNonQuery();
            

            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            foreach (DataRow dr in dt.Rows)


            {
                cbWH.Items.Add(dr["LocationCurrent"].ToString());
                cbManufacturer.Items.Add(dr["Manufacturer"].ToString());
                cbModel.Items.Add(dr["Model"].ToString());

            }
            sqlcon.Close();


            // TODO: This line of code loads data into the 'assetsViewDataSet.Assets' table. You can move, or remove it, as needed.
            assetsViewDataSet.EnforceConstraints = false;
            this.assetsTableAdapter1.Fill(this.assetsViewDataSet.Assets);
            // TODO: This line of code loads data into the 'indigoDataSet.Assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.indigoDataSet.Assets);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            var MainUIFrm = new MainUI();
            MainUIFrm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbWH_SelectedIndexChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("LocationCurrent = '{0}'", cbWH.Text);
        }

        private void cbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Manufacturer = '{0}'", cbManufacturer.Text);
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Model = '{0}'", cbModel.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Indigo Mobile Asset Management Report"; //Document Header
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Powered by Roan Systems"; //footer
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);


        }
    }
}
