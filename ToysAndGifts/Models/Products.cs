using System.ComponentModel.DataAnnotations;

namespace ToysAndGifts.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

    }
}
