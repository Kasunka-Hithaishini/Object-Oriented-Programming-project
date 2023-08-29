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
    public partial class Login_as_cashier : Form
    {
        public Login_as_cashier()
        {
            InitializeComponent();
        }

        private void btnCashierBack_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void btnCashierLogin_Click(object sender, EventArgs e)
        {
            string password;

            password = "cashier";
            if(password==txtCashierPass.Text)
            {
                Item_Selling obj = new Item_Selling();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password is incorrect!!!");
            }
        }
    }
}
