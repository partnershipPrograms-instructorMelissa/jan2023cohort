#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRApractice.Models;

public class Toon {
    [Key]
    public int ID { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Img { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}