using JoeMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoeMovies.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult IndexCustomers()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult CustomerDetails(int Id)
        {
            var customer = GetCustomers().Where(c => c.Id == Id);

            if(customer.Any())
            {
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }
                
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id = 1, Name = "Customer 1"},
                new Customer{Id = 2, Name = "Customer 2"}
            };
        }
    }
}
