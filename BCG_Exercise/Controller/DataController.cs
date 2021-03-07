using BCG_Exercise.Models;
using System;
using System.Data;
using System.Linq;

namespace BCG_Exercise.Controller
{
    //
    public class DataController
    {
        DataView _view;
        DataModel _model;

        /// <summary>
        /// Controller Constructor 
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public DataController(DataView view,DataModel model)
        {
            _view = view;
            _model = model;
            _view.setController(this);
        }

        #region public methods

        /// <summary>
        /// Load data from datatable and set it to datagrid
        /// </summary>
        public void LoadData()
        {
            _model.dv = _model.DataTable.DefaultView;
            _model.dv.RowFilter = string.Format("State LIKE '%{0}%'", _model.SelectedStates);
            _view.Datagridview1.DataSource = _model.dv;
        }

        /// <summary>
        /// 
        /// Calculate sum , average, median for states sale count
        /// </summary>
        public void CalculateData()
        {
            try
            {
                int[] columdata = _model.dv.ToTable().AsEnumerable().Select(r => r.Field<int>("Count")).ToArray();
                int rowcount = columdata.Length;
                _view.Average.Text = columdata.Length == 0 ? "" : AverageData(columdata).ToString();
                _model.Avg = AverageData(columdata);
                 _model.Sum = SumData(columdata);
                _view.Sum.Text = columdata == null ? "" : SumData(columdata);
                _view.Median.Text = columdata == null ? "" : FindMedian(columdata, rowcount).ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// find a median for count
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int FindMedian(int[] a, int n)
        {          
            Array.Sort(a);
            if (n % 2 != 0)
            {
                return (int)a[n / 2];
            }
            return (int)(a[(n/2)+1] + a[n/2]) / 2;
        }

        /// <summary>
        /// Find average of  sale
        /// </summary>
        /// <param name="avg"></param>
        /// <returns></returns>
        public double AverageData(int[] avg)
        {
            return avg.Average();
        }

        /// <summary>
        /// Find Sum of sale 
        /// </summary>
        /// <param name="avg"></param>
        /// <returns></returns>
        public String SumData(int[] avg)
        {
            return avg.Sum().ToString();
        }

        public void StateChangedMethod()
        {
            _model.SelectedStates = _view.SelectedState;
        }
        #endregion
    }
}
