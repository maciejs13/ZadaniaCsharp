public interface IWarrior
{

}

public interface IMag
{

}

public interface IHealer
{

}

public class Player
{
    public string Name { get; set; }
    public int Position { get; set; }
    public int Score { get; set; }

    public Player(string name)
    {
        Name = name;
        Position = 0;
        Score = 0;
    }
    public void Move()
    {
        
    }

    public void UpdateScore()
    {
        
    }
    
}

public class Board
{
    public int BoardSize;

    public void RandomGift()
    {

        string[] gifts = {""};

    }
}

public class Game
{

    public void StartGame()
    {
        
    }

    public void Round()
    {
        
    }

    public void GiftCheck()
    {
        
    }

    public void DisplayScores()
    {
        
    }
    
}

internal class Program
{
    public static void Main(string[] args)
    {
        
    }
}