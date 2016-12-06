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
        InsertionSort insertion;
        SelectionSort selection;
        BubbleSort bubble;
        MergeSort merge;

        public Form1()
        {
            InitializeComponent();
            insertion = new InsertionSort();
            selection = new SelectionSort();
            bubble = new BubbleSort();
            merge = new MergeSort();
        }

        private void btnStartSlow_Click(object sender, EventArgs e)
        {
            int winningPoints = Int32.Parse(cmbPointsSlow.SelectedItem.ToString());
            int sizeOfData = Int32.Parse(cmbSlowDataSet.SelectedItem.ToString());

            //initialize scores to 0
            lblSelectionScore.Text = "0";
            lblInsertionScore.Text = "0";
            lblBubbleScore.Text = "0";

            prgSelection.Value = 0;
            prgInsertion.Value = 0;
            prgBubble.Value = 0;

            lblInsertionTime.Text = "Time: ";
            lblSelectionTime.Text = "Time: ";
            lblBubbleTime.Text = "Time: ";

            while (Int32.Parse(lblInsertionScore.Text) < winningPoints && Int32.Parse(lblSelectionScore.Text) < winningPoints && Int32.Parse(lblBubbleScore.Text) < winningPoints)
            {

                Random rnd = new Random();
                List<int> dataSet = Enumerable.Range(0, sizeOfData).Select(n => rnd.Next(0, 1000000)).ToList();

                //run insertionSort 
                insertion.insertData(dataSet);
                insertion.sort();

                //run selectionSort        
                selection.insertData(dataSet);
                selection.sort();

                //run bubbleSort
                bubble.insertData(dataSet);
                bubble.sort();

                updateSlowScores();
            }
        }

        void updateSlowScores()
        {
            try
            {
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
            }
            catch (Exception e)
            {
                
            }
        }

        private void btnStartFast_Click(object sender, EventArgs e)
        {
            int winningPoints = Int32.Parse(cmbPointsFast.SelectedItem.ToString());
            int sizeOfData = Int32.Parse(cmbFastDataSet.SelectedItem.ToString());

            Random rnd = new Random();
            List<int> dataSet = Enumerable.Range(0, sizeOfData).Select(n => rnd.Next(0, 1000000)).ToList();

            //run mergeSort 
            merge.insertData(dataSet);
            merge.sort();

            //updateScores();
        }
    }
}
