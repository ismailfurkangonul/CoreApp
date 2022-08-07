using CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customerList = CustomerContext.customers;
            
            return View(customerList);   
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateCustomer(string firstName,string lastName)
        {
            Customer customer = new Customer();

            customer.Name = firstName;
            customer.SurName=lastName;

            CustomerContext.customers.Add(customer);

            return RedirectToAction("Index");

        }
     
    }
}
