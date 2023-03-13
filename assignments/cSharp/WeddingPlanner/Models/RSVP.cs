#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;

public class RSVP {
    [Key]
    public int ID {get; set;}
    // link the user
    public int UserID {get; set;} // fk for user
    public User? User {get; set;} // navigation prop for user
    // link the wedding
    public int WeddingID {get; set;} // fk for wedding
    public Wedding? Wedding {get; set;} // navigation prop for wedding
}