using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Meny
    {
        Spelmotor motor = new();
        internal void visaMeny(string name, DateTime date)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Hej! {name}. Det är just nu: {date}. Detta är ett matematik spel.");
            Console.WriteLine("\n");

            bool ärSpeletPå = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@" Vilket typ av spel vill du göra idag? Välj mellan valen nedanför:
                       V - Se tidigare spel
                       A - Addition
                       S - Subtraction
                       M - Multiplication
                       D - Division
                       Q - Avsluta");
                Console.WriteLine("-------------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        medHjälpare.HittaSpel();
                        break;
                    case "a":
                        motor.AdditionGame("Addition spel vald");
                        Console.Clear();
                        break;
                    case "s":
                        motor.SubtractionGame("Subtraction spel vald");
                        break;
                    case "m":
                        motor.MultiplicationGame("Multiplication spel vald");
                        break;
                    case "d":
                        motor.DivisionGame("Division spel vald");
                        break;
                    case "q":
                        Console.WriteLine($"Hejdå {name}");
                        ärSpeletPå = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Environment.Exit(1);
                        break;
                }

            } while (ärSpeletPå);


        }
    }
}
