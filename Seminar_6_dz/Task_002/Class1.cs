using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_6_dz.Task_002
{
    class Class1
    {
        /// <summary>
        /// Задача 2:
        /// Задайте строку, содержащую латинские буквы в обоих регистрах.
        /// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>


        Random rnd = new Random();
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.CreateArrayChar();
            Console.ReadLine();
        }
        void CreateArrayChar()
        {
            Console.Write("Введите размер строки: ");
            string str = string.Empty;
            int numberOfElements = int.Parse(Console.ReadLine());
            char[] array = new char[numberOfElements];
            Console.Write("\nСтрока: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToChar(rnd.Next('A', 'a' + 26));
                Console.Write(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"\nПреобразованная строка в нижний регистр: {str.ToLower()}");
        }
    }
}
