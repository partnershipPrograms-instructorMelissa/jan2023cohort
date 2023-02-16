class Garden{
    public string Name;
    public int MaxPlants;
    private List<Plant> AllPlants;

    public Garden(string theGarden){
        Name = theGarden;
        MaxPlants = 20;
        AllPlants = new List<Plant>();
    }

    public void PrintGarden(){
        Console.WriteLine($"Plants in {Name} Garden:");
        foreach(Plant plant in AllPlants){
            Console.WriteLine($"\t{plant.Name}");
        }
    }

    public void AddPlant(Plant plant){
        AllPlants.Add(plant);
    }
}