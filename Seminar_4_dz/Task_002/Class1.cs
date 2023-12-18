using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_4_dz.Task_002
{
    class Class1
    {
        /// <summary>
        /// Задача 2: Задайте массив заполненный случайными трёхзначными числами 
        /// Напишите программу, которая покажет количество чётных чисел в массиве.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>

        Random rnd = new Random();
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Массив целых чисел: ");
            class1.ArraySortNumber();
            Console.ReadLine();
        }
        void ArraySortNumber()
        {
            int[] arr = new int[10];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100, 1000);
                Console.Write(arr[i] + " ");
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.Write($"\nКоличество чётных чисел: {count}");
        }
    }
}
