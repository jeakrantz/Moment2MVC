using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

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

    [Required(ErrorMessage = "Ange ett korrekt datum")]
    [Display(Name = "Utgivningsdatum")]
    [DataType(DataType.Date)]
    public string? Release { get; set; }

    [Required(ErrorMessage = "Ange en korrekt genre")]

    [Display(Name = "Genre")]

    public string? Genre { get; set; }

    [Display(Name = "Barntillåten")]
    public bool AgeLimit {get; set;}

}