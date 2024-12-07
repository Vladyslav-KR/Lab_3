using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Ecosystem ecosystem = new Ecosystem();

        var animal = new Animal(50, 3, 10, 15);
        var plant = new Plant(20, 1, 5, 7);
        var microbe = new Microorganism(5, 1, 1, true);

        ecosystem.AddOrganism(animal);
        ecosystem.AddOrganism(plant);
        ecosystem.AddOrganism(microbe);

        ecosystem.SimulateInteraction();
    }
}

