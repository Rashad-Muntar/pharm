using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharm_Trac
{
    public partial class Form1 : Form
    {
        dashboard mkDashboard = new dashboard();
        const string loginUser = "Rashad";
        const string loginPassword = "rashad123";
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            string pass = password.Text;
            if(name == loginUser && pass == loginPassword)
            {
                mkDashboard.Show();
            }
            else { MessageBox.Show("Please enter a valid creddentials"); }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
