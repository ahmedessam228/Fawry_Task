namespace Fawry_Task
{
    public class CheckoutService
    {
        public static void Checkout(Customer customer, Cart cart)
        {
            if(cart.IsEmpty()) 
                throw new Exception("Cart is empty.");

            double subtotal = 0;
            double shippingCost = 0;
            List<IShippable> toShip = new();
            foreach (var item in cart.GetItems())
            {
                if (item.Product.IsExpired())
                    throw new Exception($"Product {item.Product.Name} is expired");
                if (item.Quantity > item.Product.Quantity)
                    throw new Exception($"Insufficient quantity for {item.Product.Name}");

                subtotal+= item.Product.Price * item.Quantity;

                if (item.Product.NeedsShipping() && item.Product is IShippable shippable)
                {
                    for (int i = 0; i < item.Quantity; i++)
                        toShip.Add(shippable);
                    shippingCost += 10 * item.Quantity;
                }
            }
            double total = subtotal + shippingCost;
            if (customer.Balance < total)
                throw new Exception("Insufficient balance for checkout.");

            foreach (var item in cart.GetItems())
            {
                item.Product.Quantity -= item.Quantity;
            }
            customer.Balance -= total;

            if (toShip.Any())
                ShippingService.Ship(toShip);

            Console.WriteLine("** Checkout receipt **");
            foreach (var item in cart.GetItems())
                Console.WriteLine($"{item.Quantity}x {item.Product.Name} \t{item.Product.Price * item.Quantity}");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal \t{subtotal}");
            Console.WriteLine($"Shipping \t{shippingCost}");
            Console.WriteLine($"Amount \t\t{total}");
            Console.WriteLine($"Remaining Balance: {customer.Balance}\n");
        }
    }
}
