using Uni.Bikes;
using Uni.Bikes.EnduroBike;
using Uni.Customer;

namespace Uni
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = new MainMenu(new CustomerService(), new EnduroService());
            mainMenu.Menu();
            mainMenu.SelectOption();

            //int number = 0;

            //do
            //{
            //    Console.WriteLine("Select menu");
            //    int choice = int.Parse(Console.ReadLine());
            //    number = choice;
            //}
            //while (number <= 0 || number > menu.Count);
            //{
            //    Console.WriteLine(menu[number]);
            //}
        }
    }
}