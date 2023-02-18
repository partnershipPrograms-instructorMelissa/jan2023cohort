class Bicycle : Vehicle
{
    public Bicycle(string name, string color) : base(name, color)
    {
        Name = name;
        NumberOfPassengers = 1;
        Color = color;
        Engine = false;
        MilesTraveled = 0;
    }
}