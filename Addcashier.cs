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
    public partial class Addcashier : Form
    {
        public Addcashier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDetails objmd = new MDetails();
            objmd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int cashierid = int.Parse(txtcid.Text);
            string name = txtname.Text;
            int contactno = int.Parse(txtcontact.Text);
            string emailaddress = txtemail.Text;
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into cashier_details values(" + cashierid + ",'" + name + "'," + contactno + ",'" + emailaddress + "')";
            SqlCommand command = new SqlCommand(query, conc);

            try
            {
                conc.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");
            }

            catch (SqlException cdetail)
            {
                MessageBox.Show("An error occured" + cdetail.ToString());
            }

            finally
            {
                conc.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
