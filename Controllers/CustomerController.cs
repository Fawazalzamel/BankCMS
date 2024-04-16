using BankCMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankCMS.Controllers
{
    public class CustomerController : Controller

    {
        
        Customer[] customersData = [new Customer("32871", "yousef", "yafof@gmail.com", "98322432"), 
            new Customer("33271", "fawaz", "ads@gmail.com", "9832343432")];
        

        public IActionResult Index()
        {
            return View(customersData);
        }
    }
}
