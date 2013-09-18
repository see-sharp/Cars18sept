using System;
class Car
{
    public string Name { get; set; }
    public string Wheels { get; set; }
    public string Color { get; set; }

    public Car(string name)
    {
        Name = name;
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

