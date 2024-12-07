public class Ecosystem
{
    private List<LivingOrganism> organisms;

    public Ecosystem()
    {
        organisms = new List<LivingOrganism>();
    }

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void SimulateInteraction()
    {
        Console.WriteLine("Симуляція взаємодії організмів...");
        foreach (var organism in organisms)
        {
            organism.DisplayInfo();
        }

        Console.WriteLine("Взаємодія: Полювання, конкуренція, розмноження...");
        foreach (var organism in organisms.OfType<IReproducible>())
        {
            organism.Reproduce();
        }

        foreach (var predator in organisms.OfType<IPredator>())
        {
            var prey = organisms.FirstOrDefault(o => o is not IPredator && o != predator);
            if (prey != null)
                predator.Hunt(prey);
        }
    }
}
