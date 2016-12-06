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
        private List<int> arr;
        private int endIndex;
        private int numElements;

        public InsertionSort(int size)
        {
            endIndex = size - 1;
            numElements = size;
        }

        public void insertData(List<int> data)
        {
            arr = data;
        }

        public void sort()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int inner, temp;

            for (int outer = 1; outer <= endIndex; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (inner > 0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }

                arr[inner] = temp;
            }

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            System.Windows.Forms.MessageBox.Show("Insertion Sort Complete! \nTook " + ts.TotalMilliseconds.ToString() + " milliseconds!");
        }
    }
}
