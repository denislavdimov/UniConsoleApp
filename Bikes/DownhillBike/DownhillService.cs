using static System.Console;

namespace Uni.Bikes.DownhillBike
{
    public class DownhillService : IDownhillService
    {
        private readonly List<Downhill> _listOfAllDownhills;

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
    }
}
