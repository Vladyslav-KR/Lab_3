public class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int Lanes { get; set; }
    public double TrafficLevel { get; set; }

    public Road(double length, double width, int lanes, double trafficLevel)
    {
        Length = length;
        Width = width;
        Lanes = lanes;
        TrafficLevel = trafficLevel;
    }

    public double CalculateMaxSpeed()
    {
        // Швидкість залежить від рівня трафіку, ширини дороги та кількості смуг
        return Math.Max(50, (100 - TrafficLevel) + (Lanes * 5));
    }

    public void DisplayRoadInfo()
    {
        Console.WriteLine($"Дорога: довжина - {Length} км, ширина - {Width} м, смуг - {Lanes}, рівень трафіку - {TrafficLevel}%");
    }
}

