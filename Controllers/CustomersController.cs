using JoeMovies.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoeMovies.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult IndexCustomers()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult CustomerDetails(int Id)
        {
            var customer = _context.Customers.Include(m => m.MembershipType).Where(c => c.Id == Id).FirstOrDefault();

            if(customer != null)
            {
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }
                
        }

    }
}
