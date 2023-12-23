using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_7_dz.Task_001
{
    class Class1
    {
        /// <summary>
        /// Задача 1:
        /// Задайте значения M и N. 
        /// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
        /// Использовать рекурсию, не использовать циклы.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>
        Random rnd = new Random();

        static int num;
        static int num2;
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            num = cl.rnd.Next(1, 10);
            num2 = cl.rnd.Next(10, 20);
            Console.Write($"Наше первое число: {num}\n");
            Console.Write($"Наше второе число: {num2}");
            Console.WriteLine("\n==============================");
            cl.PrintNumber(num, num2);
            Console.ReadLine();
        }
        void PrintNumber(int startEl, int endEl)
        {
            Console.Write(startEl + " ");
            if (startEl == endEl)
            {
                return;
            }
            startEl++;
            PrintNumber(startEl, endEl);
        }
    }
}
