using System;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

var date = DateTime.UtcNow;

var spel = new List<string>(); // lista obv

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Skriv in ditt namn: ");
    var name = Console.ReadLine();
    return name;
}

// Koden för Menyn
void Menu(string? name)
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
                HittaSpel();
                break;
            case "a":
                AdditionGame("Addition spel vald");
                Console.Clear();
                break;
            case "s":
                SubtractionGame("Subtraction spel vald");
                break;
            case "m":
                MultiplicationGame("Multiplication spel vald");
                break;
            case "d":
                DivisionGame("Division spel vald");
                break;
            case "q":
                Console.WriteLine("Hejdå");
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

void HittaSpel()
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

//kod för Division/Multi/Subtract/Addition
void DivisionGame(string message)
{
    var score = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(message);
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secoundNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secoundNumber}");
        var result = Console.ReadLine();

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

    LäggTillHistorik(score, "division");

}

void MultiplicationGame(string message)
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

    LäggTillHistorik(score, "Multiplication");
}

void SubtractionGame(string message)
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

        if(int.Parse(result) == firstNumber - secoundNumber)
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

    LäggTillHistorik(score, "Subtraction");
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();

    var score = 0;
    int firstNumber;
    int secoundNumber;

    for(int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secoundNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secoundNumber}");
        var result = Console.ReadLine();

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

    LäggTillHistorik(score, "Addition");
 
}

void LäggTillHistorik(int spelScore, string spelTyp)
{
    spel.Add($"{DateTime.Now} - {spelTyp}: {spelScore} poäng.\n");
}

int[] GetDivisionNumbers()
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