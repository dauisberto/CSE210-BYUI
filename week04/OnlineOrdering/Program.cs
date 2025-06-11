using System;

class Program
{
    static void Main(string[] args)
    {
        Address joeAddress = new Address("5th avenue", "New York", "New York", "United States");
        Address kimAddress = new Address("Abe Lincoln", "Kissimme", "Florida", "United States");
        Address anaAddress = new Address("Salomão Nasser", "Curitiba", "Paraná", "Brazil");

        Customer joe = new Customer("Joe Smith", joeAddress);
        Customer kim = new Customer("Kim Possible", kimAddress);
        Customer ana = new Customer("Ana Da Silva", anaAddress);

        Product iPhone13 = new Product("iPhone 13", "IP13USWW", 345.99, 2);
        Product iPhone14 = new Product("iPhone 14", "IP14LATAMXD", 429.99, 3);
        Product iPhone5Pro = new Product("iPhone 15 Pro", "IP15PSU", 599.99, 3);
        Product playStation5 = new Product("Play Station 5", "PS5WWID", 699.99, 2);
        Product SamsungLaptop = new Product("Samsung Chromebook", "SM-S9393", 699.99, 1);
        Product AirFryer = new Product("Air Fryer 4L", "AF4LUSA", 59.99, 6);

        List<Product> joeList = new List<Product>();
        List<Product> kimList = new List<Product>();
        List<Product> anaList = new List<Product>();

        joeList.Add(iPhone13);
        joeList.Add(AirFryer);

        kimList.Add(iPhone14);
        kimList.Add(SamsungLaptop);

        anaList.Add(iPhone5Pro);
        anaList.Add(playStation5);

        Order joeOrder = new Order(joe, joeList);
        Order kimOrder = new Order(kim, kimList);
        Order anaOrder = new Order(ana, anaList);

        //Packing Labels:
        joeOrder.GetPackingLabel();
        kimOrder.GetPackingLabel();
        anaOrder.GetPackingLabel();
        Console.WriteLine("");

        //Shipping Labels:
        joeOrder.GetShippingLabel();
        kimOrder.GetPackingLabel();
        anaOrder.GetShippingLabel();
        Console.WriteLine("");

        //Total value:
        Console.WriteLine($"{joeOrder.GetTotalCost()}");
        Console.WriteLine($"{kimOrder.GetTotalCost()}");
        Console.WriteLine($"{anaOrder.GetTotalCost()}");
        Console.WriteLine("");




        





    }
}