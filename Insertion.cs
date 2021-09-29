using System;
using System.Diagnostics;

namespace Sort
{
    class Insertion
    {

        public static int[] Sort(int[] inputArray)

        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }


            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Insertion sort");
            Console.WriteLine("Running time" + " " + ts);
            Console.WriteLine("Memory usage:" + Process.GetCurrentProcess().WorkingSet64);
            return inputArray;
        }
    }
}
