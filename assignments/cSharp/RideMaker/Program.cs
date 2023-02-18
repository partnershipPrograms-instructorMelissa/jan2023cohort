Vehicle tesla = new Vehicle("Tesla", 4, "white", false);
Vehicle nissan = new Vehicle("Nissan", "tan");
Vehicle suburban = new Vehicle("Suburban", 4, "blue", true);
Vehicle suburu = new Vehicle("Suburu", "red");

List<Vehicle> allVehicles = new List<Vehicle>();

allVehicles.Add(tesla);
allVehicles.Add(nissan);
allVehicles.Add(suburban);
allVehicles.Add(suburu);

// foreach(Vehicle vehicle in allVehicles)
// {
//     vehicle.ShowInfo();   
// }

tesla.Travel(100);