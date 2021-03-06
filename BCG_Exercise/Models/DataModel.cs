using System;
using System.Collections.Generic;
using System.Data;
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
            get { return _dataTable; }
            set { _dataTable = value; }
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
