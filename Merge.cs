using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Merge
    {
        static public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void Sort(int[] numbers, int left, int right)

        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                Sort(numbers, left, mid);
                Sort(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Merge sort");
            Console.WriteLine("Running time" + " " + ts);
            Console.WriteLine("Memory usage:" + Process.GetCurrentProcess().WorkingSet64);
        }
    }
}
