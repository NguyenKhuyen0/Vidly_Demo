using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Demo.Models;
using Vidly_Demo.ViewModels;

namespace Vidly_Demo.Controllers
{
    public class MoviesController : Controller
    {
       

        // GET: Movies
/*        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            //return View(movie);
            //return new ViewResult(); 
            //return Content("Hello");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });



            // every controller have a property call viewData, viewBag to send data to view
            ///ViewData["Movie"] = movie;

            *//*var viewResult = new ViewResult();
            viewResult.ViewData.Model  vi vay, co the dung @Model.Name*//*
            return View(movie);
        }*/

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //movies
        //int? nullable
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        /*Apply the Route Attribute*/
        /*regex(\\d{2}):range(1,12) : How to search: ASP MVC Atribute Route Contraints*/
        [Route("movies/relseased/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }



        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}