abstract class Vehicle 
{
    public string Name;
    public int NumberOfPassengers;
    public string Color;
    public bool Engine;
    public int MilesTraveled;

    public Vehicle(string name, int numberOfPassengers, string color, bool engine)
    {
        Name = name;
        NumberOfPassengers = numberOfPassengers;
        Color = color;
        Engine = engine;
        MilesTraveled = 0;
    }

    public Vehicle(string name, string color)
    {
        Name = name;
        Color = color;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Your vehicle name is {Name}, it holds {NumberOfPassengers}, the color is {Color}, it has an Engine {Engine},and it has {MilesTraveled} miles");    
    }

    public void Travel(int distance)
    {
        distance += this.MilesTraveled;
        Console.WriteLine($"Your {Name} has now traveled {distance}");       
    }
    
}