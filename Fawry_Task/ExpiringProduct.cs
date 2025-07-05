namespace Fawry_Task
{
    public class ExpiringProduct : Product
    {
        public DateTime ExpiryDate { get; set; }
        public ExpiringProduct(string name, double price, double quantity, DateTime expiryDate)
            : base(name, price, quantity)
        {
            ExpiryDate = expiryDate;
        }
        public override bool IsExpired() => DateTime.Now > ExpiryDate;
    }
}
