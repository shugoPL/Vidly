using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customersList = new List<Customer>()
           {
               new Customer() { Id = 1, Name = "Janek"},
               new Customer() { Id = 2, Name = "Franek"},
               new Customer() { Id = 3, Name = "Adam"},
           };

        // GET: Customers
        public ActionResult Index()
        {

            //customersList 

            var listOfUsers = new CustomersViewModel()
            {
                Customer = customersList
            };


            return View(listOfUsers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Customer(int id)
        {
            var selectedCustomer = customersList.Find( cst => cst.Id == id);

            return View(selectedCustomer);
        }

    }
}