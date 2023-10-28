using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class medHjälpare
    {
        static List<string> spel = new();
        internal static void HittaSpel()
        {
            Console.Clear();
            Console.WriteLine("Spel historik:");
            Console.WriteLine("----------------------------");
            foreach (var runda in spel)
            {
                Console.Write(runda);
            }
            Console.WriteLine("----------------------------\n");
            Console.WriteLine("Tryck på valfri tangent för att gå till Meny");
            Console.ReadLine();

        }


        internal static void LäggTillHistorik(int spelScore, string spelTyp)
        {
            spel.Add($"{DateTime.Now} - {spelTyp}: {spelScore} poäng.\n");
        }

        internal static int[] GetDivisionNumbers()
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
    }
}
