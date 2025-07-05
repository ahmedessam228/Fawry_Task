namespace Fawry_Task
{
    public class ShippableExpiringProduct : ExpiringProduct , IShippable
    {
        public double Weight { get; set; }
        public ShippableExpiringProduct(string name, double price , double quantity , DateTime expriy , double weight)
            : base(name, price, quantity, expriy)
        {
            Weight = weight;
        }
        public override bool NeedsShipping() => true;
        public string GetName() => Name;
        public double GetWeight() => Weight;
    }
}
