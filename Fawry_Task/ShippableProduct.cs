using System;
namespace Fawry_Task
{
    public class ShippableProduct : Product , IShippable
    {
        public double Weight { get; set; }
        public ShippableProduct(string name, double price, double quantity, double weight) 
            : base(name,price,quantity)
        {
            Weight = weight;
        }
        public override bool NeedsShipping() => true;
        public string GetName() => Name;
        public double GetWeight() => Weight;
    }
}
