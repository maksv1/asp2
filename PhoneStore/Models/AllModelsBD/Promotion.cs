namespace PhoneStore.Models.AllModelsBD
{
    public class Promotion
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
    }
}
