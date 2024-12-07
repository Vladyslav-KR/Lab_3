public class Network
{
    private List<Computer> devices = new List<Computer>();

    public void AddDevice(Computer device)
    {
        devices.Add(device);
        Console.WriteLine($"Пристрій з IP {device.IPAddress} додано до мережі.");
    }

    public void RemoveDevice(Computer device)
    {
        devices.Remove(device);
        Console.WriteLine($"Пристрій з IP {device.IPAddress} видалено з мережі.");
    }

    public void DisplayDevices()
    {
        Console.WriteLine("Список пристроїв у мережі:");
        foreach (var device in devices)
        {
            device.DisplayInfo();
        }
    }
}

