using System;

namespace PeterHM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Телефонный справочник");
                Console.WriteLine();
            string[,] nameAndPhoneNumber = new string[5, 2] { { "Peter:", "+79362192890" }, { "Anton:", "+7940753403" }, { "Elena:", "+79523905192" }, { "Alexander:", "+79564744833" }, { "Ivan:", "     +7918769050" } };
            
            for (int i = 0; i < nameAndPhoneNumber.GetLength(0); i++)
            {
                for (int j = 0; j < nameAndPhoneNumber.GetLength(1); j++)
                {
                    Console.Write($"{nameAndPhoneNumber[i, j]} ");
                }
                Console.WriteLine();
            } Console.WriteLine();
        }
    }
}
