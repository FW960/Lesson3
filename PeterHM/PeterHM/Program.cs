using System;

namespace PeterHM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Текст наоборот через do while");
            Console.WriteLine();
            Console.WriteLine("Можете попробовать что-нибудь ввести...");
            Console.WriteLine();
            int i = 0;

            string hi = Console.ReadLine();

            i = hi.Length - 1;

            do
            {

                Console.Write(hi[i]);

                i--;
            } while (i <= hi.Length && i >= 0);
            Console.WriteLine();
            Console.WriteLine();
        }   
    }
}
