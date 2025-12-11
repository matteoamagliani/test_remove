using AngelastroGeremy.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AngelastroGeremy.Models
{
    public class CartItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void Raise([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Product Product { get; set; }

        private int _quantity = 1;
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity == value) return;
                _quantity = value;
                Raise(nameof(Quantity));
                Raise(nameof(Total));
            }
        }

        public decimal Total => Product != null ? Product.Price * Quantity : 0m;

        public CartItem(Product product)
        {
            Product = product;
        }
    }
}
