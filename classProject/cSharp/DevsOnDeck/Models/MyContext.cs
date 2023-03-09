#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace DevsOnDeck.Models;

public class MyContext : DbContext 
{    
    public MyContext(DbContextOptions options) : base(options) { }    
   
    public DbSet<User> Users { get; set; } 
    public DbSet<UserProfile> UserProfiles {get; set;}
    // public DbSet<Organization> Organizations {get; set;}
    
    // public DbSet<Skill> Skills {get; set;}
    // public DbSet<Job> Jobs {get; set;}
    // public DbSet<UserSkill> UserSkills {get; set;}

}