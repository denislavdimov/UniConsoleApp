using static System.Console;

namespace Uni.Bikes.DownhillBike
{
    public class DownhillService : IDownhillService
    {
        private readonly List<Downhill> _listOfAllDownhills;
        public List<Downhill> GetListOfAllDownhills() => _listOfAllDownhills;
        public int numberOfSells { get; set; }

        public DownhillService()
        {
            _listOfAllDownhills = new List<Downhill>();
        }

        public void Add()
        {
            Clear();
            var newDh = new Downhill();
            WriteLine("Fill in Price for the Downhill bike:");
            newDh.Price = decimal.Parse(ReadLine());

            WriteLine("Fill in Category for the Downhill bike: 200 or 220");

            var category = ReadLine();
            while (category != "200" && category != "220")
            {
                WriteLine("Enter correct category!");
                category = ReadLine();
            }
            newDh.Category = (DownhillCategories)int.Parse(category);

            WriteLine("Fill in WheelSize for the Downhill bike:");
            newDh.WheelSize = ReadLine();
            _listOfAllDownhills.Add(newDh);
        }

        public void ShowDownhillStatistics()
        {
            WriteLine($"List of all Downhill models: {_listOfAllDownhills.Count}");
            foreach (var catQuantity in _listOfAllDownhills)
            {
                var specificCategoryCount = _listOfAllDownhills.Where(c => catQuantity.Category == c.Category).Count();
                WriteLine($"Category: {catQuantity.Category} - {specificCategoryCount}");
            }
            WriteLine("--------------------------------------------");
            foreach (var downhill in _listOfAllDownhills)
            {
                Write($"Category: {downhill.Category}, ");
                Write($"Price: {downhill.Price}, ");
                WriteLine($"WheelSize: {downhill.WheelSize}");
            }
            WriteLine("--------------------------------------------");
        }

        public void SellBike()
        {
            WriteLine("Select category to sell: 200 or 220.");
            string cat = ReadLine();
            while (cat != "200" && cat != "220")
            {
                WriteLine("Enter correct category!");
                cat = ReadLine();
            }

            try
            {
                var downhillToSell = _listOfAllDownhills.First(b => b.Category == (DownhillCategories)int.Parse(cat));
                _listOfAllDownhills.Remove(downhillToSell);
                WriteLine("Downhill is successfully removed from the list.");
                numberOfSells++;
            }
            catch (InvalidOperationException)
            {
                WriteLine($"There is not available {cat}'s model right now.");
            }

            WriteLine("-------------––––------------------------------------");
            if (numberOfSells > 0)
            {
                WriteLine($"Number of Downhill sells: {numberOfSells}");
                WriteLine("-------------––––------------------------------------");
            }
            WriteLine("Availability");
            ShowDownhillStatistics();
        }
    }
}
