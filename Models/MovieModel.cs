using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Moment2MVC.Models;

public class MovieModel
{

    [Required(ErrorMessage = "Ange en korrekt titel")]
    [StringLength(50, MinimumLength = 1)]
    [Display(Name = "Titel")]
    public string? Title { get; set; }
    [Required(ErrorMessage = "Ange en korrekt regissör")]
    [StringLength(50, MinimumLength = 1)]
    [Display(Name = "Regissör")]

    public string? Director { get; set; }

    [Required(ErrorMessage = "Ange ett korrekt år")]
    [MaxLength(4)]
    [Display(Name = "År")]

    public string? Year { get; set; }

        [Required(ErrorMessage = "Ange en korrekt genre")]

    [Display(Name = "Genre")]

    public string? Genre { get; set; }
}