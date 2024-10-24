using System;

namespace MyFirstProgram
{
    public class Program
    {
        public static void Main()
        {
            int randomNumber = new Random().Next(1, 10);

            Powitanie();

            while (true)
            {
                Console.WriteLine("Podaj liczbe: ");
                int number = int.Parse(Console.ReadLine()!);

                if (number == randomNumber)
                {
                    Console.WriteLine("Brawo! Zgadles liczbe!");
                    break;
                }
                else
                {
                    if (number > randomNumber)
                    {
                        Console.WriteLine("Za duza liczba!");
                    }
                    else
                    {
                        Console.WriteLine("Za mala liczba!");
                    }
                }
            }
        }

        public static void Powitanie()
        {
            Console.WriteLine("Witaj w moim programie! Zgadnij liczbe od 1 do 10");
        }
    }
}
