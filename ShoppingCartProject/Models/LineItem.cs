﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject.Models
{
    public class LineItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public Product _product;

        public LineItem(int id, int quantity, Product product)
        {
            Id = id;
            Quantity = quantity;
            _product = product;
        }

        public double CalculateLineItemCost()
        {
            return _product.CalculateDiscountedPrice() * Quantity;
        }
    }
}
