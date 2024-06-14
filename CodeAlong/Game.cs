namespace CodeAlong;

public class Game
{
    private Workshop _workshop = new Workshop();
    private Mechanic _mechanic;

    public Game()
    {
        _mechanic = new Mechanic(_workshop.World);
    }
    public void StartGame()
    {
        Console.WriteLine("Ready to open the workshop?");
        Console.WriteLine("Yes/No");
        var startGame = Console.ReadLine();
        if (startGame.ToUpper() == "YES")
        {
            RunGame();
        }
        else
        {
            Console.WriteLine("Oh, I'm sorry");
            Environment.Exit(0);
        }
    }

    public void RunGame()
    {
            _workshop.NewCarEnters();
            _mechanic.CheckCar();
    }
}