namespace Uni.Bikes.EnduroBike
{
    public interface IEnduroService
    {
        void Add();
        void ShowEnduroStatistics();
        void SellBike();
        List<Enduro> GetListOfAllEnduros();
        int numberOfSells { get; }
    }
}