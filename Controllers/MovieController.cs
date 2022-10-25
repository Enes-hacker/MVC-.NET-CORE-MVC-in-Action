using Microsoft.AspNetCore.Mvc;
using MVCInAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCInAction.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var movie = GetMovies(); //creating obj. called movie
           
            return View(movie);
        } //THAT'S ALL FOLKS ;-) 


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { movieName = "Forest Gump", releasedYear = 1994, genre = "comedy-drama"},
                new Movie { movieName = "The Godfather", releasedYear = 1972, genre = "criminal"  }
            };
        }

    }
}
