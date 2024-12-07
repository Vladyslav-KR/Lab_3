using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Встановлення кодування для кирилиці
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // Створення об'єктів дороги та транспортного засобу
        Road road = new Road(50, 20, 3, 30); // Дорога довжиною 50 км, ширина 20 м, 3 смуги, 30% трафіку
        Vehicle vehicle = new Vehicle("Автомобіль", 90, 4.5); // Транспортний засіб типу "Автомобіль"

        // Імітація руху
        TrafficSimulation simulation = new TrafficSimulation(vehicle, road);

        // Виведення інформації
        simulation.DisplayInfo();

        // Рух транспорту
        simulation.Drive();
        simulation.Stop();
    }
}