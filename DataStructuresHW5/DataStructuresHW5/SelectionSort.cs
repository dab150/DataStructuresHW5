using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataStructuresHW5
{
    class SelectionSort
    {
        private List<int> data;
        private int endIndex;
        private int numElements;
        public TimeSpan sortTime;

        public SelectionSort()
        {

        }

        public void insertData(List<int> dataSet)
        {
            endIndex = dataSet.Count - 1;
            numElements = dataSet.Count;
            data = dataSet;
        }

        public void sort()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //pos_min is short for position of min
            int pos_min, temp;

            for (int i = 0; i < numElements - 1; i++)
            {
                pos_min = i;//set pos_min to the current index of array

                for (int j = i + 1; j < numElements; j++)
                {
                    if (data[j] < data[pos_min])
                    {
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = data[i];
                    data[i] = data[pos_min];
                    data[pos_min] = temp;
                }
            }

            stopwatch.Stop();

            sortTime = stopwatch.Elapsed;
        }
    }
}
