using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("santo domingo", "Calle buenos aires", "RD");
        Customer customer1 = new Customer("Rex Vasquez", address1);
        Order order1 = new Order();

        order1.SetCustomer(customer1);
        Product product1 = new Product("tomato", "A44W10", 3, 3);
        Product product2 = new Product("rice", "AA2025", 5, 1);
        Product product3 = new Product("meat", "V3024E", 4.25, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("Rexburg", "750 S 2nd St E", "usa");
        Customer customer2 = new Customer("Laurin Rojas", address2);
        Order order2 = new Order();

        order2.SetCustomer(customer2);
        Product product4 = new Product("socks", "A256", 7.27, 2);
        Product product5 = new Product("tie", "B573", 25, 1);
        Product product6 = new Product("bagpack", "E386", 50.36, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        order1.DisplayReceipt();
        order2.DisplayReceipt();
    }
}