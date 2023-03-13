using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsDishes.Models;

public class Dish
{
    [Key]
    public int DishId { get; set; }

    [Required(ErrorMessage = "The name of the dish is required!")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Calories are Required")]
    [Range(1, int.MaxValue)]
    public int Calories { get; set; }

    [Required(ErrorMessage = "Taste is Required")]
    [Range(1, 5, ErrorMessage = "Tastiness must be between 1 and 5")]
    public int Tastiness { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public int ChefId { get; set; }
    public Chef? Creator { get; set; }
}