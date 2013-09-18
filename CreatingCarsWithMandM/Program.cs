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
        AddingCars();  
        
    }

    static void AddingCars()
    {
        List<Car>  cars =  new List<Car>();
        bool creatingCars = true;

        //while (creatingCars == true)
        cars.Add(new Car("Sliten Volvo", 3, "kissgul"));
        cars.Add(new Car("Hyfsad ford", 4, "bajsbrun"));


        string derp = cars.ToString();
        for (int i = 0; i < cars.Count; i++) ;
        Console.WriteLine(cars.ToString());

        for (int i = 0; i < cars.Count; i++)
        {
            cars.RemoveAt(i);
        }

        Console.WriteLine(cars.ToString().ToString().ToString());

    }

    static void toScreen(string msg)
    {
        Console.Write("Your car has " + msg);
    }
}

