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
         string _selectedCountry;
         double _avg;
         string _sum;


        public DataTable dataTable
        {
            get { return _dataTable; }
            set { _dataTable = value; }
        }

        public double avg
        {
            get { return _avg; }
            set { _avg = value; }
        }

        public string sum
        {
            get { return _sum; }
            set { _sum = value; }
        }

        public string SelectedCountry
        {
            get { return _selectedCountry; }
            set { _selectedCountry = value; }
        }


    }
}
