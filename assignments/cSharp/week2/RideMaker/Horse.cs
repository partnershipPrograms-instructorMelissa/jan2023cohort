class Horse : Vehicle, INeedFuel
{
    public string FuelType { get; set; }
    public int FuelTotal { get; set; }
    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"You just recieved {Amount} bales of {FuelType}, giving you {FuelTotal} stacks of {FuelType}!");

    }
    
    public Horse(string name, int numberOfPassengers, string color) : base(name, numberOfPassengers, color, false)
    {
        Name = name;
        NumberOfPassengers = numberOfPassengers;
        Color = color;
        MilesTraveled = 0;
        FuelTotal = 10;
        FuelType = "Hay";
    }
}