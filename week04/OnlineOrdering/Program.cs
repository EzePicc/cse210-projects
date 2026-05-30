class Program
{
    static void Main(string[] args)
    {
        //customer from argentina (fake address)
        Address address1 = new Address(
            "Dolores 818",
            "Villa Sarmiento",
            "Buenos Aires",
            "Argentina");

        Customer customer1 = new Customer(
            "Ezequiel Piccardo",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Mate Imperial", "AR1001", 45, 1));
        order1.AddProduct(new Product("Bombilla Acero Inoxidable", "AR1002", 15, 2));
        order1.AddProduct(new Product("Yerba Mate Playadito 1kg", "AR1003", 8, 3));


        Address address2 = new Address(
            "235 S 700 E St",
            "Spanish Fork",
            "Utah",
            "USA");

        Customer customer2 = new Customer(
            "John Lloyd",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Gaming Keyboard", "US2001", 80, 1));
        order2.AddProduct(new Product("Wireless Mouse", "US2002", 35, 2));
        order2.AddProduct(new Product("USB-C Hub", "US2003", 40, 1));

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("ORDER N°1");
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("ORDER N°2");
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}