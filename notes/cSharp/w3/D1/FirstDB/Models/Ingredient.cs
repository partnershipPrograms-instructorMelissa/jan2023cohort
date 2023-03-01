#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstDB.Models;

public abstract class Ingredient{
    public int ID {get; set;}
    public int ShelfLife {get; set;}
    public string Type {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;
}