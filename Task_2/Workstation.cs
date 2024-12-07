public class Workstation : Computer, IConnectable
{
    public string Owner { get; set; } // Унікальна характеристика робочої станції

    public Workstation(string ipAddress, string os, double power, string owner)
        : base(ipAddress, os, power)
    {
        Owner = owner;
    }

    public void Connect(Computer device)
    {
        Console.WriteLine($"Робоча станція {IPAddress} підключилась до {device.IPAddress}.");
    }

    public void Disconnect(Computer device)
    {
        Console.WriteLine($"Робоча станція {IPAddress} відключилась від {device.IPAddress}.");
    }

    public void SendData(string data, Computer device)
    {
        Console.WriteLine($"Робоча станція {IPAddress} відправила дані \"{data}\" до {device.IPAddress}.");
    }

    public void ReceiveData(string data)
    {
        Console.WriteLine($"Робоча станція {IPAddress} отримала дані: \"{data}\".");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Owner: {Owner}");
    }
}
