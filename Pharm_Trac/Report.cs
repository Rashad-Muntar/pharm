using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Net;


namespace Pharm_Trac
{
    public partial class reportForm : Form
    {
        string path = "Data Source=<server link here>;Initial Catalog=<database name here>;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmb;
        SqlDataAdapter adpt;
        DataTable dt;
        public reportForm()
        {
            con = new SqlConnection(path);
            dt = new DataTable();
            InitializeComponent();
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            try
            {

                String query = "SELECT * FROM Receipt ORDER BY receipt_id DESC";
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
