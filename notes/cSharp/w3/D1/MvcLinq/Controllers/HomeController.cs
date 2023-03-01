using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcLinq.Models;

namespace MvcLinq.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

        Random rand = new Random();
        int i = rand.Next(dogs.Count);
        string choice = dogs[i].Name;
        Console.WriteLine($"Random dog: {choice} (kw)");
        Dog? oneDog = dogs.FirstOrDefault(dog => dog.Name == choice);
        if(oneDog != null){
            Console.WriteLine($"oneDog: {oneDog.printDog()} (kw)");
            // string theDog = oneDog.printDog();
            ViewBag.theDog = oneDog.printDog();
            return View();
        }
        else{
            Console.WriteLine($"Dog not in list.");
            return View();
        }
    }

    [HttpGet("orderDogs")]
    public IActionResult OrderDogs(){
        List<Dog> dogs = new List<Dog>(){
            new Dog(1, "Copper", "Longenberg", "beagle", 2),
            new Dog(2, "Mr. Tucker", "Longenberg", "Black Lab", 1),
            new Dog(3, "Lincoln", "Sepulveda", "Yorkie", 4),
            new Dog(4, "Beethoven", "Gross", "St. Bernard", 8),
        };

        // family name Longenberg and order by age
        // where Family == "Longenberg"
        // OrderBy(age)
        // var filteredBy = dogs
        //     .Where(dog => dog.Family == "Longenberg")
        //     .Select(dog => dog.Age)
        //     .OrderBy(age => age)
        //     .ToList();
        List<Dog> filterDogs = dogs.OrderBy(dog => dog.Family).ToList();

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
