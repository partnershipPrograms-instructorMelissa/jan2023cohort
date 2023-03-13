#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;

public class Rsvp
{
    [Key]
    public int RsvpId { get; set; }
    // add more attributes here
    public int WeddingId { get; set; }
    public int UserId { get; set; }
    public Wedding? Wedding { get; set; }
    public User? User { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}