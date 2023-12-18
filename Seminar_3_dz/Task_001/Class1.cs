using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3_dz.Task_001
{
    class Class1
    {
        /// <summary>
        /// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
        ///  Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
        /// </summary>
        /// <param name="Алексей Щербаков"></param>

        Random rnd = new Random();
        int result = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Значения которые лежат в отрезке [20,90].");
            Class1 class1 = new Class1();
            class1.Number();
            Console.ReadLine();
        }
        void Number()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
                if (arr[i] >= 20 && arr[i] <= 90)
                {
                    Console.Write($"{arr[i]}" + " ");
                    result++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Количество элементов по условию {result}");
        }
    }
}
