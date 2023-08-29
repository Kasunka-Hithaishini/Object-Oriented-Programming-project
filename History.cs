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
    public partial class History : Form
    {
        public History()
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
            string concstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "select * from itemselling";
            SqlDataAdapter datad = new SqlDataAdapter(query, concstring);
            DataSet dset = new DataSet();
            datad.Fill(dset, "itemselling");
            bhistory.DataSource = dset.Tables["itemselling"];
        }
    }
}
