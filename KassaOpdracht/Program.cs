using System;
using System.Collections.Generic;

namespace KassaOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new Dictionary<string, double>
            {
                { "Tosti", 6.50 },
                { "Uitsmijter", 7.95 },
                { "Koffie", 2.55 },
                { "Melk", 2.00 },
                { "Frisdrank", 2.50 }
            };

            double amountDue = 0.00;

            Console.WriteLine("Vul het aantal Tosti's in:");
            int amountOfTostis = int.Parse(Console.ReadLine());
            amountDue += prices["Tosti"] * amountOfTostis;

            Console.WriteLine("Vul het aantal Uitsmijters in:");
            int amountOfUitsmijters = int.Parse(Console.ReadLine());
            amountDue += prices["Uitsmijter"] * amountOfUitsmijters;

            Console.WriteLine("Vul het aantal koffie in:");
            int amountOfCoffee = int.Parse(Console.ReadLine());
            amountDue += prices["Koffie"] * amountOfCoffee;

            Console.WriteLine("Vul het aantal Melk in");
            int amountOfMilk = int.Parse(Console.ReadLine());
            amountDue += prices["Melk"] * amountOfMilk;

            Console.WriteLine("Vul het aantal Frisdrank in");
            int amountOfSoda = int.Parse(Console.ReadLine());
            amountDue += prices["Frisdrank"] * amountOfSoda;
            
            Console.WriteLine("Totaal prijs is {0} euro", amountDue);
         }
    }
}
