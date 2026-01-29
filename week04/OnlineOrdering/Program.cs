using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Anywhere St.", "Springville", "Ottowa", "Canada");
        Customer customer1 = new Customer("Cassie Carone", address1);
        Product productA1 = new Product("Banana", "4011", 0.59, 8);
        Product productA2 = new Product("Lettuce", "75", 3.11, 1);
        Product productA3 = new Product("Maple Syrup", "170220", 10.49, 17);
        Order order1 = new Order(customer1);
        order1.SetProducts(productA1);
        order1.SetProducts(productA2);
        order1.SetProducts(productA3);
        Console.WriteLine(order1.ReturnShippingLabel());
        Console.WriteLine(order1.ReturnPackingLabel());
        Console.WriteLine($"Total: ${order1.CalculateCost()} \n");

        Address address2 = new Address("456 Everywhere St.", "Summerville", "Florida", "USA");
        Customer customer2 = new Customer("Joy Gleeland", address2);
        Product productB1 = new Product("Rotisserie Chicken", "87745", 4.99, 3);
        Product productB2 = new Product("Triple Chocolate Muffins", "60484001", 6.99, 4);
        Product productB3 = new Product("Watermelon", "4032", 7.29, 12);
        Order order2 = new Order(customer2);
        order2.SetProducts(productB1);
        order2.SetProducts(productB2);
        order2.SetProducts(productB3);
        Console.WriteLine(order2.ReturnShippingLabel());
        Console.WriteLine(order2.ReturnPackingLabel());
        Console.WriteLine($"Total: ${order2.CalculateCost()}\n");

        Address address3 = new Address("789 Nowhere St.", "Winterville", "Minnesota", "USA");
        Customer customer3 = new Customer("Saddie Depp", address3);
        Product productC1 = new Product("Bacon", "6369008", 6.70, 20);
        Product productC2 = new Product("Twinkies", "00077755001359", 5.49, 4);
        Product productC3 = new Product("Chocolate Ice Cream", "67076", 8.25, 7);
        Order order3 = new Order(customer3);
        order3.SetProducts(productC1);
        order3.SetProducts(productC2);
        order3.SetProducts(productC3);
        Console.WriteLine(order3.ReturnShippingLabel());
        Console.WriteLine(order3.ReturnPackingLabel());
        Console.WriteLine($"Total: ${order3.CalculateCost()}");
    }
}