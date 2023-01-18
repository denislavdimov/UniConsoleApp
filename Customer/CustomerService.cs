using static System.Console;

namespace Uni.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _listOfAllCustomers;
        private Customer _customer;

        public CustomerService()
        {
            _listOfAllCustomers = new List<Customer>();
            _customer = new Customer();
        }

        public bool Validate()
        {
            var isValid = true;
            if (_customer.Name == null) isValid = false;
            if (_customer.Number < 0) isValid = false;

            return isValid;
        }

        public void Add()
        {
            Clear();
            WriteLine("Fill in Name for the customer:");
            _customer.Name = ReadLine()!;
            WriteLine("Fill in Number for the customer:");
            _customer.Number = int.Parse(ReadLine()!);
            _listOfAllCustomers.Add(_customer);
        }

        public void ShowAllCustomers()
        {
            WriteLine($"List of all customers: {_listOfAllCustomers.Count}");
            foreach (var customer in _listOfAllCustomers)
            {
                WriteLine(customer);
            }
        }
    }
}
