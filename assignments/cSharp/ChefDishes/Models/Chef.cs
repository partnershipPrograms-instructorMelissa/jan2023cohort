#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefDishes.Models;

public class Chef {
    [Key]
    public int ID {get; set;}
    [Required]
    [MinLength(2)]
    public string FirstName {get; set;}
    [Required]
    [MinLength(2)]
    public string LastName {get; set;}
    [Required]
    [FutureDate]
    [AdultAge]
    public DateTime BirthDate {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;

    /******************************
        ONE-TO-MANY RELATIONSHIP PROPERTIES BELOW
        [MANY SIDE]

        Foreign Keys: id of a different (foreign model) [on ONE side only]

        Navigation Props:
            - data type is a related model
            - MUST use .Include for the nav prop data to be included via a SQL JOIN.
    *******************************/
    // * Navigation Props
    public List<Dish> AllDishes {get; set;} = new List<Dish>();

    public string FullName(){
        return FirstName + " " + LastName;
    }

    public int Age(){
        int currentDate = int.Parse(DateTime.Now.ToString("yyyMMdd"));
        int dob = int.Parse(BirthDate.ToString("yyyMMdd"));
        return (currentDate - dob) / 10000;
    }
}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        TimeSpan diff = DateTime.Now - (DateTime)value;
        
        if(diff < TimeSpan.Zero){
            return new ValidationResult("Choose a time not in the future");
        }
        return ValidationResult.Success;
    }
}

public class AdultAgeAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {   
        DateTime birth = (DateTime)value;
        int dob = int.Parse(birth.ToString("yyyyMMdd"));
        int currentDate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
        int age = (currentDate - dob) / 10000;
        if(age < 18 ){
            return new ValidationResult("Must be at least 18 years old.");
        }
        return ValidationResult.Success;
    }
}