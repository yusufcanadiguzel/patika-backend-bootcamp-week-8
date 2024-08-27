namespace CustomerApp.Models
{
    // Bir CustomerOrderViewModel sınıfı oluşturun.
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
