using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_4_dz.Task_001
{
    class Class1
    {
        /// <summary>
        /// Задача 1: Напишите программу, 
        /// которая бесконечно запрашивает целые числа с консоли.
        /// Программа завершается при вводе символа ‘q’ 
        /// или при вводе числа, сумма цифр которого чётная.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>

        Random rnd = new Random();
        static int num;
        int sum;
        string str;
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.ConsoleInputNumber();
        }
        void ConsoleInputNumber()
        {
            string s = "q";
            while (true)
            {
                Console.Write("Введите число или букву q для выхода: ");
                str = Console.ReadLine();
                if (str == s)
                {
                    break;
                }
                num = 0;
                if (int.TryParse(str, out num))
                {
                    sum = 0;
                    while (num > 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("[STOP]");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не корректно.Пожалуйста введите целое число или 'q'");
                }
            }
        }
    }
}
