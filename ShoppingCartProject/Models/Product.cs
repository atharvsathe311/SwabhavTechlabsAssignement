using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercent;
        public const double DIVISOR = 100; 
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }

        public Product(int id, string name, double price, double discountPercent)
        {
            Id = _id = id;
            Name = _name = name;
            Price = _price = price;
            DiscountPercent = _discountPercent = discountPercent;
        }

        public double CalculateDiscountedPrice()
        {
            return _price - (_price * _discountPercent / DIVISOR);
        }

    }
}
