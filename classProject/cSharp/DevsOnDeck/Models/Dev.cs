#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DevsOnDeck.Models;

public class Dev {
    [Key]
    public int DevId {get; set;}
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // ******* One to One non id side
    public int UserId {get; set;}
    public User? myUser {get; set;}
    public SkillList? mySkill {get;set;}

}