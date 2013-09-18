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
        List<object>  cars =  new List<object>();
        bool creatingCars = true;

        //while (creatingCars == true)
        cars.Add(new Car("Sliten Volvo", 3, "kissgul"));

    }

    static void toScreen(string msg )
    {
        Console.Write("Your car has " + msg);
    }
}

