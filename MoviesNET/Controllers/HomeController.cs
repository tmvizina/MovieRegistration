using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesNET.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesNET.Controllers
{
    public class HomeController : Controller
    {
        MoviesContext database = new MoviesContext();

       


        public IActionResult MoviesList()
        {
            List<Movie> movies = database.Movies.ToList();
            
            return View(movies);
        }

        public IActionResult Index()
        {
            List<Movie> movies = database.Movies.ToList();
            return View(movies);
        }

        public IActionResult Registration()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Result(Movie inputMovie)
        {
            MoviesContext db = new MoviesContext();
            //List<Movie> movies = db.Movies.ToList();
            db.Movies.Add(inputMovie);
            db.SaveChanges();
            
            return View(inputMovie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
