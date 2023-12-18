using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3_dz.Task_004
{
    class Class1
    {
        /// <summary>
        /// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000.
        /// Создайте массив, состоящий из цифр этого числа. 
        /// Старший разряд числа должен располагаться на 0-м индексе массива,
        /// младший – на последнем. Размер массива должен быть равен количеству цифр.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>
        

        Random rnd = new Random();

        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.Write("Введите число: ");
            class1.ArrayNumber();
            Console.ReadLine();
        }
        void ArrayNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n;
            int b = 0;

            Console.WriteLine();
            if (n < 10)
            {
                Console.WriteLine(n);
                return;
            }
            while (a % 10 > 0)
            {
                a /= 10;
                b++;
            }
            int[] arr1 = new int[b];
            int[] arr2 = new int[b];
            if (n > 10 && n < 100001)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr1[i] = n % 10;
                    n /= 10;
                    if (b > 0)
                    {
                        arr2[i] = arr1[arr1.Length - 1 - i];
                        Console.Write(arr2[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.Write("Число не подходит");
            }
            Console.WriteLine();
        }
    }
}
