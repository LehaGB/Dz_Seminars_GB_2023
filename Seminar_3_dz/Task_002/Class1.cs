using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3_dz.Task_002
{
    class Class1
    {
        /// <summary>
        /// Задача 2: Задайте массив на 10 целых чисел.
        /// Напишите программу, которая определяет количество чётных чисел в массиве.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>


        Random rnd = new Random();
        int count = 0;
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.Write("Массив чисел: ");

            class1.EvenNumbers();
            Console.ReadLine();
        }
        void EvenNumbers()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 11);
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"\nКоличество чётных чисел в массиве: {count}");
        }
    }
}
