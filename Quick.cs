using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Quick
    {
        static public int Partition(int[] arr, int left, int right)
        {

            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }

        }
        static public void Sort(int[] arr, int left, int right)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Sort(arr, pivot + 1, right);
                }
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Quick sort");
            Console.WriteLine("Running time:" + " " + ts);
            Console.WriteLine("Memory usage:" + Process.GetCurrentProcess().WorkingSet64);
        }
    }
}
