#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRApractice.Models;

public class User{
    [Key]
    public int ID { get; set; }
    [Required]
    [Display(Name="First Name")] // allows for spaces in asp-for
    public string FirstName {get; set;}
    [Required]
    [Display(Name ="Last Name")]
    public string LastName {get; set;}
    [Required]
    [EmailAddress] // set the type of email
    [UniqueEmail] // check database to see if email is already there - no repeat email addresses
    public string Email {get; set;}
    [Required]
    [DataType(DataType.Password)] // makes the field dots so you can't see ur password (esp when using asp)
    public string Password {get; set;}
    // confirm password
    [NotMapped] // please do not add me to the database
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage="Passwords don't match, try again.")]
    public string Confirm {get; set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

public class UniqueEmailAttribute : ValidationAttribute {
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(value == null){
            return new ValidationResult("Email is required");
        }
        MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
        if(_context.Users.Any(e => e.Email == value.ToString())){
            return new ValidationResult("Email is already in use.");
        }
        // return base.IsValid(value, validationContext);
        return ValidationResult.Success;
    }
}