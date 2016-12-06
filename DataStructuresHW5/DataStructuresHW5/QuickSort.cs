using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataStructuresHW5
{
    class QuickSort
    {
        private List<int> data;
        private int endIndex;
        private int numElements;
        public TimeSpan sortTimeMid;
        public TimeSpan sortTimeFirst;

        public QuickSort()
        {

        }

        public void insertData(List<int> dataSet)
        {
            endIndex = dataSet.Count - 1;
            numElements = dataSet.Count;
            data = dataSet;
        }

        public int Partition(List<int> list, int left, int right)
        {
            int pivot = list[left];
            while (true)
            {
                while (list[left] < pivot)
                    left++;

                while (list[right] > pivot)
                    right--;

                if (left > right)
                {
                    int temp = list[right];
                    list[right] = list[left];
                    list[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public void sortFirst()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort(0, numElements - 1);
            stopwatch.Stop();
            sortTimeFirst = stopwatch.Elapsed;
        }

        public void sortMid()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort(numElements / 2, numElements - 1);
            stopwatch.Stop();
            sortTimeMid = stopwatch.Elapsed;
        }

        private void sort(int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(data, left, right);

                if (pivot > 1)
                    sort(left, pivot - 1);

                if (pivot + 1 < right)
                    sort(pivot + 1, right);
            }
        }
    }
}
