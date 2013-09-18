using System;
class Car
{
    public string Name { get; set; }
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }

    public Car(string name, int numberOfwheels, string Color)
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
        Car SlitenVolvo = new Car("SlitenVolvo" //TODO M&M add arguments);       
    }

    static void toScreen(string msg )
    {
        Console.Write("Your car has " + msg);
    }
}

