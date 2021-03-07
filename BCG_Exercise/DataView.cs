using BCG_Exercise.Controller;
using System;
using System.Windows.Forms;

namespace BCG_Exercise
{
    //
    public partial class DataView : Form, View.IDataView
    {
        // 
        DataController dataController;

        /// <summary>
        /// DataView COntructor
        /// </summary>
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

        /// <summary>
        /// change the value of state calculate data for that state
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e"Event Arguments></param>
        private void StateSelectedChange(object sender, EventArgs e)
        {
            SelectedState = State_list.SelectedItem.ToString();
            dataController.StateChangedMethod();
            dataController.LoadData();
            dataController.CalculateData();
        }

     
        public void setController(DataController _dataController)
        {
            dataController = _dataController;
        }

      
        public string SelectedState { get; set; }

    
    }
}

