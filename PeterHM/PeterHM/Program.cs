using System;

namespace PeterHM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Текст по диагонали");

            string[,] b = new string[4, 2] { { "1", " " }, { " ", "1" }, { "1", " " }, { " ", "1" } };

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}");
                }
                Console.WriteLine();
            }   Console.WriteLine();
        }
    }
}
