using System;
using System.Windows.Forms;

namespace Pharm_Trac
{
    public partial class dashboard : Form
    {
        employeesForm makeEmployeesForm = new employeesForm();
        receiptForm receiptForm = new receiptForm();
        purchasesForm purchasesForm = new purchasesForm();
        salesForm salesForm = new salesForm();
        reportForm reportForm = new reportForm();
        productForm productForm = new productForm();
        public dashboard()
        {
            InitializeComponent();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            makeEmployeesForm.Show();
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            receiptForm.Show();
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
             purchasesForm.Show();
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            salesForm.Show();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            reportForm.Show();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            productForm.Show();
        }
    }
}
