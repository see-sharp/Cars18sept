using System;
//using System.Object;
using System.Collections.Generic;

class Car
{
    public string Name { get; set; }
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }

    public Car(string name, int numberOfwheels, string color)
    {
        Name = name;
        NumberOfWheels = numberOfwheels;
        Color = color;
    }
}


class Program
{
    static void Main()
    {
        
    }

    static void AddingCars()
    {
        List<Car>  cars =  new List<Car>();
        bool creatingCars = true;

        //while (creatingCars == true)
        cars.Add(new Car("sliten Volvo", 3, "kissgul"));
        cars.Add(new Car("krockad Fiat", 4, "rostrosa"));

        string derp = cars.ToString();

        toScreen();

        for (int i = 0; i < cars.Count; i++)
        Console.WriteLine("Din bil är " + cars[i].Color + ". Den har " + cars[i].NumberOfWheels + " hjul och är av modellen " + cars[i].Name + ".");

        for (int i = 0; i < cars.Count; i++)
        {
            cars.RemoveAt(i);
        }

    }

    static void toScreen()
    {

        Console.WriteLine("Press any key to continue to your cars");
        Console.ReadKey();
        Environment.Exit(0);
    }
}

