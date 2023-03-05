#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefDishes.Models;

public class Dish{
    [Key]
    public int ID {get; set;}
    [Required]
    [MinLength(3)]
    public string Name {get; set;}
    [Required]
    [Range(1, int.MaxValue)]
    public int Calories {get; set;}
    [Required]
    [Range(1, 5)]
    public int Tastiness {get; set;}
    /******************************
        ONE-TO-MANY RELATIONSHIP PROPERTIES BELOW
        [One SIDE]

        Foreign Keys: id of a different (foreign model) [on ONE side only]

        Navigation Props:
            - data type is a related model
            - MUST use .Include for the nav prop data to be included via a SQL JOIN.
    *******************************/
    // * Foreign Key: needs to match PK property name
    [Required]
    public int ChefID {get; set;}
    // * Navigation property
    public Chef? Creator {get; set;} // 1 chef related to each dish

    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;
}