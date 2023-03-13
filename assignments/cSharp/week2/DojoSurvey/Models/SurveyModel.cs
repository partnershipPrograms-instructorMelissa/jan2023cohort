#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurvey.Models;

public class Survey
{

    [Required(ErrorMessage = "Name is required!")]
    [MinLength(2, ErrorMessage = "Username must be at least 2 characters in length.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Location is required!")]
    public string Location { get; set; }
    [Required(ErrorMessage = "Favorite Language is required!")]
    public string Language { get; set; }
    [MaxLength(20, ErrorMessage = "Comment can not be more than 20 characters in length.")]
    public string? Comment { get; set; }
}