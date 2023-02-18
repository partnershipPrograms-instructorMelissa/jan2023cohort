class Car : Vehicle
{
    public Car(string name, int numberOfPassengers, string color, bool engine) : base(name, numberOfPassengers, color, engine)
    {
        Name = name;
        NumberOfPassengers = numberOfPassengers;
        Color = color;
        Engine = engine;
        MilesTraveled = 0;
    }
    
}