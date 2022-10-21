using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        //array of the integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of comparasion
        private int mov_count = 0; // number of data movements

        //Number of elements in array
        private int n;

        void input()
        {
            while(true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray cah have maximum 20 elements \n");

            }
            Console.WriteLine("\n==================================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n==================================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i+1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
    }
}
