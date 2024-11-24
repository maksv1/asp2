using System;

namespace PhoneStore.Models.AllModelsBD
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
