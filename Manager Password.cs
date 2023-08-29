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
    public partial class Manager_Password : Form
    {
        public Manager_Password()
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
                MessageBox.Show("Password is incorrect");
            }
        }

        private void btnItemsBack_Click(object sender, EventArgs e)
        {
            Item_Details obj = new Item_Details();
            obj.Show();
            this.Hide();
        }
    }
}
