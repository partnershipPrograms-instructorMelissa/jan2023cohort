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
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
Console.WriteLine($"================================");
Eruption chile = eruptions.FirstOrDefault(erupt => erupt.Location == "Chile");
Console.WriteLine($"First Eruption that is in Chile:\n{chile.ToString()}");
Console.WriteLine($"================================");

Console.WriteLine($"================================");
Eruption hawaiianIs = eruptions.FirstOrDefault(erupt => erupt.Location == "Hawaiian Is");
if(hawaiianIs != null){
    Console.WriteLine($"First Eruption that is in Hawaiian Is:\n{hawaiianIs.ToString()}");
}
else{
    Console.WriteLine($"No Hawaiian Is Eruption found");
}
Console.WriteLine($"================================");

Console.WriteLine($"================================");
Eruption newZealand = eruptions.Where(erupt => erupt.Location == "New Zealand")
                        .FirstOrDefault(erupt => erupt.Year > 1900);
Console.WriteLine($"First Eruption after 1900 that is in New Zealand:\n{newZealand.ToString()}");
Console.WriteLine($"================================");

Console.WriteLine($"================================");
IEnumerable<Eruption> over2000m = eruptions.Where(erupt => erupt.ElevationInMeters > 2000);
PrintEach(over2000m, "Over 2000m elevation:");
Console.WriteLine($"================================");

Console.WriteLine($"================================");
int maxEvaluation = eruptions.Max(erupt => erupt.ElevationInMeters);
Console.WriteLine($"Max Exaluation:\t{maxEvaluation}");
Console.WriteLine($"================================");

Console.WriteLine($"================================");
var maxEvaVol = eruptions.FirstOrDefault(erupt => erupt.ElevationInMeters == maxEvaluation);
Console.WriteLine($"Max Evaluation Volcano Name:\t{maxEvaVol.Volcano}");
Console.WriteLine($"================================");

Console.WriteLine($"================================");
IEnumerable<Eruption> alphVolcanos = eruptions.OrderBy(erupt => erupt.Volcano);
PrintEach(alphVolcanos, "Volcanos in Alphabetical order:");
Console.WriteLine($"================================");

Console.WriteLine($"================================");
IEnumerable<Eruption> before1000CE = eruptions.Where(erupt => erupt.Year < 1000)
                                                .OrderBy(erupt => erupt.Volcano);
PrintEach(before1000CE, "Before 1000CE Volcanos in Alphabetical order:");
Console.WriteLine($"================================");



// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}


