using BCG_Exercise.Controller;
using BCG_Exercise.Models;
using System;

namespace BCG_Exercise
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            DataView view = new DataView();
            DataModel model = new DataModel();
            view.Visible = false;
            DataController dataController = new DataController(view, model);
            view.ShowDialog();

        }
    }
}

