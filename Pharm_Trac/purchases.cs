using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace Pharm_Trac
{
    public partial class purchasesForm : Form
    {
        string path = "Data Source=<server link here>;Initial Catalog=<database name here>;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmb;
        SqlDataAdapter adpt;
        DataTable dt;
        public purchasesForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            dt = new DataTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void purchasesForm_Load(object sender, EventArgs e)
        {
            try
            {

                String query = "SELECT * FROM Purchases ORDER BY receipt_id DESC";
                con.Open();
                adpt = new SqlDataAdapter(query, con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
