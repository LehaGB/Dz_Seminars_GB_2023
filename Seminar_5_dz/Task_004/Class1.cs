using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_5_dz.Task_004
{
    class Class1
    {
        /// <summary>
        /// Задача 4: 
        /// Задайте двумерный массив из целых чисел.  
        /// Напишите программу, которая удалит строку и столбец,
        /// на пересечении которых расположен наименьший элемент массива.
        /// Под удалением понимается создание нового двумерного массива без строки и столбца.
        /// </summary>
        /// <param name="Алескей Щербаков"></param>


        static int[,] array = new int[3, 3]
        {
            { 2, 3, 1 },
            {4, 9, 2 },
            {3, 6, 8 }
        };
        static int[,] newArr = new int[2, 2];

        int min = array[0, 0];
        int minRow = 0;
        int minCol = 0;
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.PrintArray();
            cl.MinElementArray();
            cl.DeleteStringColumn();
            cl.PrintArray2();
            Console.ReadLine();
        }
        void PrintArray()
        {
            Console.WriteLine("Двумерный цулочисленный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        void MinElementArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                }
            }
        }
        void DeleteStringColumn()
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == minRow)
                {
                    continue;
                }
                for (int j = 0; j < 3; j++)
                {
                    if (j == minCol)
                    {
                        continue;
                    }
                    if (i < minRow && j < minCol)
                    {
                        newArr[i, j] = array[i, j];
                    }
                    else if (i < minRow && j > minCol)
                    {
                        newArr[i, j - 1] = array[i, j];
                    }
                    else if (i > minRow && j < minCol)
                    {
                        newArr[i - 1, j] = array[i, j];
                    }
                    else
                    {
                        newArr[i - 1, j - 1] = array[i, j];
                    }
                }
            }
        }
        void PrintArray2()
        {
            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(newArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
