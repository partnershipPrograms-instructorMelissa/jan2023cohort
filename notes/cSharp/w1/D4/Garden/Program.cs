Garden HBG = new Garden("Honey Bees Garden");
HBG.PrintGarden();

Plant newPlant = new Plant("Thyme", "Herb");
// HBG.AllPlants.Add(newPlant); // if not private
HBG.AddPlant(newPlant);

HBG.PrintGarden();

Garden JHG = new Garden("Juli's Herb Garden");
JHG.AddPlant(newPlant);
newPlant = new Plant("Rosemary", "Herb");
JHG.AddPlant(newPlant);

JHG.PrintGarden();