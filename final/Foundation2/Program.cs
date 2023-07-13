using System;

namespace Foundation2{
class Program
{
    static void Main(string[] args)
    {
        // create products for the order
        Product apple = new Product("apple", "001", 2.50);
        apple.setQuantity(7);
        Product orange = new Product("orange", "002", 3.50);
        orange.setQuantity(3);
        Product grapes = new Product("grapes", "300", 5.25);
        grapes.setQuantity(2);
        Product chocalate = new Product("chocalate", "025", 1.50);
        chocalate.setQuantity(4);
        Product pencil = new Product("pencil", "956", 0.25);
        pencil.setQuantity(15);
        Product notebook = new Product("notebook", "152", 2.50);
        apple.setQuantity(3);

        // Create Customers and Addresses
        Address bob_house = new Address("123 Sesame St, New York, New York", "USA");
        Customer bob = new Customer("Bob", bob_house);
        Address george_house = new Address("4 Privet Drive, Little Whinging, Surrey", "UK");
        Customer george = new Customer("George", george_house);

        //Create orders
        Order order1 = new Order(bob);
        Order order2 = new Order(george);

        //add items to orders
        order1.addProduct(apple);
        order1.addProduct(orange);
        order1.addProduct(grapes);
        order2.addProduct(chocalate);
        order2.addProduct(pencil);
        order2.addProduct(notebook);

        //Display packing and shipping lables
        Console.WriteLine("Order 1 List and Label");
        order1.displayShipping();
        order1.displayPacking();

        Console.WriteLine("\nOrder 2 List and Label");
        order2.displayShipping();
        order2.displayPacking();
    }
}

}