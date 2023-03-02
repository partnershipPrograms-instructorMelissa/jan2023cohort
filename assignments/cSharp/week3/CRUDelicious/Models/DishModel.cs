#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models;
public class Dish
{
    [Key]
    public int DishId { get; set; }

    [Required(ErrorMessage = "Name is required!")]
    [MaxLength(45, ErrorMessage = "Name can not be more than 45 characters in length.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Chef name is Required")]
    [MaxLength(45, ErrorMessage = "Chef name can not be more than 45 characters in length.")]
    public string Chef { get; set; }

    [Required(ErrorMessage = "Taste is Required")]
    [Range(1, 5, ErrorMessage = "Tastiness must be between 1 and 5")]
    public int? Tastiness { get; set; }

    [Required(ErrorMessage = "Calories are Required")]
    [Range(1, int.MaxValue)]
    public int? Calories { get; set; }

    [Required(ErrorMessage = "Description is Required")]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}