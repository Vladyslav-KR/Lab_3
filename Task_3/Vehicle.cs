public class Vehicle
{
    public string Type { get; set; }
    public double Speed { get; set; }
    public double Size { get; set; }

    public Vehicle(string type, double speed, double size)
    {
        Type = type;
        Speed = speed;
        Size = size;
    }

    public void DisplayVehicleInfo()
    {
        Console.WriteLine($"Транспортний засіб: {Type}, швидкість - {Speed} км/год, розмір - {Size} м.");
    }
}

