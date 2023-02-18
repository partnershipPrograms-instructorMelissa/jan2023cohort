class Horse : Vehicle
{
    public Horse(string name, int numberOfPassengers, string color) : base(name, numberOfPassengers, color)
    {
        Name = name;
        NumberOfPassengers = numberOfPassengers;
        Color = color;
        Engine = false;
        MilesTraveled = 0;
    }
}