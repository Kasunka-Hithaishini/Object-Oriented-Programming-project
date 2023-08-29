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
    public partial class Cashier_1_Update : Form
    {
        public Cashier_1_Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_Password obj = new Manager_Password();
            obj.Show();
            this.Hide();
        }

        private void btnItemsBack_Click(object sender, EventArgs e)
        {
            MDetails obj = new MDetails();
            obj.Show();
            this.Hide();
        }

        private void Cashier_1_Update_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcid1.Text = "";
            txtcname1.Text = "";
            txtCashier1Number.Text = "";
            txtCashier1Email.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int cid1 = int.Parse(txtcid1.Text);
            string cname1 = txtcname1.Text;
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30");
            string qry1 = "update cashier_details set Name='" + cname1 + "' where Cashier_ID="+cid1+"";
            

            SqlCommand cmd1 = new SqlCommand(qry1, conc);
            

            try
            {
                conc.Open();
                cmd1.ExecuteNonQuery();
              
                MessageBox.Show("The data was updated");
            }

            catch(SqlException up)
            {
                MessageBox.Show("There is an error :" + up.ToString());
            }

            finally
            {
                conc.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cid2 = int.Parse(txtcid1.Text);
            string cno1 = txtCashier1Number.Text;           
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30");
            string qry2 = "update cashier_details set Contact_number='" + cno1 + "' where Cashier_ID=" + cid2 + "";
            SqlCommand cmd1 = new SqlCommand(qry2, conc);


            try
            {
                conc.Open();
                cmd1.ExecuteNonQuery();

                MessageBox.Show("The data was updated");

            }

            catch (SqlException up)
            {
                MessageBox.Show("There is an error :" + up.ToString());
            }

            finally
            {
                conc.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int casid = int.Parse(txtcid1.Text);
            string cno1 = txtCashier1Email.Text;
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30");
            string qry2 = "update cashier_details set Email_address='" + cno1 + "' where Cashier_ID=" + casid + "";
            SqlCommand cmd1 = new SqlCommand(qry2, conc);


            try
            {
                conc.Open();
                cmd1.ExecuteNonQuery();

                MessageBox.Show("The data was updated");

            }

            catch (SqlException up)
            {
                MessageBox.Show("There is an error :" + up.ToString());
            }

            finally
            {
                conc.Close();
            }
        }
    }
}
