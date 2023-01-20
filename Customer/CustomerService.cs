using static System.Console;

namespace Uni.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _listOfAllCustomers;

        public CustomerService()
        {
            _listOfAllCustomers = new List<Customer>();
        }

        public void Add()
        {
            Clear();
            var customer = new Customer();
            WriteLine("Fill in Name for the customer:");
            customer.Name = ReadLine()!;

            WriteLine("Fill in Number for the customer:");
            customer.Number = int.Parse(ReadLine());
            while (_listOfAllCustomers.Any(c => c.Number == customer.Number))
            {
                WriteLine("There is a customer with that number. Please enter different.");
                customer.Number = int.Parse(ReadLine());
            }

            _listOfAllCustomers.Add(customer);
        }

        public void ShowAllCustomers()
        {
            WriteLine($"List of all customers: {_listOfAllCustomers.Count}");
            foreach (var customer in _listOfAllCustomers)
            {
                WriteLine(customer.Name);
            }
        }
    }
}
