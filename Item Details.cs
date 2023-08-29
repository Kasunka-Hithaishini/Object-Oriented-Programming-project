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
    public partial class Item_Details : Form
    {
        public Item_Details()
        {
            InitializeComponent();
        }

        private void btnItemsBack_Click(object sender, EventArgs e)
        {
            Item_Selling obj = new Item_Selling();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_Password obj = new Manager_Password();
            obj.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string concstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "select * from item_details";
            SqlDataAdapter datad = new SqlDataAdapter(query, concstring);
            DataSet dset = new DataSet();
            datad.Fill(dset, "item_details");
            idetail.DataSource = dset.Tables["item_details"];


        }

        private void idetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
