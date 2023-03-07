#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;

public class Wedding
{
    [Key]
    public int WeddingId { get; set; }
    // add more attributes here
    [Required]
    public string Bride { get; set; }
    [Required]
    public string Groom { get; set; }

    [Required]
    [FutureDate]
    public DateTime EventDate { get; set; }

    [Required]
    public string Address { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public List<Rsvp> Guest { get; set; } = new List<Rsvp>();
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
        if (dt < DateTime.Now)
        {
            return new ValidationResult("Date must be in the future");
        }
        return ValidationResult.Success;
    }
}