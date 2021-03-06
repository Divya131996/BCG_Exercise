using System;
using System.Windows.Forms;
using BCG_Exercise.Controller;
using BCG_Exercise.Models;

namespace BCG_Exercise
{
    public partial class DataView : Form, View.IDataView
    {
       
        public string SelectedState { get; set; }
        DataController dataController;



        public DataView()
        {
            InitializeComponent();

            State_list.Items.Add("Illinois");
            State_list.Items.Add("Georgia");
            State_list.Items.Add("New York");
            State_list.Items.Add("California");
            State_list.Items.Add("Washington");
            State_list.Items.Add("Florida");
            State_list.Items.Add("Colorado");

        }

        public void setController(DataController _dataController)
        {
            dataController = _dataController;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedState = State_list.SelectedItem.ToString();
            dataController.ComboBoxChangedMethod();
            dataController.LoadData();
            dataController.CalculateData();


        }



    }
}

