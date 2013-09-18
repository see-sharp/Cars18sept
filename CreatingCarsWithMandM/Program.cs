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
        Car SlitenVolvo = new Car("SlitenVolvo");       
    }

    static void toScreen( strign msg )
    {
        Console.Write("Your car has " + msg ")";
    }
}

