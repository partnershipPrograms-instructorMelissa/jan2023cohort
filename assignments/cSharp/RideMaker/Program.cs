// Vehicle tesla = new Vehicle("Tesla", 4, "white", false);
// Vehicle nissan = new Vehicle("Nissan", "tan");
// Vehicle suburban = new Vehicle("Suburban", 4, "blue", true);
// Vehicle suburu = new Vehicle("Suburu", "red");

// List<Vehicle> allVehicles = new List<Vehicle>();

// allVehicles.Add(tesla);
// allVehicles.Add(nissan);
// allVehicles.Add(suburban);
// allVehicles.Add(suburu);

// foreach(Vehicle vehicle in allVehicles)
// {
//     vehicle.ShowInfo();   
// }

// tesla.Travel(100);

Car ford = new Car("Ford", 2, "black", true, "gas");
Car nissan = new Car("Nissan", 4, "white", true, "gas");
Car tesla = new Car("Tesla", 2, "blue", false, "electric");
// ford.GiveFuel(50);

Horse sandy = new Horse("Sandy", 1, "black");
// sandy.GiveFuel(10);

Bicycle schwinn = new Bicycle("Schwinn", 1, "pink", false);

// List<Vehicle> vehicleList = new List<Vehicle>();
// vehicleList.Add(ford);
// vehicleList.Add(nissan);
// vehicleList.Add(tesla);

// foreach(Vehicle item in vehicleList)
// {
//     item.ShowInfo();
// }

List<INeedFuel> fuelList = new List<INeedFuel>();
fuelList.Add(tesla);
fuelList.Add(sandy);

foreach(INeedFuel item in fuelList)
{
    item.GiveFuel(10);
}