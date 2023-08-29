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
    public partial class Cashier_log_out : Form
    {
        public Cashier_log_out()
        {
            InitializeComponent();
        }

        private void btnCashierLogin_Click(object sender, EventArgs e)
        {
            Login_as_cashier obj = new Login_as_cashier();
            obj.Show();
            this.Hide();
        }

        private void btnItemsellBack_Click(object sender, EventArgs e)
        {
            Item_Selling obj = new Item_Selling();
            obj.Show();
            this.Hide();
        }

        private void Cashier_log_out_Load(object sender, EventArgs e)
        {

        }
    }
}
