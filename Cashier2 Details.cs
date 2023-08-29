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
    public partial class Cashier2_Details : Form
    {
        public Cashier2_Details()
        {
            InitializeComponent();
        }

        private void btnItemsBack_Click(object sender, EventArgs e)
        {
            Cashier_2_Name obj = new Cashier_2_Name();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_Password obj = new Manager_Password();
            obj.Show();
            this.Hide();
        }

        private void Cashier2_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
