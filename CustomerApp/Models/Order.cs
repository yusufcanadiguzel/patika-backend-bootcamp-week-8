namespace CustomerApp.Models
{
    // Bir Order sınıfı oluşturun.
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
