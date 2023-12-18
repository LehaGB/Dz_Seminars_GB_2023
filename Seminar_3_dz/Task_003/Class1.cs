using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3_dz.Task_003
{
    class Class1
    {
        /// <summary>
        /// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
        /// Найдите разницу между максимальным и минимальным элементов массива.
        /// </summary>
        /// <param name="Алексей Щербаков"></param>

        Random rnd = new Random();
        double max;
        double min;

        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.Write("Введите размер массива: ");
            class1.DifferenceMaxMinNumber();
            Console.ReadLine();
        }
        void DifferenceMaxMinNumber()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[size];
            Console.WriteLine();
            Console.Write("Массив вещественных чисел: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(rnd.NextDouble());
                Console.Write("" + " " + "{0:0.##}", numbers[i]);
            }
            max = numbers[0];
            min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nМаксимальное вещественное число: {0:0.##}", max);
            Console.WriteLine("\nМинимальное вещественное число:{0:0.##}", min);
            double difference = max - min;
            Console.WriteLine("\nРазница между числами: {0:0.##}", difference);
        }
    }
}
