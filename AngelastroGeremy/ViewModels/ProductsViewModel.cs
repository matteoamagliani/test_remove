using System.Collections.ObjectModel;
using AngelastroGeremy.Models;

namespace AngelastroGeremy.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products { get; } = new ObservableCollection<Product>();

        public ProductsViewModel()
        {
            Products.Add(new Product { SKU = "P001", Name = "Café", Category = "Bebidas", Price = 2.50m });
            Products.Add(new Product { SKU = "P002", Name = "Pan Fresco", Category = "Comida", Price = 1.20m });
            Products.Add(new Product { SKU = "P003", Name = "Agua Mineral", Category = "Bebidas", Price = 0.90m });
        }
    }
}
