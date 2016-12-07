using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataStructuresHW5
{
    class MergeSort
    {
        private List<int> data;
        private int endIndex;
        private int numElements;
        public TimeSpan sortTime;

        public MergeSort()
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
            MergeSortIterative(ref data);
            stopwatch.Stop();
            sortTime = stopwatch.Elapsed;
        }

        public void MergeSortIterative(ref List<int> data)
        {
            int currentSize;
            int leftStart;

            for (currentSize = 1; currentSize <= data.Count - 1; currentSize = 2 * currentSize)
            {
                for (leftStart = 0; leftStart < data.Count - 1; leftStart += 2 * currentSize)
                {
                    int rightEnd = Math.Min(leftStart + 2 * currentSize - 1, data.Count - 1);
                    int mid = (leftStart + rightEnd) / 2;

                    Merge(ref data, leftStart, mid, rightEnd);
                }
            }
        }

        private void Merge(ref List<int> data, int left, int mid, int right)
        {
            int i, j, k;
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = data[left + i];

            for (j = 0; j < n2; j++)
                R[j] = data[mid + 1 + j];

            i = 0;
            j = 0;
            k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    data[k] = L[i];
                    i++;
                }
                else
                {
                    data[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                data[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                data[k] = R[j];
                j++;
                k++;
            }
        }

    }
}
