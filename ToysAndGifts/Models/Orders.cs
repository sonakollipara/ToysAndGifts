using System.ComponentModel.DataAnnotations;

namespace ToysAndGifts.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
