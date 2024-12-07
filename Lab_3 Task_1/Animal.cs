public class Animal : LivingOrganism, IReproducible, IPredator
{
    public int Speed { get; set; }

    public Animal(int energy, int age, int size, int speed)
        : base(energy, age, size)
    {
        Speed = speed;
    }

    public void Reproduce()
    {
        Console.WriteLine("Тварина розмножується.");
    }

    public void Hunt(LivingOrganism prey)
    {
        if (prey != null && Energy > 10)
        {
            Console.WriteLine("Тварина полює.");
            Energy += prey.Size / 2;  // Полювання додає енергії.
        }
        else
        {
            Console.WriteLine("Полювання не вдалося.");
        }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Швидкість: {Speed}");
    }
}