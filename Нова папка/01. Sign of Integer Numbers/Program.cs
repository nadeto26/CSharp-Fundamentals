﻿namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int num = int.Parse(Console.ReadLine());
                PrintNumber(num);
            }

            static void PrintNumber(int n)
            {
                if (n > 0)
                {
                    Console.WriteLine($"The number {n} is positive.");
                }
                else if (n < 0)
                {
                    Console.WriteLine($"The number {n} is negative. ");
                }
                else
                {
                    Console.WriteLine($"The number {n} is zero. ");
                }
            }
        }
    }
    
}