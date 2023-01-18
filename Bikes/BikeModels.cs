namespace Uni.Bikes
{
    public abstract class BikeModels
    {
        public abstract decimal Price { get; set; }
        public abstract char Quantity { get; set; }
        public abstract string Category { get; set; }
        public abstract string WheelSize { get; set; }

    }
}
