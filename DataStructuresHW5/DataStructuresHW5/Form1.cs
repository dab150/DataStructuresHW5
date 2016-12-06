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
            int winningPoints = Int32.Parse(cmbPointsSlow.SelectedItem.ToString());
            int sizeOfData = Int32.Parse(cmbSlowDataSet.SelectedItem.ToString());

            while (Int32.Parse(lblInsertionScore.Text) < winningPoints && Int32.Parse(lblSelectionScore.Text) < winningPoints && Int32.Parse(lblBubbleScore.Text) < winningPoints)
            {

                Random rnd = new Random();
                List<int> dataSet = Enumerable.Range(0, sizeOfData).Select(n => rnd.Next(0, 1000000)).ToList();

                //run insertionSort
                InsertionSort insertion = new InsertionSort(sizeOfData);
                insertion.insertData(dataSet);
                insertion.sort();

                //run selectionSort
                SelectionSort selection = new SelectionSort(sizeOfData);
                selection.insertData(dataSet);
                selection.sort();

                //run bubbleSort
                BubbleSort bubble = new BubbleSort(sizeOfData);
                bubble.insertData(dataSet);
                bubble.sort();

                //update score-----------------------------
                prgInsertion.Maximum = Int32.Parse(cmbPointsSlow.SelectedItem.ToString());
                prgSelection.Maximum = Int32.Parse(cmbPointsSlow.SelectedItem.ToString());
                prgBubble.Maximum = Int32.Parse(cmbPointsSlow.SelectedItem.ToString());

                if (Math.Min(insertion.sortTime.TotalMilliseconds, Math.Min(selection.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds)) == insertion.sortTime.TotalMilliseconds)
                {
                    //assign 3 points to insertion
                    prgInsertion.Value = prgInsertion.Value + 3;

                    if (Math.Min(selection.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds) == selection.sortTime.TotalMilliseconds)
                    {
                        //give 2 points to selection
                        prgSelection.Value = prgSelection.Value + 2;
                        //give 1 point to bubble
                        prgBubble.Value = prgBubble.Value + 1;
                    }
                    else
                    {
                        //give 2 points to bubble
                        prgBubble.Value = prgBubble.Value + 2;
                        //give 1 point to selection
                        prgSelection.Value = prgSelection.Value + 1;
                    }
                }
                else if (Math.Min(insertion.sortTime.TotalMilliseconds, Math.Min(selection.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds)) == selection.sortTime.TotalMilliseconds)
                {
                    //assign 3 points to selection
                    prgSelection.Value = prgSelection.Value + 3;

                    if (Math.Min(insertion.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds) == insertion.sortTime.TotalMilliseconds)
                    {
                        //give 2 points to insertion
                        prgInsertion.Value = prgInsertion.Value + 2;
                        //give 1 point to bubble
                        prgBubble.Value = prgBubble.Value + 1;
                    }
                    else
                    {
                        //give 2 points to bubble
                        prgBubble.Value = prgBubble.Value + 2;
                        //give 1 point to insertion
                        prgInsertion.Value = prgInsertion.Value + 1;
                    }
                }
                else if (Math.Min(insertion.sortTime.TotalMilliseconds, Math.Min(selection.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds)) == bubble.sortTime.TotalMilliseconds)
                {
                    //assign 3 points to bubble
                    prgBubble.Value = prgBubble.Value + 3;

                    if (Math.Min(insertion.sortTime.TotalMilliseconds, selection.sortTime.TotalMilliseconds) == insertion.sortTime.TotalMilliseconds)
                    {
                        //give 2 points to insertion
                        prgInsertion.Value = prgInsertion.Value + 2;
                        //give 1 point to selection
                        prgSelection.Value = prgSelection.Value + 1;
                    }
                    else
                    {
                        //give 2 points to selection
                        prgSelection.Value = prgSelection.Value + 2;
                        //give 1 point to insertion
                        prgInsertion.Value = prgInsertion.Value + 1;
                    }
                }

                lblSelectionScore.Text = prgSelection.Value.ToString();
                lblInsertionScore.Text = prgInsertion.Value.ToString();
                lblBubbleScore.Text = prgBubble.Value.ToString();

                lblInsertionTime.Text = "Time: " + insertion.sortTime.TotalMilliseconds.ToString();
                lblSelectionTime.Text = "Time: " + selection.sortTime.TotalMilliseconds.ToString();
                lblBubbleTime.Text = "Time: " + bubble.sortTime.TotalMilliseconds.ToString();

                //------------------------------------
            }
        }

    }
}
