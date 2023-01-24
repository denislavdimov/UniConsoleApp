using Uni.Bikes;
using Uni.Bikes.DownhillBike;
using Uni.Bikes.EnduroBike;
using Uni.Customer;
using static System.Console;

namespace Uni
{
    public class MainMenu
    {
        private readonly ICustomerService _customer;
        private readonly IEnduroService _enduro;
        private readonly IDownhillService _downhill;

        private Dictionary<int, string> MenuOptions = new Dictionary<int, string>()
                {
                    { 1, "1. Sell bike" },
                    { 2, "2. Availability" },
                    { 3, "3. Store Statistics" },
                    { 4, "4. Add new bike" },
                    { 5, "5. Create new customer" },
                    { 6, "6. Back" },
                    { 7, "7. Exit" }
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
            var optionsCount = MenuOptions.Keys.Count;
            while (option != optionsCount.ToString())
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
                            WriteLine($"Press {optionsCount - 1} to navigate back " +
                                $"and {optionsCount} to exit.");
                        }
                        else if (bike == "2")
                        {
                            Clear();
                            _downhill.SellBike();
                            WriteLine($"Press {optionsCount - 1} to navigate back " +
                                $"and {optionsCount} to exit.");
                        }
                        break;

                    case "2":
                        Clear();
                        _enduro.ShowEnduroStatistics();
                        WriteLine();
                        WriteLine("***********************************************");
                        WriteLine();
                        _downhill.ShowDownhillStatistics();
                        WriteLine($"Press {optionsCount - 1} to navigate back " +
                            $"and {optionsCount} to exit.");
                        break;

                    case "3":
                        Clear();
                        StoreStatistics.ShowAll(_enduro.GetListOfAllEnduros(), _downhill.GetListOfAllDownhills());
                        WriteLine($"Number of Enduro sells: {_enduro.numberOfSells}");
                        WriteLine($"Number of Downhill sells: {_downhill.numberOfSells}");
                        WriteLine($"Press {optionsCount - 1} to navigate back " +
                            $"and {optionsCount} to exit.");
                        break;

                    case "4":
                        Clear();
                        string bikeOption = SelectBikeModel();
                        if (bikeOption == "1")
                        {
                            _enduro.Add();
                            Clear();
                            _enduro.ShowEnduroStatistics();
                            WriteLine($"Press {optionsCount - 1} to navigate back " +
                                $"and {optionsCount} to exit.");
                        }
                        else if (bikeOption == "2")
                        {
                            _downhill.Add();
                            Clear();
                            _downhill.ShowDownhillStatistics();
                            WriteLine($"Press {optionsCount - 1} to navigate back " +
                                $"and {optionsCount} to exit.");
                        }
                        break;

                    case "5":
                        _customer.Add();
                        _customer.ShowAllCustomers();
                        WriteLine($"Press {optionsCount - 1} to navigate back " +
                            $"and {optionsCount} to exit.");
                        break;

                    case "6":
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
