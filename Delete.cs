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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id1 = int.Parse(txtid1.Text);
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30");
            string dqry = "Delete from cashier_details where Cashier_ID=" + id1 + "";
            SqlCommand cmd = new SqlCommand(dqry, conc);

            try
            {
                conc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data deletion completed");
            }
            catch(SqlException de)
            {
                MessageBox.Show("There is an error :"+de.ToString());
            }
            finally
            {
                conc.Close();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDetails objc1 = new MDetails();
            objc1.Show();
            this.Hide();
        }
    }
}
