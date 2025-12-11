using AngelastroGeremy.Models;

namespace AngelastroGeremy.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal Total => Quantity * (Product?.Price ?? 0);
    }
}
