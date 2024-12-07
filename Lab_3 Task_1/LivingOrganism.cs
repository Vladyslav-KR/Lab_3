public abstract class LivingOrganism
{
    public int Energy { get; set; }
    public int Age { get; set; }
    public int Size { get; set; }

    public LivingOrganism(int energy, int age, int size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Енергія: {Energy}, Вік: {Age}, Розмір: {Size}");
    }
}
