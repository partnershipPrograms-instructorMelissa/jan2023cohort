List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

//Can use Class name to create variable or use var to create a variable when querying.  Should really use var when querying multiple data types at once.

// Eruption firstInChile = eruptions.FirstOrDefault(l => l.Location == "Chile");
// Console.WriteLine(firstInChile);

// var firstInHawaii = eruptions.FirstOrDefault(l => l.Location == "Hawaiian Is");
// if(firstInHawaii == null)
// {
//     Console.WriteLine("No Hawaiian Eruption Found");

// } else {
//     Console.WriteLine(firstInHawaii);   
// }

// var newZealand = eruptions.Where(l => l.Location == "New Zealand").FirstOrDefault(y => y.Year > 1900);
// Console.WriteLine(newZealand);

// IEnumerable<Eruption> allEruptions = eruptions.Where(e => e.ElevationInMeters > 2000);
// PrintEach(allEruptions);

IEnumerable<Eruption> listEruptions = eruptions.Where(v => v.Volcano.StartsWith("L"));
// PrintEach(listEruptions);
int countList = listEruptions.Where(v => v.Volcano.StartsWith("L")).Count();
// Console.WriteLine(countList);

// int maxElevation = eruptions.Max(e => e.ElevationInMeters);
// Console.WriteLine(maxElevation);

// Use the highest elevation variable to find a print the name of the Volcano with that elevation.
// var getName = eruptions.First(e => e.ElevationInMeters == maxElevation).Volcano;
// Console.WriteLine(getName);

// IEnumerable<Eruption> alpaVolcano = eruptions.OrderBy(v => v.Volcano);
// PrintEach(alpaVolcano);

// IEnumerable<Eruption> printAll = eruptions.Where(y => y.Year < 1000).OrderBy(v => v.Volcano);
// PrintEach(printAll);

// var printAllBonus = eruptions.Where(y => y.Year < 1000).OrderBy(v => v.Volcano).Select(n => n.Volcano);
// PrintEach(printAllBonus);

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

