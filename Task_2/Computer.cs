public abstract class Computer
{
    public string IPAddress { get; set; }
    public string OS { get; set; }
    public double Power { get; set; }

    protected Computer(string ipAddress, string os, double power)
    {
        IPAddress = ipAddress;
        OS = os;
        Power = power;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"IP: {IPAddress}, OS: {OS}, Power: {Power} GHz");
    }
}
