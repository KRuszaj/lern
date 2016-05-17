using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();

            Random random = new Random();

            Console.WriteLine("Original elements:");
            for (int i = 0; i < 10; i++)
            {
                unsorted.Add(random.Next(0, 100));
                Console.Write(unsorted[i] + " ");
            }
            Console.WriteLine();

            var sorted = new Sorter().MergeSort(unsorted);

            Console.WriteLine("Sorted elements: ");
            foreach (int x in sorted)
            {
                Console.Write(x + " ");
            }
            Console.ReadKey();
        }


      
    }
}
