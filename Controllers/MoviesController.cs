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
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies

        public ActionResult IndexMovies()
        {
            var movies = _context.Movies.Include(g => g.Genre).ToList();

            if (User.IsInRole(RoleName.CanManageMovies))
            {
                return View("IndexMovies",movies);
            }
            else
            {
                return View("ReadOnlyMovieList", movies);
            }
        }

        public ActionResult MovieDetails(int id)
        {
            var movie = _context.Movies.Include(g => g.Genre).FirstOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult EditMovie(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();
        
            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList(),
                Id = movie.Id,
                Name = movie.Name,
                ReleaseDate = movie.ReleaseDate,
                NumberInStock = movie.NumberInStock,
                GenreId = movie.GenreId
            };

            return View("MovieForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult NewMovie()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult SaveMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.Genre = movie.Genre;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("IndexMovies","Movies");
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