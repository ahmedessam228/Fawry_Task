using Fawry_Task;
class Program 
{
    static void Main(string[] args) 
    {
        var Cheese = new ShippableExpiringProduct("Cheese" , 100 , 5 , DateTime.Now.AddDays(3) , 0.2);
        var biscuits = new ShippableExpiringProduct("Biscuits", 150 , 2 , DateTime.Now.AddDays(1) , 0.7);
        var mobile = new ShippableProduct("Mobile" , 300 , 4 , 0.125 );

        var customer1 = new Customer("Essam", 10000);
        var cart1 = new Cart();

        var customer2 = new Customer("ALi", 5000);
        var cart2 = new Cart();

        cart1.AddItem(Cheese, 2);
        cart1.AddItem(biscuits, 1);
        cart2.AddItem(mobile, 3);
        CheckoutService.Checkout(customer1,cart1);
        Console.WriteLine("***************************");
        CheckoutService.Checkout(customer2, cart2);

    }
}