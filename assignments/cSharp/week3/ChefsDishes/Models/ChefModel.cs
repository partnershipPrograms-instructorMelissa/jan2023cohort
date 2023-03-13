#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsDishes.Models;

public class Chef
{
    [Key]
    public int ChefId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [FutureDate]
    public DateTime BirtDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public List<Dish> CreatorDish { get; set; } = new List<Dish>();
    public string FullName()
    {
        return FirstName + " " + LastName;
    }
    public int Age()
    {
        var today = DateTime.Today;
        var chefAge = today.Year - BirtDate.Year;
        return chefAge;
    }
}
public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime dt;
        if (value is DateTime)
        {
            dt = (DateTime)value;
        }
        else
        {
            return new ValidationResult("Invalid datetime");
        }
        if (dt > DateTime.Now)
        {
            return new ValidationResult("Date cannot be in the future");
        }
        return ValidationResult.Success;
    }
}