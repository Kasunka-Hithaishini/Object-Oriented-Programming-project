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
    public partial class Cashier_2_Name : Form
    {
        public Cashier_2_Name()
        {
            InitializeComponent();
        }

        private void btnItemsBack_Click(object sender, EventArgs e)
        {
            Cashier_1_Name obj = new Cashier_1_Name();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_Password obj = new Manager_Password();
            obj.Show();
            this.Hide();
        }

        private void Cashier_2_Name_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cashier2_Details obj = new Cashier2_Details();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string concstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "select * from cashier_details where Cashier_ID='1002'";
            SqlDataAdapter datad = new SqlDataAdapter(query, concstring);
            DataSet dset = new DataSet();
            datad.Fill(dset, "cashier_details");
            datacach2.DataSource = dset.Tables["cashier_details"];
        }
    }
}