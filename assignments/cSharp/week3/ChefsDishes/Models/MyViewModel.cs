#pragma warning disable CS8618
namespace ChefsDishes.Models;

public class MyViewModel
{
    public Chef Chef { get; set; }
    public List<Dish> CreatorDish { get; set; }
    public List<Chef> AllChefs { get; set; }
    public Dish Dish { get; set; }

}