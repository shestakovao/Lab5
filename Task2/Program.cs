using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();           
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();    
            int maxElement = array[0];
            int minElement = array[0];
            foreach (int element in array)
            {
                maxElement = (maxElement < element) ? element : maxElement;
                minElement = (minElement > element) ? element : minElement;
            }
            Console.WriteLine("{0} + {1} = {2}", minElement, maxElement, minElement+maxElement);
            Console.ReadKey();
        }
    }
}
