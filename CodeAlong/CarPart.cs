namespace CodeAlong;

public class CarPart
{
    public string _partName { get; set; }
    public bool IsBroken { get; set; }

    public CarPart(string partName, bool isBroken)
    {
        _partName = partName;
        IsBroken = isBroken;
    }
}