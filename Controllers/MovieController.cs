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
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Cornell"},
                new Customer { Name = "Tasha"},
                new Customer { Name = "Sam"},
                new Customer { Name = "Reese"},

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };

            return View(viewModel);
        }

        public ActionResult Edit(int Id)
        {
            return Content("Id=" + Id);
        }

        //Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue)
                pageIndex = 1;
            

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //Attribute Route
        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {

            return Content(year + "/" + month);
        }

                 
    }
}