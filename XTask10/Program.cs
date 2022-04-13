using System;

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

        }
    }
}
