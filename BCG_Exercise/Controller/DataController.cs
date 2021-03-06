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
        System.Data.DataView dv = null;


        public DataController(DataView view)
        {
            _view = view;
            _view.setController(this);


        }
        public void LoadData()
        {
            dv = _model.DataTable.DefaultView;
            dv.RowFilter = string.Format("State LIKE '%{0}%'", _model.SelectedStates);
            _view.Dgv1.DataSource = dv;


        }

        public void CalculateData()
        {
            try
            {
                int[] columdata = dv.ToTable().AsEnumerable().Select(r => r.Field<int>("Count")).ToArray();

                int rowcount = columdata.Length;

                _view.Average.Text = columdata.Length == 0 ? "" : AverageData(columdata).ToString();
                _model.Avg = AverageData(columdata);

                _model.Sum = SumData(columdata);
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
            _model.SelectedStates = _view.SelectedState;
        }
    }
}
