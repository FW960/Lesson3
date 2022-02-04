using System;

namespace PeterHM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] b = new string[10, 10];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = "O";

                    
                }
                   
            }
            Console.WriteLine("Морской бой");
            Console.WriteLine();
            b[1, 1] = "X";
            b[2, 1] = "X";
            b[2, 4] = "X";
            b[2, 7] = "X";
            b[2, 8] = "X";
            b[2, 9] = "X";
            b[3, 3] = "X";
            b[3, 4] = "X";
            b[3, 5] = "X";
            b[3, 8] = "X";
            b[4, 9] = "X";
            b[5, 5] = "X";
            b[6, 2] = "X";
            b[6, 3] = "X";
            b[6, 5] = "X";
            b[7, 5] = "X";
            b[7, 7] = "X";
            b[8, 1] = "X";
            b[8, 5] = "X";
            b[9, 8] = "X";

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine();
            } Console.WriteLine();


        }
    }
}
