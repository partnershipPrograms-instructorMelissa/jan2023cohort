#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DateValidator.Models;

public class TimeValidator
{
    [TimeCheck]
    [Required]
    public string FormDate { get; set; }

    public class TimeCheckAttribute : ValidationAttribute
    {
        // Call upon the protected IsValid method
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime todayDate = DateTime.Today;
            string valDate = todayDate.ToString("s").Substring(0, 10); // converts date to 
            string val = (string)value;
            // val = todayDate.ToString("s").Substring(0, 10);

            if (val != valDate)
            {
                Console.WriteLine($"{val} value is printing here in the function! here is valDate {valDate}");
                // we return an error message in ValidationResult we want to render  
                return new ValidationResult("You cannot save prior/after todays date!");
            }
            else
            {
                // Otherwise, we were successful and can report our success  
                return ValidationResult.Success;
            }
        }
    }
}