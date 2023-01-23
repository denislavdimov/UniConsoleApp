using Uni.Bikes.DownhillBike;
using Uni.Bikes.EnduroBike;
using Uni.Customer;

namespace Uni
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new MainMenu(new CustomerService(), new EnduroService(), new DownhillService());
            mainMenu.Menu();
            mainMenu.SelectOption();

        }
    }
}