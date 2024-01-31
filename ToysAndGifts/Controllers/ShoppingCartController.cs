using Microsoft.AspNetCore.Mvc;
using ToysAndGifts.Interfaces;
using ToysAndGifts.Models;
using ToysAndGifts.ViewModels;

namespace ToysAndGifts.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IToysRepository _toysRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IToysRepository toysRepository, ShoppingCart shoppingCart)
        {
            _toysRepository = toysRepository;
            _shoppingCart = shoppingCart;
        }



        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),
            };
            return View(sCVM); 
        }

        public RedirectToActionResult AddToShoppingCart(int toysId)
        {
            var selectedToy = _toysRepository.Toys.FirstOrDefault(p => p.ToyId == toysId);
            if (selectedToy != null)
            {
                _shoppingCart.AddToCart(selectedToy, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int toysId)
        {
            var selectedToy = _toysRepository.Toys.FirstOrDefault(p => p.ToyId == toysId);
            if (selectedToy != null)
            {
                _shoppingCart.RemoveFromCart(selectedToy);
            }
            return RedirectToAction("Index");
        }
    }
}
