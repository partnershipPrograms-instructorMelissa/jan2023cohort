#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;

public class User {
    [Key]
    public int ID {get; set;}
    [Required]
    [MinLength(2)]
    public string FirstName {get; set;}
    [Required]
    [MinLength(2)]
    public string LastName {get; set;}
    [Required]
    [EmailAddress]
    [UniqueEmail]
    public string Email {get; set;}
    [Required]
    [DataType(DataType.Password)]
    public string Password {get; set;}
    [NotMapped] // please do not add me to the database
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage="Passwords don't match, try again.")]
    public string Confirm {get; set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // ***** RELATIONSHIPS *****
    // list of rsvp for the user
    public List<RSVP> RSVPs {get; set;} = new List<RSVP>();
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