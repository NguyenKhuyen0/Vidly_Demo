using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Demo.Models;
using Vidly_Demo.ViewModels;

namespace Vidly_Demo.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith", Id = 1},
                new Customer {Name = "Marry Williams", Id = 2}
            };
            var viewModel = new IndexCustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
        [Route("customers/details/{Id}")]
        public ActionResult Details(int Id)
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith", Id = 1},
                new Customer {Name = "Marry Williams", Id = 2}
            };

            if (String.IsNullOrEmpty(Id.ToString())) return HttpNotFound();

            var customer = customers[Id - 1];

            var viewModel = new DetailsCustomerViewModel
            {
                Customer = customer
            };

            return View(viewModel);
        }
    }
}