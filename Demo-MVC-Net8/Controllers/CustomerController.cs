using Microsoft.AspNetCore.Mvc;
using Demo_MVC_Net8.Models;

namespace Demo_MVC_Net8.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Orders()
        {
            var viewModel = new CustomerViewModel
            {
                CustomerNumber = 111111,
                FirstName = "Serge",
                LastName = "Klokov"
            };

            viewModel.Orders.Add(new CustomerOrder
            {
                OrderId = 1,
                OrderDate = new DateTime(2021, 5, 21, 8, 50, 37),
                Description = "Part 1",
                Total = 120.00m
            });

            viewModel.Orders.Add(new CustomerOrder
            {
                OrderId = 2,
                OrderDate = new DateTime(2021, 5, 21, 9, 30, 0),
                Description = "Part 2",
                Total = 150.00m
            });

            viewModel.Orders.Add(new CustomerOrder
            {
                OrderId = 3,
                OrderDate = new DateTime(2021, 5, 21, 10, 30, 0),
                Description = "Part 3",
                Total = 130.00m
            });

            return View(viewModel);
        }
    }
}