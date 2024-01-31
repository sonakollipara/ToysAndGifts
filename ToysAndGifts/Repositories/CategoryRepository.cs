using ToysAndGifts.Data;
using ToysAndGifts.Interfaces;
using ToysAndGifts.Models;

namespace ToysAndGifts.Repositories
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly AppDbContext _appDbContext;

		public CategoryRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Category> Categories => _appDbContext.Categories;
	}
}
