using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models;
namespace Academy
{
    internal class medHjälpare
    {
        internal static List<Game> spel = new List<Game>();

        public static int[] GetDivisionNumbers()
        {
            var random = new Random(2);
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;


            return result;
        }

        internal static void LäggTillHistorik(int spelScore, string spelTyp)
        {
            spel.Add(new Game
            {
                Date = DateTime.Now,
                Score = spelScore,
                Typ = spelTyp

            });
                
        }

        internal static void HittaSpel()
        {
            Console.Clear();
            Console.WriteLine("Spel historik:");
            Console.WriteLine("----------------------------");
            foreach (var runda in spel)
            {
                Console.Write($"{runda.Date} - {runda.Typ}: {runda.Score} poäng.");
            }
            Console.WriteLine("----------------------------\n");
            Console.WriteLine("Tryck på valfri tangent för att gå till Meny");
            Console.ReadLine();

        }
    }
}
