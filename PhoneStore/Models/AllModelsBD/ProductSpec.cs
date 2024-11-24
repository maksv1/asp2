namespace PhoneStore.Models.AllModelsBD
{
    public class ProductSpec
    {
        public int Id { get; set; }
        public string? SpecName { get; set; }
        public string? SpecValue { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
