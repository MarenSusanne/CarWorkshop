namespace CodeAlong;

public class Workshop
{
    public World World = new World();

    public void NewCarEnters()
    {
        Console.WriteLine();
        Console.WriteLine($"A {World.BreakCar().CarType} is entering the workshop");
    }
}