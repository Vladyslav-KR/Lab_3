public class Server : Computer, IConnectable
{
    public int StorageCapacity { get; set; } // Унікальна характеристика сервера

    public Server(string ipAddress, string os, double power, int storageCapacity)
        : base(ipAddress, os, power)
    {
        StorageCapacity = storageCapacity;
    }

    public void Connect(Computer device)
    {
        Console.WriteLine($"Сервер {IPAddress} підключився до {device.IPAddress}.");
    }

    public void Disconnect(Computer device)
    {
        Console.WriteLine($"Сервер {IPAddress} відключився від {device.IPAddress}.");
    }

    public void SendData(string data, Computer device)
    {
        Console.WriteLine($"Сервер {IPAddress} відправив дані \"{data}\" до {device.IPAddress}.");
    }

    public void ReceiveData(string data)
    {
        Console.WriteLine($"Сервер {IPAddress} отримав дані: \"{data}\".");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Storage: {StorageCapacity} GB");
    }
}
