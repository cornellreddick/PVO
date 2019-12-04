using System.Data.Entity;
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
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movie = _context.Movies.Include(m => m.Genre).ToList();

            return View(movie);
        }

       
        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movies == null)
                return HttpNotFound();


            return View(movies);
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