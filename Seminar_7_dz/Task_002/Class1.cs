using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_7_dz.Task_002
{
    class Class1
    {
        /// <summary>
        /// Задача 2:
        /// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
        /// Даны два неотрицательных числа m и n.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>

        static int m;
        static int n;
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            Console.Write("Введите первое число: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            n = int.Parse(Console.ReadLine());
            int result =  cl.Akkerman(m, n);
            Console.Write($"Функция Аккермана: {result}");
            Console.ReadLine();
        }
        int Akkerman(int m, int n)
        {
            if(m == 0)
            {
                return n + 1;
            }
            else if(n == 0)
            {
                return Akkerman(m - 1, 1);
            }
            else
            {
                return Akkerman(m - 1, Akkerman(m, n - 1));
            }
        }
    }
}
