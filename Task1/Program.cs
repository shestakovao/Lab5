using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            Console.WriteLine("Введите массив состоящий из {0} элементов", n);
            double S = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];
            }
            Console.WriteLine("Среднеарифметическое значение {0,8:f2}" ,S / n);
            Console.ReadKey();  
        }
    }
}
