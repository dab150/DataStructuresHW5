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
            int sizeOfData = Int32.Parse(cmbSlowDataSet.SelectedItem.ToString());

            Random rnd = new Random();
            List <int> dataSet = Enumerable.Range(0, sizeOfData).Select(n => rnd.Next(0, 1000000)).ToList();

            dataSet.ToString();

            InsertionSort insertion = new InsertionSort(sizeOfData);
            insertion.insertData(dataSet);
            insertion.sort();



        }
    }
}
