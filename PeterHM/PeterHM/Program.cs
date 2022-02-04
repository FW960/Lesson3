using System;

namespace PeterHM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Текст наоборот через For");
            Console.WriteLine();
            Console.WriteLine("Введите...что-нибудь?...");
            Console.WriteLine();
            string b = Console.ReadLine();

            for (int i = b.Length - 1; i < b.Length && i >= 0; i--)
            {
                Console.Write(b[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
