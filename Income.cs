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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MDetails obj = new MDetails();
            obj.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            History objhis = new History();
            objhis.Show();
            this.Hide();
        }

        private void lblcurrentincome_Click(object sender, EventArgs e)
        {

        }

        private void lblmonthlyincome_Click(object sender, EventArgs e)
        {

        }

        private void lbldayincome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string concstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "select sum(Total) from itemselling";
            SqlDataAdapter datad = new SqlDataAdapter(query, concstring);
            DataSet dset = new DataSet();
            datad.Fill(dset, "itemselling");
           dci.DataSource = dset.Tables["itemselling"];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            
            
            
        }
    }
}
