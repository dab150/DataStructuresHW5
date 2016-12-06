using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataStructuresHW5
{
    class InsertionSort
    {
        private List<int> data;
        private int endIndex;
        private int numElements;
        public TimeSpan sortTime;

        public InsertionSort()
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

            int inner, temp;

            for (int outer = 1; outer <= endIndex; outer++)
            {
                temp = data[outer];
                inner = outer;
                while (inner > 0 && data[inner - 1] >= temp)
                {
                    data[inner] = data[inner - 1];
                    inner -= 1;
                }

                data[inner] = temp;
            }

            stopwatch.Stop();

            sortTime = stopwatch.Elapsed;
        }
    }
}
