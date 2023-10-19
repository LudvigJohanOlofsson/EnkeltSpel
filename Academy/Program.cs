using System.Net.Http.Headers;
using System.Threading.Tasks.Sources;

var date = DateTime.UtcNow;
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
    Console.WriteLine($@" Vilket typ av spel vill du göra idag? Välj mellan valen nedanför:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Avsluta");
    Console.WriteLine("-------------------------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
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
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
            break;
    }
}

//kod för Division/Multi/Subtract/Addition
void DivisionGame(string message)
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

        Console.WriteLine($"{firstNumber} / {secoundNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secoundNumber)
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


 
}

