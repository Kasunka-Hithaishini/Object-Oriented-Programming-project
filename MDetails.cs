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
    public partial class MDetails : Form
    {
        public MDetails()
        {
            InitializeComponent();
        }

        private void btnItemDetails_Click(object sender, EventArgs e)
        {
            Item_Details objid = new Item_Details();
            objid.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_Logout obj = new Manager_Logout();
            obj.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Manager_Login obj = new Manager_Login();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Income obj = new Income();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            History obj = new History();
            obj.Show();
            this.Hide();
        }

        private void btnCashier1Name_Click(object sender, EventArgs e)
        {
            Cashier_1_Name obj = new Cashier_1_Name();
            obj.Show();
            this.Hide();
        }

        private void btnCashier2Name_Click(object sender, EventArgs e)
        {
            Cashier_2_Name obj = new Cashier_2_Name();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addmanager objadm = new Addmanager();
            objadm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Addcashier objadc = new Addcashier();
            objadc.Show();
            this.Hide();
        }

        private void MDetails_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cashier_1_Update objup = new Cashier_1_Update();
            objup.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Delete objde = new Delete();
            objde.Show();
            this.Hide();
        }
    }
}
