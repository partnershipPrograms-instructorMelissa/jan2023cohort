#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstDB.Models;

public class Fruit : Ingredient{
    [Key]
    public int FruitID {set; get;}
    public string Name {get; set;}
    public string Color {get; set;}
} 