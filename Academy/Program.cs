using System.Net.Http.Headers;
using System.Threading.Tasks.Sources;

var date = DateTime.UtcNow;
string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name: ");
    var name = Console.ReadLine();
    return name;
}

void Menu(string? name)
{
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself.");
    Console.WriteLine("\n");
    Console.WriteLine($@" What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
    Console.WriteLine("-------------------------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            Console.Clear();
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
            break;
    }
}

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
            Console.WriteLine("Your answer was right");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was wrong");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
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
            Console.WriteLine("Your answer was right");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was wrong");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
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
            Console.WriteLine("Your answer was right");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was wrong");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
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
            Console.WriteLine("Your answer was correct");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was wrong");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");


    }


 
}

