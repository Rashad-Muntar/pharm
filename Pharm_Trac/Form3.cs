using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Pharm_Trac
{
    public partial class employeesForm : Form
    {
        string path = "Data Source=<server link here>;Initial Catalog=<database name here>;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmb;
        SqlDataAdapter adpt;
        DataTable dt;



        public employeesForm()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            dt = new DataTable();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String empoyeeName = name.Text;
            String empAddress = address.Text;
            String empDate = date.Text;
            String empContact = contact.Text;
            String gender;
            String empUsername = username.Text;
            String empPassword = password.Text;

            if (maleRb.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            try
            {
                String query = "INSERT INTO Orders (employeeName, address, date, contact, gender, username, password) Values(@employeeName, @address, @date, @contact, @gender, @username, @password,)";
                cmb = new SqlCommand(query, con);

                con.Open();
                cmb.Parameters.Add("@employeeName", empoyeeName);
                cmb.Parameters.Add("@address", empAddress);
                cmb.Parameters.Add("@date", empDate);
                cmb.Parameters.Add("@contact", empContact);
                cmb.Parameters.Add("@gender", gender);
                cmb.Parameters.Add("@username", empUsername);
                cmb.Parameters.Add("@password", empPassword);

                cmb.ExecuteNonQuery();
                MessageBox.Show("Employee is made succesfully created");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadEmpsBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String query = "SELECT * FROM Employees ORDER BY employee_id DESC";
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
