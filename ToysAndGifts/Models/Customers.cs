using System.ComponentModel.DataAnnotations;

namespace ToysAndGifts.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
