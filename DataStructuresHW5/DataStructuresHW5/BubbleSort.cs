using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataStructuresHW5
{
    class BubbleSort
    {
        private List<int> data;
        private int endIndex;
        private int numElements;
        public TimeSpan sortTime;

        public BubbleSort()
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

            int temp = data[0];

            for (int i = 0; i < numElements; i++)
            {
                for (int j = i + 1; j < numElements; j++)
                {
                    if (data[i] > data[j])
                    {
                        temp = data[i];

                        data[i] = data[j];

                        data[j] = temp;
                    }
                }
            }

            stopwatch.Stop();

            sortTime = stopwatch.Elapsed;

        }

    }
}
