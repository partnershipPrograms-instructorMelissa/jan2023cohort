using System.ComponentModel.DataAnnotations;

// namespace DateValidation.Models;
public class TimeDate{
    [FutureDate]
    public DateTime date_time { get; set; }
}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // You first may want to unbox "value" here and cast to to a DateTime variable!
        TimeSpan diff = DateTime.Now - (DateTime)value;
        // Console.WriteLine($"Value: {diff.TotalSeconds} (kw)");
        if(diff < TimeSpan.Zero){
            return new ValidationResult("Choose a time not in the future");
        }
        return ValidationResult.Success;
    }
}

