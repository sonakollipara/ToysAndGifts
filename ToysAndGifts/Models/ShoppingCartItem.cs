namespace ToysAndGifts.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Toys Toys { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
