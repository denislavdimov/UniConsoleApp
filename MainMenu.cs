using System.Data;
using Uni.Bikes.EnduroBike;
using Uni.Customer;
using static System.Console;

namespace Uni
{
    public class MainMenu
    {
        private ICustomerService _customer;
        private IEnduroService _enduro;

        private Dictionary<int, string> MenuOptions = new Dictionary<int, string>()
                {
                    { 1, "1. Sell stock" },
                    { 2, "2. Availability" },
                    { 3, "3. Customer Statistics" },
                    { 4, "4. Store Statistics" },
                    { 5, "5. Add new bike" },
                    { 6, "6. Create new customer" },
                    { 7, "7. Back" },
                    { 8, "8. Exit" }
                };

        public MainMenu(ICustomerService customer, IEnduroService enduro)
        {
            _customer = customer;
            _enduro = enduro;
        }

        public void Menu()
        {
            string title = "BIKE STORE";
            WriteLine(title);

            WriteLine(MenuOptions[1]);
            WriteLine(MenuOptions[2]);
            WriteLine(MenuOptions[3]);
            WriteLine(MenuOptions[4]);
            WriteLine(MenuOptions[5]);
            WriteLine(MenuOptions[6]);
            WriteLine(MenuOptions[7]);
            WriteLine(MenuOptions[8]);
        }

        public void SelectOption()
        {

            string option = ReadLine();

            while (option != "8")
            {
                switch (option)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":
                        Clear();
                        WriteLine("Select what bike to add:");
                        WriteLine("1 - for Enduro");
                        WriteLine("2 - for Downhill");
                        string select = ReadLine();
                        if (select == "1")
                        {
                            _enduro.Add();
                            _enduro.ShowEnduroStatistics();
                        }
                        else
                        {
                            // downhil
                        }
                        break;

                    case "6":
                        _customer.Add();
                        _customer.ShowAllCustomers();
                        WriteLine("Press: 7 to navigate back");
                        break;

                    case "7":
                        Clear();
                        Menu();

                        break;

                    default:
                        WriteLine("Select a valid option");
                        Thread.Sleep(1000);
                        break;
                }

                WriteLine("Select a option");
                option = ReadLine();
            }
        }
    }
}
