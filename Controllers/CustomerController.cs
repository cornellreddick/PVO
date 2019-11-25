using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PVO.Models;
using PVO.ViewModels;

namespace PVO.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            var customer = GetCustomers();
            {
                return View(customer);
            };
            
        }

        //Detail method the will thrown a HttpNotFound exception if customer id is null. 
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            

            return View(customer);
        }


        //Created a list of Customers. 
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Name = "Cornell Reddick"},
                new Customer {Name = "Maurice Reddick"}

            };
        }
    }
}