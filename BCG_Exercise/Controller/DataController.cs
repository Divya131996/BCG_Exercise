using BCG_Exercise.Models;
using BCG_Exercise.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCG_Exercise.Controller
{
    public class DataController
    {
        DataView _view;
        DataModel _model = new DataModel();

        public DataController(DataView view,DataModel model)
        {
            _view = view;
            _model = model;
            
        }
        public void LoadData()
        {
            try {
                string connectionString = @"Data Source=LAPTOP-MRMP8IMQ\SQLEXPRESS;Initial Catalog=BCG_data;Integrated Security=True; ";
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    string query = "SELECT  * from Sale_detail where State='" + _view.selectedCountry + "' ;";
                    SqlDataAdapter sqldata = new SqlDataAdapter(query, sqlcon);
                    DataTable dt = new DataTable();
                    sqldata.Fill(dt);
                    _model.dataTable = dt;
                    _view.Dgv1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void CalculateData()
        {
            try
            {
                int[] columdata = _model.dataTable.AsEnumerable().Select(r => r.Field<int>("COUNT")).ToArray();
                int rowcount = columdata.Length;

                _view.Average.Text = columdata.Length == 0 ? "" : AverageData(columdata).ToString();
                _model.avg = AverageData(columdata);

                _model.sum = SumData(columdata);
                _view.Sum.Text = columdata == null ? "" : SumData(columdata).ToString();

                _view.Median.Text = columdata == null ? "" : FindMedian(columdata, rowcount).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public int FindMedian(int[] a, int n)
        {          
            Array.Sort(a);
            if (n % 2 != 0)
            {
                return (int)a[n / 2];
            }
            return (int)(a[(n/2)+1] + a[n/2]) / 2;
        }
        public double AverageData(int[] avg)
        {
            return avg.Average();
        }

        public String SumData(int[] avg)
        {
            return avg.Sum().ToString();
        }
        public void ComboBoxChangedMethod()
        {
            _model.SelectedCountry = _view.selectedCountry;
        }
    }
}
