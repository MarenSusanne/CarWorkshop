namespace CodeAlong;

public class World
{
    private List<Car> _cars;
    public Car CarToFix;
    public World()
    {
        _cars = new List<Car>()
        {
            new("Volvo XC90"),
            new("BMW 3serie"),
            new("Volkswagen Golf"),
            new("Porche Taycan"),
            new("Porsche 911 Turbo"),
            new("Thorton Merrimac MSL3"),
            new("Chevillon Emperor 620 Ragnar"),
            new("Mizutani Shion \"Coyote\""),
            new("Rayfield Caliburn"),
            new("Villefort Columbus V340-F Freight"),
        };
    }

    public Car GetRndCar()
    {
        Random rand = new Random();
        var randomNumber = rand.Next(0, 10);
        return _cars[randomNumber];
    }

    public Car BreakCar()
    {
        var rndCar = GetRndCar();
        rndCar.RndPart();
        CarToFix = rndCar;
        return rndCar;
    }
}