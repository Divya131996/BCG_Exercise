using System;
using System.Windows.Forms;
using BCG_Exercise.Controller;
using BCG_Exercise.Models;

namespace BCG_Exercise
{
    public partial class DataView : Form, View.IDataView
    {
       
        public string selectedCountry { get; set; }

       
        public DataView()
        {
            InitializeComponent();

            Countries_list.Items.Add("Illinois");
            Countries_list.Items.Add("Georgia");
            Countries_list.Items.Add("New York");
            Countries_list.Items.Add("California");
            Countries_list.Items.Add("Washington");
            Countries_list.Items.Add("Florida");
            Countries_list.Items.Add("Colorado");

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataModel dataModel = new DataModel();
            DataController dataController = new DataController(this,dataModel);
            selectedCountry = Countries_list.SelectedItem.ToString();
            dataController.loadData();
            dataController.CalculateData();
            dataController.ComboBoxChangedMethod();

        }


        
    }
}

