using CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
            customer.Id = CustomerContext.customers.Last().Id + 1;

            CustomerContext.customers.Add(customer);

            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult DeleteCustomer(int Id)
        {
            CustomerContext.customers.Remove(CustomerContext.customers.Find(x => x.Id == Id));
            return RedirectToAction("Index");   
        }
     
    }
}
