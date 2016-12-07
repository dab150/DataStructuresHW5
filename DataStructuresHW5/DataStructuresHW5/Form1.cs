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
        QuickSort quickFirst;
        QuickSort quickMid;

        public Form1()
        {
            InitializeComponent();
            insertion = new InsertionSort();
            selection = new SelectionSort();
            bubble = new BubbleSort();
            merge = new MergeSort();
            quickFirst = new QuickSort();
            quickMid = new QuickSort();
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

        private void updateSlowScores()
        {
            try
            {
                prgInsertion.Maximum = Int32.Parse(cmbPointsSlow.SelectedItem.ToString());
                prgSelection.Maximum = Int32.Parse(cmbPointsSlow.SelectedItem.ToString());
                prgBubble.Maximum = Int32.Parse(cmbPointsSlow.SelectedItem.ToString());

                if (Math.Min(insertion.sortTime.TotalMilliseconds, Math.Min(selection.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds)) == insertion.sortTime.TotalMilliseconds)
                {
                    //assign 3 points to insertion
                    prgInsertion.PerformStep();
                    prgInsertion.PerformStep();
                    prgInsertion.PerformStep();


                    if (Math.Min(selection.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds) == selection.sortTime.TotalMilliseconds)
                    {
                        //give 2 points to selection
                        prgSelection.PerformStep();
                        prgSelection.PerformStep();
                        //give 1 point to bubble
                        prgBubble.PerformStep();
                    }
                    else
                    {
                        //give 2 points to bubble
                        prgBubble.PerformStep();
                        prgBubble.PerformStep();
                        //give 1 point to selection
                        prgSelection.PerformStep();
                    }
                }
                else if (Math.Min(insertion.sortTime.TotalMilliseconds, Math.Min(selection.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds)) == selection.sortTime.TotalMilliseconds)
                {
                    //assign 3 points to selection
                    prgSelection.PerformStep();
                    prgSelection.PerformStep();
                    prgSelection.PerformStep();

                    if (Math.Min(insertion.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds) == insertion.sortTime.TotalMilliseconds)
                    {
                        //give 2 points to insertion
                        prgInsertion.PerformStep();
                        prgInsertion.PerformStep();

                        //give 1 point to bubble
                        prgBubble.PerformStep();
                    }
                    else
                    {
                        //give 2 points to bubble
                        prgBubble.PerformStep();
                        prgBubble.PerformStep();
                        //give 1 point to insertion
                        prgInsertion.PerformStep();
                    }
                }
                else if (Math.Min(insertion.sortTime.TotalMilliseconds, Math.Min(selection.sortTime.TotalMilliseconds, bubble.sortTime.TotalMilliseconds)) == bubble.sortTime.TotalMilliseconds)
                {
                    //assign 3 points to bubble
                    prgBubble.PerformStep();
                    prgBubble.PerformStep();
                    prgBubble.PerformStep();

                    if (Math.Min(insertion.sortTime.TotalMilliseconds, selection.sortTime.TotalMilliseconds) == insertion.sortTime.TotalMilliseconds)
                    {
                        //give 2 points to insertion
                        prgInsertion.PerformStep();
                        prgInsertion.PerformStep();
                        //give 1 point to selection
                        prgSelection.PerformStep();
                    }
                    else
                    {
                        //give 2 points to selection
                        prgSelection.PerformStep();
                        prgSelection.PerformStep();
                        //give 1 point to insertion
                        prgInsertion.PerformStep();
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

            //initialize scores to 0
            lblMergeScore.Text = "0";
            lblQuickFirstScore.Text = "0";
            lblQuickMidScore.Text = "0";

            prgMerge.Value = 0;
            prgQuickFirst.Value = 0;
            prgQuickMid.Value = 0;

            lblMergeTime.Text = "Time: ";
            lblQuickFirstTime.Text = "Time: ";
            lblQuickMidTime.Text = "Time: ";

            while (Int32.Parse(lblMergeScore.Text) < winningPoints && Int32.Parse(lblQuickFirstScore.Text) < winningPoints && Int32.Parse(lblQuickMidScore.Text) < winningPoints)
            {

                Random rnd = new Random();
                List<int> dataSet = Enumerable.Range(0, sizeOfData).Select(n => rnd.Next(0, 1000000)).ToList();

             

                //run quicksort (Pivot at First Element)
                quickFirst.insertData(dataSet);
                quickFirst.sortFirst();

                //run quicksort (Pivot at Middle Element)
                quickMid.insertData(dataSet);
                quickMid.sortMid();

                //run mergeSort 
                merge.insertData(dataSet);
                merge.sort();

                updateFastScores();
            }
        }

        private void updateFastScores()
        {
            try
            {
                prgMerge.Maximum = Int32.Parse(cmbPointsFast.SelectedItem.ToString());
                prgQuickFirst.Maximum = Int32.Parse(cmbPointsFast.SelectedItem.ToString());
                prgQuickMid.Maximum = Int32.Parse(cmbPointsFast.SelectedItem.ToString());

                if (Math.Min(merge.sortTime.TotalMilliseconds, Math.Min(quickFirst.sortTimeFirst.TotalMilliseconds, quickMid.sortTimeMid.TotalMilliseconds)) == merge.sortTime.TotalMilliseconds)
                {
                    //assign 3 points to merge
                    prgMerge.PerformStep();
                    prgMerge.PerformStep();
                    prgMerge.PerformStep();

                    if (Math.Min(quickFirst.sortTimeFirst.TotalMilliseconds, quickMid.sortTimeMid.TotalMilliseconds) == quickFirst.sortTimeFirst.TotalMilliseconds)
                    {
                        //give 2 points to quickFirst
                        prgQuickFirst.PerformStep();
                        prgQuickFirst.PerformStep();

                        //give 1 point to quickMid
                        prgQuickMid.PerformStep();
                    }
                    else
                    {
                        //give 2 points to quickMid
                        prgQuickMid.PerformStep();
                        prgQuickMid.PerformStep();
                        //give 1 point to quickFirst
                        prgQuickFirst.PerformStep();
                    }
                }
                else if (Math.Min(merge.sortTime.TotalMilliseconds, Math.Min(quickFirst.sortTimeFirst.TotalMilliseconds, quickMid.sortTimeMid.TotalMilliseconds)) == quickFirst.sortTimeFirst.TotalMilliseconds)
                {
                    //assign 3 points to quickFirst
                    prgQuickFirst.PerformStep();
                    prgQuickFirst.PerformStep();
                    prgQuickFirst.PerformStep();

                    if (Math.Min(merge.sortTime.TotalMilliseconds, quickMid.sortTimeMid.TotalMilliseconds) == merge.sortTime.TotalMilliseconds)
                    {
                        //give 2 points to merge
                        prgMerge.PerformStep();
                        prgMerge.PerformStep();
                        //give 1 point to quickMid
                        prgQuickMid.PerformStep();
                    }
                    else
                    {
                        //give 2 points to quickMid
                        prgQuickMid.PerformStep();
                        prgQuickMid.PerformStep();
                        //give 1 point to merge
                        prgMerge.PerformStep();
                    }
                }
                else if (Math.Min(merge.sortTime.TotalMilliseconds, Math.Min(quickFirst.sortTimeFirst.TotalMilliseconds, quickMid.sortTimeMid.TotalMilliseconds)) == quickMid.sortTimeMid.TotalMilliseconds)
                {
                    //assign 3 points to quickMid
                    prgQuickMid.PerformStep();
                    prgQuickMid.PerformStep();
                    prgQuickMid.PerformStep();

                    if (Math.Min(merge.sortTime.TotalMilliseconds, quickFirst.sortTimeFirst.TotalMilliseconds) == merge.sortTime.TotalMilliseconds)
                    {
                        //give 2 points to merge
                        prgMerge.PerformStep();
                        prgMerge.PerformStep();
                        //give 1 point to quickFirst
                        prgQuickFirst.PerformStep();
                    }
                    else
                    {
                        //give 2 points to quickFirst
                        prgQuickFirst.PerformStep();
                        prgQuickFirst.PerformStep();
                        //give 1 point to merge
                        prgMerge.PerformStep();
                    }
                }

                lblMergeScore.Text = prgMerge.Value.ToString();
                lblQuickFirstScore.Text = prgQuickFirst.Value.ToString();
                lblQuickMidScore.Text = prgQuickMid.Value.ToString();

                lblMergeTime.Text = "Time: " + merge.sortTime.TotalMilliseconds.ToString();
                lblQuickFirstTime.Text = "Time: " + quickFirst.sortTimeFirst.TotalMilliseconds.ToString();
                lblQuickMidTime.Text = "Time: " + quickMid.sortTimeMid.TotalMilliseconds.ToString();
            }
            catch (Exception e)
            {

            }
        }

    }
}
