using System;
using System.Data;
using System.Data.SqlClient;

namespace BCG_Exercise.Models
{
    public class DataModel
    {

        #region private variables
        DataTable _dataTable;
         string _selectedStates;
         double _avg;
         string _sum;
        #endregion

        #region public property
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
        /// <summary>
        /// 
        /// </summary>
        public System.Data.DataView dv
        {
            get; set;
        }

        public DataTable getDataFromDatabase()
        {
            string connectionString = @"Data Source=LAPTOP-MRMP8IMQ\SQLEXPRESS;Initial Catalog=BCG_data;Integrated Security=True; ";
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                string query = "SELECT  * from Sale_detail";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, sqlcon);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                return dt;
            }
        }

        /// <summary>
        /// 
        /// </summary>
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

        #endregion
    }
}
