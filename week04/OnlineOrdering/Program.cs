using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        for (int i = 0; i < 10; i++)
        {

            Order order = new WareHouse().GetDummyOrder();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine(order.GetPackingLabel());


            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
        }
    }
}