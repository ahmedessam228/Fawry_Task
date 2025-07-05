namespace Fawry_Task
{
    public class Cart
    {
        private List<CartItem> items;
        public Cart()
        {
            items = new List<CartItem>();
        }
        public void AddItem(Product product , int quantity)
        {
            if (quantity > product.Quantity)
                Console.WriteLine($"Requested quantity of \"{product.Name}\" exceeds available stock ({product.Quantity}).");

            items.Add(new CartItem(product, quantity));
        }
        public List<CartItem> GetItems()=> items;
        public bool IsEmpty() => !items.Any();
    }
}
