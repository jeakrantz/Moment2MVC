using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Moment2MVC.Models;

namespace Moment2MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() {
        return View();
    }
    [Route("/om")]
    public IActionResult About() {
        return View();
    }
    [Route("/formular")]
    public IActionResult Form() {
        return View();
    }
    [Route("/formular")]
    [HttpPost]
    public IActionResult Form(MovieModel model)  {
        
        //Validera input från form
        if(ModelState.IsValid)
        {
            string json = System.IO.File.ReadAllText("movie.json");
            var movie = JsonSerializer.Deserialize<List<MovieModel>>(json);

            //Lagra i JSON-fil
            if(movie != null){
                movie.Add(model);
                    json = JsonSerializer.Serialize(movie);
                    System.IO.File.WriteAllText("movie.json", json);
            }
            ModelState.Clear();
        } 
        return View();
    }


}