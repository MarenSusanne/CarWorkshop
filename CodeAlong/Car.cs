namespace CodeAlong;

public class Car
{
    public string CarType { get; set; }
    public List<CarPart> _parts { get; set; }

    public Car(string carType)
    {
        CarType = carType;
        _parts = new List<CarPart>
        {
            new("Engine", false),
            new("Windshield", false),
            new("Wheel", false),
            new("Brakes", false),
        };
    }

    public Car()
    {

    }
    public void RndPart()
    {
        Random rand = new Random();
        var randomNumber = rand.Next(0, 4);
        _parts[randomNumber].IsBroken = true;
    }


}