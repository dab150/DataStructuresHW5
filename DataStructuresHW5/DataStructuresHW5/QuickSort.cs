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

        private void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public int Partition(ref List<int> list, int left, int right)
        {
            /*
            long pivot = list[left];
            while (true)
            {
                while (list[left] < pivot)
                    left++;

                while (list[right] > pivot)
                    right--;

                if (list[right] == pivot && list[left] == pivot)
                    left++;

                if (left < right)
                {
                    int temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;
                }
                else
                {
                    return right;
                }
            }*/

            int x = list[right];
            int i = (left - 1);

            for (int j = left; j <= right - 1; ++j)
            {
                if (list[j] <= x)
                {
                    ++i;
                    Swap(list[i], list[j]);
                }
            }

            Swap(list[i + 1], list[right]);

            return (i + 1);

        }

        public void sortFirst()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort(data, 0, numElements - 1);
            stopwatch.Stop();
            sortTimeFirst = stopwatch.Elapsed;
        }

        public void sortMid()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort(data, numElements / 2, numElements - 1);
            stopwatch.Stop();
            sortTimeMid = stopwatch.Elapsed;
        }

        private void sort(List<int> list, int left, int right)
        {
            int top = -1;
            int startIndex = 0;
            int lastIndex = numElements - 1;
            int[] stack = new int[numElements];

            stack[++top] = 0;
            stack[++top] = lastIndex;

            while (top >= 0)
            {
                lastIndex = stack[top--];
                startIndex = stack[top--];

                int p = Partition(ref data, startIndex, lastIndex);

                if (p - 1 > startIndex)
                {
                    stack[++top] = startIndex;
                    stack[++top] = p - 1;
                }

                if (p + 1 < lastIndex)
                {
                    stack[++top] = p + 1;
                    stack[++top] = lastIndex;
                }
            }
        }
    }
}
