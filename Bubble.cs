using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Bubble

    {

        public static int[] Sort(int[] Inputarray)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int temp = 0;
            int n = Inputarray.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (Inputarray[j] > Inputarray[j + 1])
                    {
                        Inputarray[j] = Inputarray[j + 1];
                        Inputarray[j + 1] = temp;
                    }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Running time:" + " " + ts);
            Console.WriteLine("Memory usage:" + Process.GetCurrentProcess().WorkingSet64);
            Console.ResetColor();
            return Inputarray;
        }
    }
}
