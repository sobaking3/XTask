using System;

namespace XTasks6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Найти остаток от деления 12 на 4 и вывести на консоль
            int x = 12;
            int y = 4;
            Console.WriteLine(x % y);
            // 7. Принять с консоли 3 числа и перемножить их, результат вывести на консоль
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Произведение трех чисел равно: " + a * b * c);
            // 8. Принять с консоли 2 числа и найти большее из них
            Console.Write("Введите первое число: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int g = int.Parse(Console.ReadLine());
            if (h > g)
            {
                Console.WriteLine($"Число {h} больше {g}");
            }
            else
            {
                Console.WriteLine($"Число {g} больше {h}");
            }
            // 9. Принять с консоли 2 числа если оба четные то сложить их иначе перемножить, ответ вывести на консоль
            Console.Write("Введите первое число: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int j = int.Parse(Console.ReadLine());
            if((i % 2 + j % 2) == 0)
            {
                Console.WriteLine($"Числа четные, складываем и получаем: {i + j}");
            }
            else
            {
                Console.WriteLine($"Числа не четные, перемножаем и получаем: {i * j}");
            }
            // 10. Бесконечно выводить 1 в консоль
            while(true)
            {
                Console.WriteLine(1);
            }
        }
    }
}
