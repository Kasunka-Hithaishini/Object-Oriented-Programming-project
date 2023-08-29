using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_for_a_food_city.cs
{
    public partial class Manager_Login : Form
    {
        public Manager_Login()
        {
            InitializeComponent();
        }

        private void btnCashierLogin_Click(object sender, EventArgs e)
        {
            string mpassword = "manager";
            if(mpassword==txtmanagerpassword.Text)
            {
                MDetails obj = new MDetails();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password!!!");
            }
        }

        private void btnCashierBack_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
