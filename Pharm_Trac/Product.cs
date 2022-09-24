using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Pharm_Trac
{
    public partial class productForm : Form
    {
        string path = "Data Source=<server link here>;Initial Catalog=<database name here>;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmb;
        SqlDataAdapter adpt;
        DataTable dt;
        public productForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            dt = new DataTable();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String prodName = productName.Text;
            String manufacturer = producer.Text;
            String prodPrice = price.Text;
            String prodQty = qty.Text;
            String date = prodDate.Text;

            try
            {
                String query = "INSERT INTO Orders (customer, address, product, quantity, date) Values(@customer, @address, @product, @quantity, @date)";
                cmb = new SqlCommand(query, con);

                con.Open();
                cmb.Parameters.Add("@customer", prodName);
                cmb.Parameters.Add("@address", manufacturer);
                cmb.Parameters.Add("@product", prodPrice);
                cmb.Parameters.Add("@quantity", prodQty);
                cmb.Parameters.Add("@date", date);
                cmb.ExecuteNonQuery();
                MessageBox.Show("Employee is made succesfully created");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
