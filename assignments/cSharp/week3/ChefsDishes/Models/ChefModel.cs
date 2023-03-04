#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes.Models;

public class Chef
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [FutureDate]
    public DateTime BirtDate { get; set; }
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