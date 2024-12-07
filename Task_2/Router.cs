public class Router : Computer, IConnectable
{
    public int MaxConnections { get; set; } // Унікальна характеристика маршрутизатора

    public Router(string ipAddress, string os, double power, int maxConnections)
        : base(ipAddress, os, power)
    {
        MaxConnections = maxConnections;
    }

    public void Connect(Computer device)
    {
        Console.WriteLine($"Маршрутизатор {IPAddress} підключив {device.IPAddress}.");
    }

    public void Disconnect(Computer device)
    {
        Console.WriteLine($"Маршрутизатор {IPAddress} відключив {device.IPAddress}.");
    }

    public void SendData(string data, Computer device)
    {
        Console.WriteLine($"Маршрутизатор {IPAddress} переслав дані \"{data}\" до {device.IPAddress}.");
    }

    public void ReceiveData(string data)
    {
        Console.WriteLine($"Маршрутизатор {IPAddress} отримав дані: \"{data}\".");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Max Connections: {MaxConnections}");
    }
}
