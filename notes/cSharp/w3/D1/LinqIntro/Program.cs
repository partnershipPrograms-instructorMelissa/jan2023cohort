// Lambda practice
List<int> numbers = new List<int>(){
    2, 5, 7, 90, 10, 6, 63, 42, 57, 92
};

List<int> numLess20 = numbers.Where(num => num < 20).ToList(); //loops through numbs and finds numbers[index] < 20 and adds to numLess20 list

Console.WriteLine(string.Join(", ", numLess20));
Console.WriteLine($"===============================");

List<string> names = new List<string>{
    "Melissa", "Juli", "Jarrell", "Katie", "Dana", "Muriel"
};

Console.WriteLine(string.Join(", ", names));
// to find max, change Min to Max
int minNameLength = names.Min(name => name.Length);
Console.WriteLine($"Min Length: {minNameLength} (kw)");
Console.WriteLine($"===============================");


List<Trainer> trainers = new List<Trainer>(){
    new Trainer(1, "Jane", "Doe", "janeDoe@email.com", 2),
    new Trainer(2, "Bob", "Ross", "BobRossRox@email.com", 8),
    new Trainer(3, "John", "Smith", "johnSmith@email.com", 1),
    new Trainer(3, "John", "Doe", "itraindogs@email.com", 5),
    new Trainer(5, "Cesar", "Milan", "IloveDogs@email.com", 10),
};

List<Dog> dogs = new List<Dog>(){
    new Dog(1, "Copper", "Longenberg", "beagle", 2),
    new Dog(2, "Mr. Tucker", "Longenberg", "Black Lab", 5),
    new Dog(3, "Lincoln", "Sepulveda", "Yorkie", 4),
    new Dog(4, "Beethoven", "Gross", "St. Bernard", 8),
};

Trainer oneTrainer = trainers.First(t => t.FirstName == "Jane");
Console.WriteLine($"{oneTrainer.printTrainer()}");
Console.WriteLine($"===============================");
// Trainer oneTrainer = trainers.First(t => t.FirstName == "Janbe"); // errors with no match
oneTrainer = trainers.FirstOrDefault(t => t.FirstName == "Janbe"); 
if(oneTrainer != null){
    Console.WriteLine($"{oneTrainer.printTrainer()}");
}
else{
    Console.WriteLine($"Trainer not found.");
}
Console.WriteLine($"===============================");
// order by ascending order
List<Trainer> trainersByExperience = trainers.OrderBy(trainer => trainer.Experience).ToList();

void PrintEachTrainer(IEnumerable<dynamic> items, string msg = ""){
    foreach(dynamic item in items){
        Console.WriteLine($"{item.printTrainer()}");
    }
}
PrintEachTrainer(trainersByExperience);