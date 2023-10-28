namespace Academy.Models
{
    internal class Game
    {
        
        public DateTime Date { get; set; }
        public int Score { get; set; }  
        public SpelTyp Typ { get; set; }
    }
}

internal enum SpelTyp
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
}