using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_6_dz.Task_001
{
    class Class1
    {
        /// <summary>
        /// Задача 1: 
        ///  Задайте двумерный массив символов (тип char [,]).
        ///  Создать строку из символов этого массива.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>

        Random rnd = new Random();
        char[,] array = new char[2, 2];
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.GetCharFromArray();
            cl.PrintCharToString();
            Console.ReadLine();
        }
        void GetCharFromArray()
        {
            Console.WriteLine("Массив чаров: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToChar(rnd.Next('a', 'a' + 27));
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
        void PrintCharToString()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Вывод строки чаров из массива чаров: ");
            string str = string.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    str += array[i, j];
                }
            }
            Console.WriteLine(str);
        }
    }
}
