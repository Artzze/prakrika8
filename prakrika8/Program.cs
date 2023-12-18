using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a natural number n: ");
        int n = int.Parse(Console.ReadLine());
        long sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i * i; // Instead of Math.Pow(i, 2) we multiply the number by itself
        }

        Console.WriteLine("The sum of the squares of numbers from 1 to {0} is {1}", n, sum);
    }
}
