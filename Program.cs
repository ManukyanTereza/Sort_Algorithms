using System;

namespace Sort
{
    class Program
    {
        public static void outputarray(int[] a)
        {
            Console.WriteLine("This is a sorted array");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i] + "  ");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the size of an array that you want to sort");
            int n = Int32.Parse(Console.ReadLine());
            int[] a = new int[n];

            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = rnd.Next(35, 150);
            Console.WriteLine("Select which algorithm you want to perform");
            Console.WriteLine("1.Insertion sort");
            Console.WriteLine("2.Bubble sort");
            Console.WriteLine("3.Quick sort");
            Console.WriteLine("4.Heap sort");
            Console.WriteLine("5.Merge sort");
            Console.WriteLine("6.All");

            int number;
            Console.WriteLine("Enter the number");
            number = Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        Insertion.Sort(a);
                        outputarray(a);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Bubble sort");
                        Bubble.Sort(a);
                        outputarray(a);
                        break;
                    }
                case 3:
                    {

                        Quick.Sort(a, 0, n - 1);
                        outputarray(a);
                        break;
                    }
                case 4:
                    {
                        Heap.Sort(a, n);
                        outputarray(a);
                        break;
                    }
                case 5:
                    {

                        Merge.Sort(a, 0, n - 1);
                        outputarray(a);
                        break;
                    }
                case 6:
                    Insertion.Sort(a);
                    outputarray(a);
                    Console.WriteLine("This is Bubble sort");
                    Bubble.Sort(a);
                    outputarray(a);
                    Quick.Sort(a, 0, n - 1);
                    outputarray(a);
                    Heap.Sort(a, n);
                    outputarray(a);
                    Merge.Sort(a, 0, n - 1);
                    outputarray(a);
                    break;
            }
        }
    }
}
