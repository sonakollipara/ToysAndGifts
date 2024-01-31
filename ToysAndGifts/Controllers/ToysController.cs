using Microsoft.AspNetCore.Mvc;
using ToysAndGifts.Data;
using ToysAndGifts.Interfaces;
using ToysAndGifts.Models;
using ToysAndGifts.ViewModels;

namespace ToysAndGifts.Controllers
{
    public class ToysController : Controller
    {   
        private readonly IToysRepository _toysRepository;   
        private readonly ICategoryRepository _categoryRepository;
		private readonly AppDbContext _appDbContext;

		public ToysController(IToysRepository toysRepository, ICategoryRepository categoryRepository, AppDbContext appDbContext)
        {
            _toysRepository = toysRepository;
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;
        }
        
       

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Toys> toys;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                toys = _toysRepository.Toys.OrderBy(p => p.ToyId);
                currentCategory = "All Toys";
            }
            else
            {
                if (string.Equals("Above5Years", _category, StringComparison.OrdinalIgnoreCase))
                    toys = _toysRepository.Toys.Where(p => p.Category.CategoryName.Equals("Above5Years")).OrderBy(p => p.Name);
                else
                    toys = _toysRepository.Toys.Where(p => p.Category.CategoryName.Equals("Below5Years")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new ToysListViewModel
            {
                Toys = toys,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Index()
        {
            var viewresult = _appDbContext.Toys;
            return View(viewresult);
        }
    }
}
