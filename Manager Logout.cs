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
    public partial class Manager_Logout : Form
    {
        public Manager_Logout()
        {
            InitializeComponent();
        }

        private void btnCashierLogin_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void btnItemsBack_Click(object sender, EventArgs e)
        {
            MDetails obj = new MDetails();
            obj.Show();
            this.Hide();
        }
    }
}
