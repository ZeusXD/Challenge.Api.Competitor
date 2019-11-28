namespace Challenge.Api.Competitor.Core.Models
{
    public class Competer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool Marker { get; set; }
        public Brand Brand { get; set; }
        // public PriceZone PriceZone { get; set; }
    }
}