using Fawry_Task;
class Program 
{
    static void Main(string[] args) 
    {
        var Cheese = new ShippableExpiringProduct("Cheese" , 100 , 5 , DateTime.Now.AddDays(3) , 0.2);
        var biscuits = new ShippableExpiringProduct("Biscuits", 150 , 2 , DateTime.Now.AddDays(1) , 0.7);
        var mobile = new ShippableProduct("Mobile" , 300 , 4 , 0.125 );


        var Customer = new Customer("Essam", 10000);
        var cart = new Cart();

        cart.AddItem(Cheese, 2);
        cart.AddItem(biscuits, 1);
        cart.AddItem(mobile, 3);
        CheckoutService.Checkout(Customer,cart);
    }
}