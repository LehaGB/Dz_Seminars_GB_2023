using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_6_dz.Task_003
{
    class Class1
    {
        /// <summary>
        /// Задача 3:
        /// Задайте произвольную строку.
        /// Выясните, является ли она палиндромом.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>
        

        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.StringPalindrome();
            Console.ReadLine();
        }
        void StringPalindrome()
        {
            string result = string.Empty;
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            if (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2])
            {
                Console.WriteLine("Да, ваша строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Нет, ваша строка не является палиндромом");

            }
        }
    }
}
