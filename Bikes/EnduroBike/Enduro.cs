namespace Uni.Bikes.EnduroBike
{
    public class Enduro : BikeModels
    {
        public override decimal Price { get; set; }
        public override char Quantity { get; set; }
        public override string Category { get; set; }
        public override string WheelSize { get; set; }
        public string XC { get; set; }
        public string AM { get; set; }
        public string HE { get; set; }
    }
}
