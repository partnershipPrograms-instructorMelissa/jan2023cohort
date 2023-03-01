#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRApractice.Models;

public class Squishy {
    [Key]
    public int ID { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Img { get; set; }
    // [Required]
    // public string Owner { get; set; }
    public string? Location { get; set; } //not required in data field
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}