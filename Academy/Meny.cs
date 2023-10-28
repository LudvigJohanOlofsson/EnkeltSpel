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
            Console.WriteLine("Tryck på valfri knapp för att komma till menyn");
            Console.WriteLine("\n");
            Console.ReadLine();

            bool ärSpeletPå = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Spelare: {name}");
                Console.WriteLine($@"Vilket typ av spel vill du göra idag? Välj mellan valen nedanför:
---Spel---
A - Addition
S - Subtraction
M - Multiplication
D - Division

---Historik---
V - Se tidigare spel

---Avsluta---
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
                        
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            } while (ärSpeletPå);


        }
    }
}
