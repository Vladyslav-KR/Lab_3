public class Plant : LivingOrganism, IReproducible
{
    public int GrowthRate { get; set; }

    public Plant(int energy, int age, int size, int growthRate)
        : base(energy, age, size)
    {
        GrowthRate = growthRate;
    }

    public void Reproduce()
    {
        Console.WriteLine("Рослина розмножується насінням.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Швидкість росту: {GrowthRate}");
    }
}
