using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Pharm_Trac
{
    public partial class salesForm : Form
    {
        string path = "Data Source=<server link here>;Initial Catalog=<database name here>;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmb;
    
        public salesForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);

        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            String custName = name.Text;
            String custAddress = contact.Text;
            String product = productName.Text;
            String prodQty = qty.Text;
            String date = salesDate.Text;

            try
            {
                String query = "INSERT INTO Orders (customer, address, product, quantity, date) Values(@customer, @address, @product, @quantity, @date)";
                cmb = new SqlCommand(query, con);

                con.Open();
                cmb.Parameters.Add("@customer", custName);
                cmb.Parameters.Add("@address", custAddress);
                cmb.Parameters.Add("@product", product);
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
