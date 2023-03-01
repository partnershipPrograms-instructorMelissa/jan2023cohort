#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace SessionPractice.Models;

public class User{
    [Required]
    public string Name { get; set; }
}