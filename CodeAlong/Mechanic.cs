namespace CodeAlong;

public class Mechanic
{
    private World _world;

    public Mechanic(World world)
    {
        _world = world;
    }
    public void CheckCar()
    {
        var _car = _world.CarToFix;
        Console.WriteLine("The mechanic is checking the car");
        CheckPart(_car);
    }

    public void CheckPart(Car car)
    {
        foreach (var part in car._parts)
        {
            Console.WriteLine();
            Console.WriteLine($"Checking {part._partName}...");
            Thread.Sleep(1000);
            if (part.IsBroken)
            {
                Console.WriteLine($"{part._partName} is broken and needs fixing");
                Console.WriteLine($"Mechanic is fixing {part._partName}");
                FixCar(car);
                Thread.Sleep(1500);
                Console.WriteLine($"{part._partName} is fixed");
            }
            else
            {
                Console.WriteLine($"{part._partName} is in working condition");
            }
        }

        Console.WriteLine($"{car.CarType} is now fixed and can be picked up by owner");
    }

    public void FixCar(Car car)
    {
        foreach (var part in car._parts)
        {
            if (part.IsBroken)
            {
                part.IsBroken = false;
            }
        }
    }
}