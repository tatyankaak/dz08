using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод числа N
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Вывод всех четных чисел от 1 до N
        Console.WriteLine("Четные числа от 1 до N:");
        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}