using System.Data;
using Uni.Bikes.DownhillBike;
using Uni.Bikes.EnduroBike;
using Uni.Customer;
using static System.Console;

namespace Uni
{
    public class MainMenu
    {
        private ICustomerService _customer;
        private IEnduroService _enduro;
        private IDownhillService _downhill;

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

        public MainMenu(ICustomerService customer, IEnduroService enduro, IDownhillService downhill)
        {
            _customer = customer;
            _enduro = enduro;
            _downhill = downhill;
        }

        public void Menu()
        {
            WriteLine("******BIKE STORE******");

            WriteLine(MenuOptions[1]);
            WriteLine(MenuOptions[2]);
            WriteLine(MenuOptions[3]);
            WriteLine(MenuOptions[4]);
            WriteLine(MenuOptions[5]);
            WriteLine(MenuOptions[6]);
            WriteLine(MenuOptions[7]);
            WriteLine(MenuOptions[8]);
        }

        public string SelectBikeModel()
        {
            WriteLine("Select 1 for enduro and 2 for downhill");
            string bike = ReadLine();
            while (bike != "1" && bike != "2")
            {
                WriteLine("Enter correct option!");
                bike = ReadLine();
            }
            return bike;
        }

        public void SelectOption()
        {
            string option = ReadLine();

            while (option != "8")
            {
                switch (option)
                {
                    case "1":
                        Clear();
                        string bike = SelectBikeModel();
                        if (bike == "1")
                        {
                            Clear();
                            _enduro.SellBike();
                            WriteLine("Press 7 to navigate back and 8 to exit.");
                        }
                        else if (bike == "2")
                        {
                            Clear();
                            _downhill.SellBike();
                            WriteLine("Press 7 to navigate back and 8 to exit.");
                        }
                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":
                        Clear();
                        _enduro.ShowEnduroStatistics();
                        WriteLine();
                        WriteLine("***********************************************");
                        WriteLine();
                        _downhill.ShowDownhillStatistics();
                        WriteLine("Press 7 to navigate back and 8 to exit.");
                        break;

                    case "5":
                        Clear();
                        string bikeOption = SelectBikeModel();
                        if (bikeOption == "1")
                        {
                            _enduro.Add();
                            Clear();
                            _enduro.ShowEnduroStatistics();
                            WriteLine("Press 7 to navigate back and 8 to exit.");
                        }
                        else if (bikeOption == "2")
                        {
                            _downhill.Add();
                            Clear();
                            _downhill.ShowDownhillStatistics();
                            WriteLine("Press 7 to navigate back and 8 to exit.");
                        }
                        break;

                    case "6":
                        _customer.Add();
                        _customer.ShowAllCustomers();
                        WriteLine("Press 7 to navigate back and 8 to exit.");
                        break;

                    case "7":
                        Clear();
                        Menu();
                        break;

                    default:
                        WriteLine("Select a valid option");
                        Thread.Sleep(500);
                        break;
                }
                WriteLine("Select an option");
                option = ReadLine();
            }
        }
    }
}
