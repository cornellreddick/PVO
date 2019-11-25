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
        public ActionResult Random()
        {
            var movie = GetMovies();

            return View(movie);
        }

        public ActionResult Details( int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);
            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Name = "Queen & Slim"},
                new Movie {Name = "Midway"},
                new Movie {Name = "Frozen II"}
            };
        }


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