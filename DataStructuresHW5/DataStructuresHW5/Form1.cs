using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresHW5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataSlow_Click(object sender, EventArgs e)
        {

        }

        private void btnStartSlow_Click(object sender, EventArgs e)
        {
            //NEED TO ADD LOOP TO RUN THIS HOW EVER MANY TIMES WE NEED TO FOR A "ROUND"
            
            //create my dataset
            //do this here rather than in the classes because they all need to have the same data for comparison
            int sizeOfData = Int32.Parse(cmbSlowDataSet.SelectedItem.ToString());

            Random rnd = new Random();
            List <int> dataSet = Enumerable.Range(0, sizeOfData).Select(n => rnd.Next(0, 1000000)).ToList();

            //run insertionSort
            InsertionSort insertion = new InsertionSort(sizeOfData);
            insertion.insertData(dataSet);
            insertion.sort();

            //run selectionSort
            SelectionSort selection = new SelectionSort(sizeOfData);
            selection.insertData(dataSet);
            selection.sort();



        }
    }
}
