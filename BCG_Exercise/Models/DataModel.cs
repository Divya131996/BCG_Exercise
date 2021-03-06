using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCG_Exercise.Models
{
    public class DataModel
    {
       
         DataTable _dataTable;
         string _selectedStates;
         double _avg;
         string _sum;


        public DataTable DataTable
        {
            get
            {
                if (_dataTable == null)
                {
                    _dataTable = getDataFromDatabase();
                }
                return _dataTable;
            }
            set { _dataTable = value; }
        }

        public DataTable getDataFromDatabase()
        {
            string connectionString = @"Data Source=LAPTOP-MRMP8IMQ\SQLEXPRESS;Initial Catalog=BCG_data;Integrated Security=True; ";
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                //string query = "SELECT  * from Sale_detail where State='" + SelectedCountry + "' ;";
                string query = "SELECT  * from Sale_detail";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                return dt;
            }
        }
        public double Avg
        {
            get { return _avg; }
            set { _avg = value; }
        }

        public string Sum
        {
            get { return _sum; }
            set { _sum = value; }
        }

        public string SelectedStates
        {
            get { return _selectedStates; }
            set { _selectedStates = value; }
        }


    }
}
