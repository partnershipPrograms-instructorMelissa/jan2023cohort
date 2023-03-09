#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DevsOnDeck.Models;

public class Organization {
    [Key]
    public int OganizationId {get; set;}
    [Required]
    public string ContactName {get; set;}
    [Required]
    [EmailAddress]
    public string ContactEmail {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // ***** One to Many non id side
    public List<Job> JobList {get; set;} = new List<Job>();

    // ******** One to Many id side
    public int UserId {get; set;}
    public User? theOrgOwner {get; set;}

    // ******* One to One non id side
    public OrganizationProfile? orgProfile {get; set;}
}