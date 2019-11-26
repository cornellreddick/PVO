using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PVO.Models;


namespace PVO.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ViewResult Index()
        {

            var customers = GetCustomers();
            {
                return View(customers);
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
                new Customer {Id = 1, Name = "Cornell Reddick"},
                new Customer {Id = 2, Name = "Maurice Reddick"}

            };
        }
    }
}