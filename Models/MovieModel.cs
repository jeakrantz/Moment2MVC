using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Moment2MVC.Models;

public class MovieModel {

    [Required]
    [StringLength(50, MinimumLength=1)]
    [Display(Name = "Titel")]
    public string? Title { get; set;}
    [Required]
    [StringLength(50, MinimumLength=1)]
    [Display(Name = "Regissör")]

    public string? Director { get; set;}

    [Required]
    [MaxLength(4)]
    [Range(1800,2400)]
    [Display(Name = "År (yyyy)")]

    public int? Year { get; set;}
    
    [Required]
    [Display(Name = "Genre")]

    public string? Genre { get; set;}
}