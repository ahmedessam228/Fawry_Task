namespace Fawry_Task
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        protected Product(string name , double price , double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public virtual bool IsExpired() => false;
        public virtual bool NeedsShipping() => false;
    }
}
