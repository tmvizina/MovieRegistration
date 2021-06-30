using Microsoft.AspNetCore.Mvc;
using MoviesNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesNET.Controllers
{
    public class MoviesController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        private readonly MoviesContext _context;
        public MoviesController(MoviesContext context)
        {
            _context = context;
        }


    }
}
