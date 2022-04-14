using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace XTask10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11. Создать массив на 5 элементов
            int[] x = new int[5];
            // 12. Заполнить массив с клавиатуры
            Console.WriteLine("Заполните массив из 5 чисел:");
            for (int i = 0; i < x.Length; i++)
                x[i] = int.Parse(Console.ReadLine());
            // 13.Вывести массив на консоль
            // for (int i = 0; i < x.Length; i++)

            // Console.WriteLine(x[i]);
            Console.WriteLine(string.Join(" ", x));
            Console.ReadKey();
            // 14. Заполнить массив случайными числами
            Random rnd = new Random();
            for (int i = 0; i < x.Length; i++)
                x[i] = rnd.Next();
            // 15.Найти первый четный элемент массива
            for (int i = 0; i < x.Length; i++)
                if(x[i] % 2 == 0)
                {
                    Console.WriteLine(x[i]);
                    Console.ReadKey();
                }
            // 16. Найти сумму нечетных элементов массива
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
                if (x[i] % 2 == 1)
                {
                    sum += x[i];
                    Console.WriteLine("Сумма нечетных элементов массива: " + sum);
                }
            // 17. Удалить последний элемент массива
            int[] mas = { 1, 2, 4, 5, 6, 7 };
            Console.WriteLine(string.Join("", mas));
            int min = 0; int max = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[max] < mas[i])
                    max = i;
                if (mas[min] > mas[i])
                    min = i;
            }
            int m = mas[min];
            mas[min] = mas[max];
            mas[max] = m;
            Console.WriteLine(string.Join("", mas));
            (mas[max], mas[min]) = (mas[min], mas[max]);
            int maxIndex = mas.ToList().IndexOf(mas.Max());
            int minIndex = mas.ToList().IndexOf(mas.Min());
            (mas[maxIndex], mas[minIndex]) = (mas[minIndex], mas[maxIndex]);
            Console.WriteLine(string.Join("", mas));
            Console.ReadKey();
            // 18. Поменять местами минимальный и максимальный элементы массива не используя методы и лямбда функции

        }
    }
}
