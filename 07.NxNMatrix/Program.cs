﻿namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            GetMatrix(n);
        }

        private static void GetMatrix(int n)
        {
 
            for (int i = 0; i < n; i++)
            {
                
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"{n} ");
                }

                Console.WriteLine();

            }

        }
    }
}