using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Spelmotor
    {
        internal void DivisionGame(string message)
        {
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(message);
                var divisionNumbers = medHjälpare.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secoundNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secoundNumber}");
                var result = Console.ReadLine();

                int answer;
                bool validInput = false;

                while (!validInput)
                {
                    if (int.TryParse(result, out answer))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt format. Försök igen.");
                        result = Console.ReadLine();
                    }
                }

                if (int.Parse(result) == firstNumber * secoundNumber)
                {
                    Console.WriteLine("Ditt svar var rätt");
                    score++;
                }
                else
                {
                    Console.WriteLine("Ditt svar var fel");
                }

                if (i == 4) Console.WriteLine($"Game over. Du fick totalt {score} mycket poäng");
                Console.ReadLine();
            }

            medHjälpare.LäggTillHistorik(score, "division");

        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secoundNumber;

            for (int i = 0; i < 4; i++)
            {
                firstNumber = random.Next(1, 9);
                secoundNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secoundNumber}");
                var result = Console.ReadLine();

                int answer;
                bool validInput = false;

                while (!validInput)
                {
                    if (int.TryParse(result, out answer))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt format. Försök igen.");
                        result = Console.ReadLine();
                    }
                }

                if (int.Parse(result) == firstNumber * secoundNumber)
                {
                    Console.WriteLine("Ditt svar var rätt");
                    score++;
                }
                else
                {
                    Console.WriteLine("Ditt svar var fel");
                }

                if (i == 4) Console.WriteLine($"Game over. Du fick totalt {score} mycket poäng");
                Console.ReadLine();
            }

            medHjälpare.LäggTillHistorik(score, "Multiplication");
        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secoundNumber;

            for (int i = 0; i < 4; i++)
            {
                firstNumber = random.Next(1, 9);
                secoundNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secoundNumber}");
                var result = Console.ReadLine();

                int answer;
                bool validInput = false;

                while (!validInput)
                {
                    if (int.TryParse(result, out answer))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt format. Försök igen.");
                        result = Console.ReadLine();
                    }
                }

                if (int.Parse(result) == firstNumber - secoundNumber)
                {
                    Console.WriteLine("Ditt svar var rätt");
                    score++;
                }
                else
                {
                    Console.WriteLine("Ditt svar var fel");
                }

                if (i == 4) Console.WriteLine($"Game over. Du fick totalt {score} mycket poäng");
                Console.ReadLine();
            }

            medHjälpare.LäggTillHistorik(score, "Subtraction");
        }

        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);
            var random = new Random();

            var score = 0;
            int firstNumber;
            int secoundNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secoundNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secoundNumber}");
                var result = Console.ReadLine();

                int answer;
                bool validInput = false;

                while (!validInput)
                {
                    if (int.TryParse(result, out answer))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt format. Försök igen.");
                        result = Console.ReadLine();
                    }
                }
                if (int.Parse(result) == firstNumber + secoundNumber)
                {
                    Console.WriteLine("Ditt svar var rätt");
                    score++;
                }
                else
                {
                    Console.WriteLine("Ditt svar var fel");
                }

                if (i == 4) Console.WriteLine($"Game over. Du fick totalt {score} mycket poäng");
                Console.ReadLine();

            }

            medHjälpare.LäggTillHistorik(score, "Addition");

        }

    }
}
