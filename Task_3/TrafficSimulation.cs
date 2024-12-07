public class TrafficSimulation : IDriveable
{
    private Vehicle _vehicle;
    private Road _road;

    public TrafficSimulation(Vehicle vehicle, Road road)
    {
        _vehicle = vehicle;
        _road = road;
    }

    public void Drive()
    {
        double maxSpeed = _road.CalculateMaxSpeed();
        if (_vehicle.Speed > maxSpeed)
        {
            _vehicle.Speed = maxSpeed;
            Console.WriteLine($"Швидкість знижена до {maxSpeed} км/год через високий рівень трафіку на дорозі.");
        }
        Console.WriteLine($"{_vehicle.Type} рухається зі швидкістю {_vehicle.Speed} км/год по дорозі.");
    }

    public void Stop()
    {
        Console.WriteLine($"{_vehicle.Type} зупиняється.");
        _vehicle.Speed = 0;
    }

    public void DisplayInfo()
    {
        _road.DisplayRoadInfo();
        _vehicle.DisplayVehicleInfo();
    }
}
