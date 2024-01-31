using ToysAndGifts.Data;
using ToysAndGifts.Interfaces;
using ToysAndGifts.Models;

namespace ToysAndGifts.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly AppDbContext _appDbContext;

        public OrderRepository(AppDbContext appDbContext,ShoppingCart shoppingCart)
        {
            
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Order.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var placedOrder = new OrderDetail()
                {
                    Amount = item.Amount,                   
                    ToyId = item.Toys.ToyId,
                    OrderId = order.OrderId,
                    Price = item.Toys.Price
                };

                _appDbContext.OrderDetail.Add(placedOrder);
            }

            _appDbContext.SaveChanges();
        }
    }
}
