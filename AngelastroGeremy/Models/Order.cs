using AngelastroGeremy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AngelastroGeremy.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Customer Customer { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public decimal Total => Items.Sum(i => i.Total);
    }
}

