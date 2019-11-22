using PVO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PVO.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Ramdom
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        
    }
}