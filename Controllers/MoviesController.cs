using JoeMovies.Models;
using JoeMovies.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoeMovies.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Ben 10"
            };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult IndexMovies()
        {
            var movies = _context.Movies.Include(g => g.Genre).ToList();

            return View(movies);
        }

        public ActionResult MovieDetails(int Id)
        {
            var movie = _context.Movies.Include(g => g.Genre).Where(m => m.Id == Id).SingleOrDefault();

            return View(movie);
        }

        //public IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie {Id = 1, Name = "Die Hard"},
        //        new Movie {Id = 2, Name = "Terminator"}
        //    };
        //}

        //[Route("movies/byReleaseDate/{year}/{month}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + " " + month);
        //}
    }
}