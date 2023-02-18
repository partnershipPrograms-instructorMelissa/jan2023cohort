class Car : Vehicle, INeedFuel
{
    public string FuelType {get; set;}
    public int FuelTotal {get; set;}
    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"You just recieved {Amount} gallons of {FuelType}, bringing your total {FuelType} to {FuelTotal}!");
        
    }
    public Car(string name, int numberOfPassengers, string color, bool engine, string fuelType) : base(name, numberOfPassengers, color, engine)
    {
        Name = name;
        NumberOfPassengers = numberOfPassengers;
        Color = color;
        Engine = engine;
        MilesTraveled = 0;
        FuelType = fuelType;
        FuelTotal = 10;
    }
    
}