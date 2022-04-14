using System;

namespace XTask16
{
    class Program
    {
        static void Main(string[] args)
        {
            // 19. Создать метод который выводит на консоль сумму всех элементов массива кроме последнего
            int[] ar = new int[5];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                ar[i] = rnd.Next(1, 10);
                sum += ar[i];
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();


            // 20. Создать метод который считает произведение 5 случайных числе
            int[] br = new int[5];
            Random bnd = new Random();
            int pr = 1;
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(1, 10);
                pr *= ar[i];
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(pr);
            Console.ReadLine();
        }
    }
}
