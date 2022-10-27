using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,5}", array[i]);
                if ((i % 2 == 0) && (array[i] >= 0) && (array[i] % 2 != 0))
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("количество нечетных положительных элементов, стоящих на четных местах равно {0}", count);
            Console.ReadKey();  
        }
    }
}
