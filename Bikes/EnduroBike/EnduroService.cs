using Uni.Customer;
using static System.Console;

namespace Uni.Bikes.EnduroBike
{
    public class EnduroService : IEnduroService
    {
        private readonly List<Enduro> _listOfAllEnduros;
        private Enduro _enduro;

        public EnduroService()
        {
            _listOfAllEnduros = new List<Enduro>();
            _enduro = new Enduro();
            _enduro.XC = "140";
            _enduro.AM = "160";
            _enduro.HE = "180";
        }

        public void Add()
        {
            Clear();
            WriteLine("Fill in Price for the Enduro bike:");
            _enduro.Price = decimal.Parse(ReadLine());

            WriteLine("Fill in Category for the Enduro bike: 140, 160 or 180");
            var cat = _enduro.Category = ReadLine();
            while (cat != _enduro.XC && cat != _enduro.AM && cat != _enduro.HE)
            {
                WriteLine("Enter correct category!");
                cat = _enduro.Category = ReadLine();
            }

            WriteLine("Fill in WheelSize for the Enduro bike:");
            _enduro.WheelSize = ReadLine();
            _listOfAllEnduros.Add(_enduro);
        }

        public void ShowEnduroStatistics()
        {
            var xCCategory = _listOfAllEnduros.Count(c => c.Category == c.XC);
            var aMCategory = _listOfAllEnduros.Count(c => c.Category == c.AM);
            var hECategory = _listOfAllEnduros.Count(c => c.Category == c.HE);

            List<string> list = new List<string>() { xCCategory.ToString(), aMCategory.ToString(), hECategory.ToString() };   

            WriteLine($"List of all Enduro models: {_listOfAllEnduros.Count}");
            WriteLine($"XC: {xCCategory}");
            WriteLine($"AM: {aMCategory}");
            WriteLine($"HE: {hECategory}");


            foreach (var enduro in _listOfAllEnduros)
            {
                var specificCategoryCount = _listOfAllEnduros.Where(c => enduro.Category == _enduro.Category).Count();
                //var try2 = list.FirstOrDefault(w => w.Equals(enduro.Category));
                WriteLine($"Category: {enduro.Category} - {specificCategoryCount}");
                WriteLine($"WheelSize: {enduro.WheelSize}");
                WriteLine($"Price: {enduro.Price}");
            }
        }
    }
}
