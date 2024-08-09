using ShoppingCartProject.Models;

class Program
{
    public static void Main(string[] args)
    {
        Product product1 = new Product(1, "MacBook Pro 16\"", 249900, 10);
        Product product2 = new Product(2, "Ipad Pro 13\"", 119900, 20);
        Product product3 = new Product(3, "Iphone 15 Pro", 129800, 5);
        Product product4 = new Product(4, "Pencil Pro", 10900, 30);

        LineItem lineItem1 = new LineItem(1, 3, product1);
        LineItem lineItem2 = new LineItem(2, 5, product2);
        LineItem lineItem3 = new LineItem(3, 10, product3);
        LineItem lineItem4 = new LineItem(4, 5,product4);
        List<LineItem> lineItemsList1 = new List<LineItem>();
        lineItemsList1.Add(lineItem1);
        lineItemsList1.Add(lineItem2);
        lineItemsList1.Add(lineItem3);
        lineItemsList1.Add(lineItem4);

        LineItem lineItem5 = new LineItem(1, 10, product1);
        LineItem lineItem6 = new LineItem(2, 20, product2);
        LineItem lineItem7 = new LineItem(3, 30, product3);
        LineItem lineItem8 = new LineItem(4, 20, product4);

        List<LineItem> lineItemsList2 = new List<LineItem>();
        lineItemsList2.Add(lineItem5);
        lineItemsList2.Add(lineItem6);
        lineItemsList2.Add(lineItem7);
        lineItemsList2.Add(lineItem8);

        Order order1 = new Order(1, lineItemsList1);
        Order order2 = new Order(2, lineItemsList2);

        List<Order> ordersList = new List<Order>();
        ordersList.Add(order1);
        ordersList.Add(order2);

        Customer customer = new Customer(1, "Atharv Sathe", ordersList);
        PrintDetails(customer);
    }

    public static void PrintDetails(Customer customer)
    {
        Console.WriteLine($"Customer ID : {customer.Id}");
        Console.WriteLine($"Customer Name: {customer.Name}");
        Console.WriteLine();
        Console.WriteLine($"Order Details");
        Console.WriteLine();
        foreach (Order order in customer.orderList)
        {
            Console.WriteLine($"Order Id {order.Id}\nOrder Time: {order.date}");
            Console.WriteLine($"LineItem Details");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Line Item  |  Product Item  |  Product Name        | Quantity | Unit Price |  Discount  | Unit Cost after Discount | Total Lineitem Cost  |");
            Console.WriteLine("|------------|----------------|----------------------|----------|------------|------------|--------------------------|----------------------|");


            foreach (LineItem lineItem in order.items)
            {
                Console.WriteLine($"| {lineItem.Id,-10} | {lineItem._product.Id,-14} | {lineItem._product.Name,-20} | {lineItem.Quantity,8} | {lineItem._product.Price,10}" +
                    $" | {lineItem._product.DiscountPercent,7} %  | {lineItem._product.CalculateDiscountedPrice(),24} | {lineItem.CalculateLineItemCost(),20} |");
            }
            Console.WriteLine("|-------------------------------------------------------------------------------------------------------------------------------------------|");
            Console.WriteLine($"|            |                |                      |          |            |            |                          | {order.CalculateOrderPrice(),20} |");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}