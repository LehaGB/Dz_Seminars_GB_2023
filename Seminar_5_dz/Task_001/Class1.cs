using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seminar_5_dz.Task_001
{
    class Class1
    {
        /// <summary>
        /// Задача 1: Напишите программу,
        ///  которая на вход принимает позиции элемента в двумерном массиве,
        ///  и возвращает значение этого элемента или же указание, что такого элемента нет.
        /// </summary>
        /// <param name="Алексей Щербаков">Задача №1</param>


        Random rnd1 = new Random();
        static int[,] arr = new int[5, 5];
        static int num;
        static int num2;
        int element;
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.CheckArray();
            Console.ReadLine();
        }
        void ArrayNumber()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=================================");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == arr[num, num2])
                    {
                        element = arr[num, num2];
                    }
                }
            }
            Console.WriteLine($"Значение элемента = {element}");
        }
        void CheckArray()
        {
            int count = 1;
            int milliseconds = 3000;
            Console.WriteLine("Дан целочисленный двумерный массив [5, 5], ждите..... ");
            while (count > 0)
            {
                Thread.Sleep(milliseconds);
                Console.Write("Введите номер строки: ");
                num = int.Parse(Console.ReadLine());
                Console.Write("Введите номер столбца: ");
                num2 = int.Parse(Console.ReadLine());
                if (num > arr.GetLength(0) || num2 > arr.GetLength(1))
                {
                    Console.WriteLine("\nТакого элемента нет, будте внимательны при вводе, поробуйте ешё раз\n");
                }
                else
                {
                    Console.WriteLine("\nДвумерный массив: ");
                    ArrayNumber();
                    break;
                }
            }
        }
    }
}
