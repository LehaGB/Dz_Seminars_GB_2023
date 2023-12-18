using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_5_dz.Task_003
{
    class Class1
    {
        /// <summary>
        /// Задача 3: 
        ///  Задайте прямоугольный двумерный массив. 
        ///  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>

        static int[,] array = new int[3, 3];
        static int[] array2 = new int[array.GetLength(0)];
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.CreateArray();
            cl.PrintArray();
            cl.NumberMaxArray();
            cl.СomparisonNumber();
            Console.ReadLine();
        }
        void CreateArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                }
            }
        }
        void PrintArray()
        {
            Console.WriteLine("Прямоугольный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        void NumberMaxArray()
        {
            Console.WriteLine("Суммы элеметов: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i] += array[i, j];
                }
                Console.WriteLine(array2[i] + " ");
            }
        }
        void СomparisonNumber()
        {
            int min = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[min] > array2[i])
                {
                    min = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Наименьшая сумма эелемнтов находится по индексу: {min}");
        }
    }
}
