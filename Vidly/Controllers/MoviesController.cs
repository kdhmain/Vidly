using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith" },
                new Customer {Name = "Maria Sharapova" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleasedDate(int year,int month)
        //{
        //    return Content(year + "/" + month);
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        ////movies
        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortby={1}",pageIndex,sortBy));
        //}
    }
}