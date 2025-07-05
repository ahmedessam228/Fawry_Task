namespace Fawry_Task
{
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public Customer(string name , double balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
