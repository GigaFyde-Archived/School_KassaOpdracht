using System;
using System.Collections.Generic;

namespace KassaOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new Dictionary<string, double>();
            prices.Add("Tosti", 6.50);
            prices.Add("Uitsmijter", 7.95);
            prices.Add("Koffie", 2.55);
            prices.Add("Melk", 2.00);
            prices.Add("Frisdrank", 2.50);

            double amountDue = 0.00;

            Console.WriteLine("Vul het aantal Tosti's in:");
            string s_amountOfTostis = Console.ReadLine();
            int i_amountOfTostis = int.Parse(s_amountOfTostis);
            amountDue += prices["Tosti"] * i_amountOfTostis;

            Console.WriteLine("Vul het aantal Uitsmijters in:");
            string s_amountOfUitsmijters = Console.ReadLine();
            int i_amountOfUitsmijters = int.Parse(s_amountOfUitsmijters);
            amountDue += prices["Uitsmijter"] * i_amountOfUitsmijters;

            Console.WriteLine("Vul het aantal koffie in:");
            string s_amountOfCoffee = Console.ReadLine();
            int i_amountOfCoffee = int.Parse(s_amountOfCoffee);
            amountDue += prices["Koffie"] * i_amountOfCoffee;

            Console.WriteLine("Vul het aantal Melk in");
            string s_amountOfMilk = Console.ReadLine();
            int i_amountOfMilk = int.Parse(s_amountOfMilk);
            amountDue += prices["Melk"] * i_amountOfMilk;

            Console.WriteLine("Vul het aantal Frisdrank in");
            string s_amountOfSoda = Console.ReadLine();
            int i_amountOfSoda = int.Parse(s_amountOfSoda);
            amountDue += prices["Frisdrank"] * i_amountOfSoda;
            
            Console.WriteLine("Totaal prijs is {0} euro", amountDue);
         }
    }
}
