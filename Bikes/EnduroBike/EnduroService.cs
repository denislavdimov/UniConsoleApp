using static System.Console;

namespace Uni.Bikes.EnduroBike
{
    public class EnduroService : IEnduroService
    {
        private readonly List<Enduro> _listOfAllEnduros;

        public EnduroService()
        {
            _listOfAllEnduros = new List<Enduro>();
        }

        public void Add()
        {
            Clear();
            var newEnduro = new Enduro();
            WriteLine("Fill in Price for the Enduro bike:");
            newEnduro.Price = decimal.Parse(ReadLine());

            WriteLine("Fill in Category for the Enduro bike: 140, 160 or 180");

            var category = ReadLine();
            while (category != "140" && category != "160" && category != "180")
            {
                WriteLine("Enter correct category!");
                category = ReadLine();
            }
            newEnduro.Category = (EnduroCategories)int.Parse(category);

            WriteLine("Fill in WheelSize for the Enduro bike:");
            newEnduro.WheelSize = ReadLine();
            _listOfAllEnduros.Add(newEnduro);
        }

        public void ShowEnduroStatistics()
        {
            WriteLine($"List of all Enduro models: {_listOfAllEnduros.Count}");
            foreach (var catQuantity in _listOfAllEnduros)
            {
                var specificCategoryCount = _listOfAllEnduros.Where(c => catQuantity.Category == c.Category).Count();
                WriteLine($"Category: {catQuantity.Category} - {specificCategoryCount}");
            }
            WriteLine("--------------------------------------------");
            foreach (var enduro in _listOfAllEnduros)
            {
                Write($"Category: {enduro.Category}, ");
                Write($"Price: {enduro.Price}, ");
                WriteLine($"WheelSize: {enduro.WheelSize}");
            }
            WriteLine("--------------------------------------------");
        }
    }
}
