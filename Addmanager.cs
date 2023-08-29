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
    public partial class Addmanager : Form
    {
        public Addmanager()
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
            int managerid = int.Parse(txtmid.Text);
            string name = txtname.Text;
             int contactno = int.Parse(txtcontact.Text);
            string emailaddress = txtemail.Text;
            SqlConnection conc = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "insert into manager_details values("+managerid+",'" + name + "'," + contactno + ",'" + emailaddress + "')";
            SqlCommand command = new SqlCommand(query, conc);

            try
            {
                conc.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");
            }

            catch(SqlException mdetail)
            {
                MessageBox.Show("An error occured" + mdetail.ToString()); 
            }

            finally
            {
                conc.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
