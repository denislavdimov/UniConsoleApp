namespace Uni.Bikes.DownhillBike
{
    public interface IDownhillService
    {
        void Add();
        void ShowDownhillStatistics();
        void SellBike();
        List<Downhill> GetListOfAllDownhills();
        int numberOfSells { get; }
    }
}