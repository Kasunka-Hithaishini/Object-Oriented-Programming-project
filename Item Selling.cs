using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace System_for_a_food_city.cs
{
    public partial class Item_Selling : Form
    {
       public int total;
       private int payment;
        public Item_Selling()
        {
            InitializeComponent();
        }

        private void btnItemsellBack_Click(object sender, EventArgs e)
        {
            Login_as_cashier obj = new Login_as_cashier();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier_log_out obj = new Cashier_log_out();
            obj.Show();
            this.Hide();
        }

        private void btnCashierLogin_Click(object sender, EventArgs e)
        {
            Item_Details obj = new Item_Details();
            obj.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Item_Selling_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtItemID.Text);
            string iname = txtiname.Text;
           int iprice = int.Parse(txtprice.Text);
        int discount = int.Parse(txtdis.Text);
          int quantity =int.Parse(txtQTY.Text);
            total = int.Parse(txttotal.Text);
           int payment = int.Parse(txtpayment.Text);
            int balance = int.Parse(txtbalance.Text);
            
           

            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "insert into itemselling values(" + id + ",'" + iname + "'," + iprice + "," + discount + "," + quantity + ","+total+"," + payment + ","+balance+")";
            SqlCommand cmd = new SqlCommand(qry, conc);

            try
            {
                conc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data stored successfully");
            }

            catch(SqlException isel)
            {
                MessageBox.Show("There is an error" + isel.ToString());
            }
            
            finally
            {
                conc.Close();

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtiname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = int.Parse(txtprice.Text);
           int discount =int.Parse(txtdis.Text);
            int quantity =int.Parse(txtQTY.Text);
           int value = price - discount;
            total = value * quantity;
           txttotal.Text = total.ToString();

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
             payment = int.Parse(txtpayment.Text);
            int balance = payment -total;
            txtbalance.Text = balance.ToString();
        }
    }
}
