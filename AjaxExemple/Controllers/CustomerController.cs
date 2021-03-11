using AjaxExemple.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxExemple.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();
        public CustomerController()
        {
            customers.Add(new CustomerModel {Id =0, Name="Slouma", Age=35 });
            customers.Add(new CustomerModel { Id = 1, Name = "Touta", Age = 28 });
            customers.Add(new CustomerModel { Id = 2, Name = "Ayouta", Age = 26 });
            customers.Add(new CustomerModel { Id = 3, Name = "Tass", Age = 27 });
            customers.Add(new CustomerModel { Id = 4, Name = "Maroua", Age = 26 });
        }
        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult ShowMore(int id)
        {
            CustomerModel c = customers.FirstOrDefault(param => param.Id == id);
            return PartialView(c);
        }

    }
}
