class Bicycle : Vehicle
{
    public Bicycle(string name, int numberOfPassengers, string color, bool engine) : base(name, 1, color, engine)
    {
        Name = name;
        Color = color;
        Engine = engine;
        MilesTraveled = 0;
    }
}