using BCG_Exercise.Controller;
using BCG_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCG_Exercise
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
           
            DataView view = new DataView();
            DataModel dataModel = new DataModel();
            view.Visible = false;
            DataController dataController = new DataController(view,dataModel);
            view.ShowDialog();
        }
    }
}
