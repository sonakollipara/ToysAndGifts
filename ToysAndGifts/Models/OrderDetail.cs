using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToysAndGifts.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }   
        public int OrderId { get; set; }
        public int ToyId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Toys Toys { get; set; }
        public virtual Order Order { get; set; }
    }
}
