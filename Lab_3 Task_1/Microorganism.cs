public class Microorganism : LivingOrganism, IReproducible
{
    public bool IsPathogenic { get; set; }

    public Microorganism(int energy, int age, int size, bool isPathogenic)
        : base(energy, age, size)
    {
        IsPathogenic = isPathogenic;
    }

    public void Reproduce()
    {
        Console.WriteLine("Мікроорганізм ділиться на два.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Патогенний: {IsPathogenic}");
    }
}