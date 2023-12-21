using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_6_dz.Task_004
{
    class Class1
    {
        /// <summary>
        /// Задача 4*:
        /// Задайте строку, состоящую из слов, разделенных пробелами. 
        /// Сформировать строку, в которой слова расположены в обратном порядке. 
        /// В полученной строке слова должны быть также разделены пробелами.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>
        


        static void Main(string[] args)
        {
            string input = "Hello my World";
            Class1 cl = new Class1();
            Console.WriteLine($"Входящая строка: {input}\n");
            
            string result = cl.StringReverse(input);

            Console.WriteLine($"Перевернутая строка: {result}");
            Console.ReadLine();
        }
        string StringReverse(string str)
        {
            string[] reverseStr = str.Split(' ');
            Array.Reverse(reverseStr);
            return string.Join(" ", reverseStr);
        }
    }
}
