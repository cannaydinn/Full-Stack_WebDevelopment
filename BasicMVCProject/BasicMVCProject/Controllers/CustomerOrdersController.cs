using BasicMVCProject.Models;
using BasicMVCProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVCProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Can";
            customer1.LastName = "Aydın";
            customer1.Email = "canaydin@gmail.com";

            var orders1 = new List<Order>
            {
                new Order { Id = 1, ProductName = "Gaming Laptop", Price = 100, Quantity = 1 }
            };

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Tim";
            customer2.LastName = "Cook";
            customer2.Email = "timcook@apple.com";

            var orders2 = new List<Order>
            {
                new Order { Id = 1, ProductName = "iPhone 16 Pro Max", Price = 250, Quantity = 3 },
                new Order { Id = 2, ProductName = "Macbook Pro M3 Max", Price = 500, Quantity = 2 },
            };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Craig";
            customer3.LastName = "Federighi";
            customer3.Email = "craigfederighi@apple.com";

            var orders3 = new List<Order>
            {
                new Order { Id = 1, ProductName = "iPad Pro", Price = 400, Quantity = 5 },
                new Order { Id = 2, ProductName = "Apple Pencil Pro", Price = 150, Quantity = 5 },
            };



            List<CustomerOrderViewModel> viewModel = new List<CustomerOrderViewModel>
            {
                new CustomerOrderViewModel{ Customer = customer1, Orders = orders1},
                new CustomerOrderViewModel{ Customer = customer2, Orders = orders2},
                new CustomerOrderViewModel{ Customer = customer3, Orders = orders3},
            };
            return View(viewModel);
        }
    }
}
