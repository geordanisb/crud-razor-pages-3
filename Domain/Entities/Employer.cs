using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Employer
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;  
    [Required]
    public string Area { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.Today;
    [DefaultValue(true)]
    public bool Active { get; set; } 
}