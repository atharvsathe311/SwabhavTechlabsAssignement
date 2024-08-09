using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ShoppingCartProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime date = DateTime.Now;
        public List<LineItem> items = new List<LineItem>();

        public Order(int id, List<LineItem> lineItems)
        {
            Id = id;
            items = lineItems;
        }

        public double CalculateOrderPrice()
        {
            double totalCost = 0;
            foreach (LineItem lineItem in items)
            {
                totalCost += lineItem.CalculateLineItemCost();
            }

            return totalCost;
        }
    }
}
