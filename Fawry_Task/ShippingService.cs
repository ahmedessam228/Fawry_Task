namespace Fawry_Task
{
    public class ShippingService
    {
        public static void Ship(List<IShippable> items)
        {
            Console.WriteLine("** Shipment notice **");
            double totalWeight = 0;
            var groubed = items.GroupBy(item => item.GetName());
            foreach (var group in groubed)
            {
                double weight = group.First().GetWeight() * group.Count();
                Console.WriteLine($"{group.Count()}x {group.Key} \t{weight * 1000}g");
                totalWeight += weight;
            }
            Console.WriteLine($"Total package weight {totalWeight}kg\n");
        }
    }
}