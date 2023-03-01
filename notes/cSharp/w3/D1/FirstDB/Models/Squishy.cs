#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstDB.Models;

public class Squishy{
    [Key]
    public int SquishyId {get; set;}
    public string Name {get; set;}
    public string Img {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now; // Auto generated
    public DateTime UpdatedAt {get; set;} = DateTime.Now; // Auto generated
}