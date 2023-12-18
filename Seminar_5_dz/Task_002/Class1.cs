using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_5_dz.Task_002
{
    class Class1
    {
        /// <summary>
        /// Задача 2: 
        /// Задайте двумерный массив. Напишите программу
        ///  которая поменяет местами первую и последнюю строку массива.
        /// </summary>
        /// <param name="Алксей Щербаков"></param>

        static int[,] array = new int[5, 5];
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.CreateArray();
            cl.PrintArray();
            Console.WriteLine("======================");
            cl.ChangeArray();
            cl.PrintArray2();
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
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        void ChangeArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i > 0 && i < array.GetLength(1))
                    {
                        int temporary = array[i, j];
                        array[i, j] = array[i, j];
                        array[i, j] = temporary;
                    }
                    else
                    {
                        int temporary = array[i, j];
                        array[i, j] = array[(array.GetLength(1) - 1), j];
                        array[(array.GetLength(1) - 1), j] = temporary;
                    }
                }
            }
        }
        void PrintArray2()
        {
            Console.WriteLine("Замененный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
