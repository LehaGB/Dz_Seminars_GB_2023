using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_4_dz.Task_003
{
    class Class1
    {
        /// <summary>
        /// Задача 3: Напишите программу, 
        /// которая перевернёт одномерный массив
        /// (первый элемент станет последним, второй – предпоследним и т.д.)
        /// </summary>
        /// <param name="Алескей Щербаков"></param>

        Random rnd = new Random();
        int[] number = new int[10];
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Целочисленный массив рандомных чисел: ");
            class1.ReverseArrayNumber();
            Console.ReadLine();
        }
        void ReverseArrayNumber()
        {
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(1, 101);
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < number.Length / 2; i++)
            {
                int res = number[i];
                number[i] = number[number.Length - 1 - i];
                number[number.Length - 1 - i] = res;
            }
            Console.WriteLine();
            Console.WriteLine("Перевернутый массив: ");
            foreach (var item in number)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
