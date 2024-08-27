using CustomerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApp.Controllers
{
    // Bir CustomerOrdersController sınıfı oluşturun.
    public class CustomerOrdersController : Controller
    {
        // Bu controller içinde, Index adında bir aksiyon metodu oluşturun.
        public IActionResult Index()
        {
            // Örnek bir Customer nesnesi
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            // birkaç Order nesnesi oluşturun.
            var orders = new List<Order>()
            {
                new Order{ Id = 1, Name = "Laptop", Price = 1000, Quantity = 1},
                new Order{ Id = 2, Name = "Smart Phone", Price = 2000, Quantity = 1},
                new Order{ Id = 3, Name = "Keyboard", Price = 3000, Quantity = 1},
            };

            // CustomerOrderViewModel nesnesi oluşturun.
            var customerOrderViewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // CustomerOrderViewModel nesnesini view'a iletin.
            return View(customerOrderViewModel);
        }
    }
}
