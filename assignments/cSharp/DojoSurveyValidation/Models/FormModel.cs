#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidation.Models;
public class Form{
    [Required(ErrorMessage="Name is required!")]
    [MinLength(2, ErrorMessage="Name must be at least a length of 2")]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Language { get; set; }
    [MinLength(20, ErrorMessage="Comment must be at least a length of 20")]
    public string? Comment { get; set; }
}