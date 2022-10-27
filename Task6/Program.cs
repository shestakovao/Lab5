using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            bool conditionMagicSquad = true;
            Console.WriteLine("Вводите элементы массива");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            int sum = 0;
            int currentSum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i, 0];//сумма для сравнения
            }

            for (int i = 0; i < n; i++)//суммы по строкам
            {
                currentSum = 0;
                for (int j = 0; j < n; j++)
                {
                    currentSum += array[i, j];
                }
                if (sum != currentSum)
                {
                    conditionMagicSquad = false;
                }
            }

            if (conditionMagicSquad)
            {
                for (int j = 0; j < n; j++)//суммы по столбцам
                {
                    currentSum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        currentSum += array[i, j];
                    }
                    if (sum != currentSum)
                    {
                        conditionMagicSquad = false;
                    }
                }
            }

            if (conditionMagicSquad)
            { 
                currentSum = 0;
                for (int i = 0; i < n; i++)//сумма по главной диагонале
                {
                   
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j) 
                        { 
                            currentSum += array[i, j]; 
                        }
                    }
                }

                if (sum != currentSum)
                {
                    conditionMagicSquad = false;
                }

            }

            if (conditionMagicSquad)
            {
                currentSum = 0;
                for (int i = 0; i < n; i++)//сумма по побочной диагонале
                {

                    for (int j = 0; j < n; j++)
                    {
                        if (i + j == n-1)
                        {
                            currentSum += array[i, j];
                        }
                    }
                }

                if (sum != currentSum)
                {
                    conditionMagicSquad = false;
                }

            }

            if (conditionMagicSquad)
            {
                Console.WriteLine("матрица является магическим квадратом");
            }
            else
            {
                Console.WriteLine("матрица НЕ является магическим квадратом");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
