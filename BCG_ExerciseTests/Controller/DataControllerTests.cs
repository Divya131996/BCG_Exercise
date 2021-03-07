using Microsoft.VisualStudio.TestTools.UnitTesting;
using BCG_Exercise.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using BCG_Exercise.Models;
using System.Data;


namespace BCG_Exercise.Controller.Tests
{
    [TestClass()]
    public class DataControllerTests
    {
        DataModel _model = new DataModel();

        DataView view = new DataView();
        [TestMethod()]
        public void CalculateDataTest()
        {
            DataController dataController = new DataController(view,_model);

            var table = new DataTable();
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Month", typeof(string));
            table.Columns.Add("COUNT", typeof(int));
          

            table.Rows.Add("Illinois", "January", 500);
            table.Rows.Add("Illinois", "February", 100);
            table.Rows.Add("Illinois", "February", 200);
            
            _model.DataTable = table;
            dataController.LoadData();
             dataController.CalculateData();
            Assert.AreEqual("266.67", Math.Round(_model.Avg,2).ToString());
            Assert.AreEqual("800", _model.Sum);
           
            

        }
    }
}