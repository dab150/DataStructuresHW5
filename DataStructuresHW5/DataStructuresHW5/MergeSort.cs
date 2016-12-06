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

        public void DoMerge(int left, int mid, int right)
        {
            int[] temp = new int[numElements];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (data[left] <= data[mid])
                    temp[tmp_pos++] = data[left++];
                else
                    temp[tmp_pos++] = data[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = data[left++];

            while (mid <= right)
                temp[tmp_pos++] = data[mid++];

            for (i = 0; i < num_elements; i++)
            {
                data[right] = temp[right];
                right--;
            }
        }

        public void sort()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort(0, endIndex);
            stopwatch.Stop();
            sortTime = stopwatch.Elapsed;
        }

        private void sort(int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                sort(left, mid);
                sort((mid + 1), right);

                DoMerge(left, (mid + 1), right);
            }
        }

    }
}
