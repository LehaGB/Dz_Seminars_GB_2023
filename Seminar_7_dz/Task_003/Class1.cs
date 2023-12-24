using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_7_dz.Task_003
{
    class Class1
    {
        /// <summary>
        /// Задача 3:
        ///  Задайте произвольный массив.
        ///  Выведете его элементы, начиная с конца. 
        ///  Использовать рекурсию, не использовать циклы.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>


        Random rnd = new Random();
        static int arrNumber;

        static int i = 0;

        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            Console.Write("Введите размер массива: ");
            arrNumber = int.Parse(Console.ReadLine());
            int[] num = new int[arrNumber];
            i = arrNumber;

            Console.Write($"Массив чисел: ");
            cl.CreateArray(num, arrNumber);

            Console.WriteLine();

            Console.Write("Перевернутый массив: ");
            cl.PrintArray(num, 0, arrNumber - 1);

            Console.ReadLine();
        }
        void CreateArray(int[] num, int i)
        {
            if (i == 0)
            {
                return;
            }
            i--;
            num[i] = rnd.Next(1, 10);
            Console.Write(num[i] + " ");
            CreateArray(num, i);
        }
        void PrintArray(int[] num, int j, int i)
        {
            if (j < num.Length)
            {               
                int temp = num[j];
                num[j] = num[num.Length - 1 - i];
                num[num.Length - 1 - i] = temp;

                Console.Write(num[j] + " ");

                PrintArray(num, j + 1, i - 1);
            }
        }
    }
}
