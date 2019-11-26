using PVO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PVO.ViewModels;

namespace PVO.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Ramdom
        public ViewResult Index()
        {
            var movie = GetMovies();

            return View(movie);
        }

//        public ActionResult Details( int id)
//        {
//            var movie = GetMovies();
//            return View(movie);
//        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Queen & Slim"},
                new Movie {Id = 2, Name = "Midway"},
                new Movie {Id = 3, Name = "Frozen II"}
            };
        }

        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };

            return View(viewModel);


            //Example methods 
            //        public ActionResult Edit(int Id)
            //        {
            //            return Content("Id=" + Id);
            //        }
            //
            //        //Movies
            //        public ActionResult Index(int? pageIndex, string sortBy)
            //        {
            //            if (pageIndex.HasValue)
            //                pageIndex = 1;
            //            
            //
            //            if (String.IsNullOrWhiteSpace(sortBy))
            //                sortBy = "Name";
            //
            //            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            //        }
            //
            //        //Attribute Route
            //        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
            //        public ActionResult ByReleaseYear(int year, int month)
            //        {
            //
            //            return Content(year + "/" + month);
            //        }


        }
    }
}