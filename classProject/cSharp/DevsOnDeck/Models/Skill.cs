#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DevsOnDeck.Models;

public class Skill {
    [Key]
    public int SkillId {get; set;}
    // add more attributes here
    [Required]
    public string SkillName {get;set;}
    public string? SkillImg {get; set;}
    public string SkillType {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<UserSkill> AllSkills {get; set;} = new List<UserSkill>();
}