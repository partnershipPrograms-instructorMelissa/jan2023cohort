#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;

public class Wedding {
    [Key]
    public int ID {get; set;}
    [Required]
    public string WedderOne {get; set;}
    [Required]
    public string WedderTwo {get; set;}
    [Required]
    [FutureDate]
    public DateTime Date {get; set;}
    [Required]
    public string Address {get; set;}

    // ***** RELATIONSHIPS *****
    // list of rsvp for the wedding
    public List<RSVP> RSVPs {get; set;} = new List<RSVP>();

    public string WeddingOf(){
        return WedderOne + " & " + WedderTwo;
    }
}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        TimeSpan diff = DateTime.Now - (DateTime)value;
        
        if(diff > TimeSpan.Zero){
            return new ValidationResult("Choose a time in the future");
        }
        return ValidationResult.Success;
    }
}