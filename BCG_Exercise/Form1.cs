using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCG_Exercise
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=LAPTOP-MRMP8IMQ\SQLEXPRESS;Initial Catalog=BCG_data;Integrated Security=True; ";

        public Form1()
        {
            InitializeComponent();

            Countries_list.Items.Add("Illinois");
            Countries_list.Items.Add("Georgia");
            Countries_list.Items.Add("New York");
            Countries_list.Items.Add("California");
            Countries_list.Items.Add("Washington");
            Countries_list.Items.Add("Florida");
            Countries_list.Items.Add("Colorado");

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Countries_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlcon=new SqlConnection(connectionString))
            {
                sqlcon.Open();
                string query = "SELECT  * from Sale_detail where State='" + Countries_list.SelectedItem  + "' ;";

                SqlDataAdapter sqldata = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);

                Dgv1.DataSource = dt;
               
                int[] columdata = (from DataGridViewRow row in Dgv1.Rows where row.Cells[2].FormattedValue.ToString() != string.Empty
                                   select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();
                
                this.Dgv1.Sort(this.Dgv1.Columns["Count"], ListSortDirection.Ascending);
                int rowcount = Dgv1.Rows.Count;
                
                rowcount = (rowcount-1) / 2;
                DataGridViewRow rows = Dgv1.Rows[rowcount];
                
                Average.Text = columdata.Average().ToString();
                Sum.Text= columdata.Sum().ToString();
                Median.Text = rows.Cells[2].Value.ToString();
              
            }
        }

    }
}
