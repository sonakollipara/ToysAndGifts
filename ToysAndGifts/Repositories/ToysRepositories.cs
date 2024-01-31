using Microsoft.EntityFrameworkCore;
using ToysAndGifts.Data;
using ToysAndGifts.Interfaces;
using ToysAndGifts.Models;

namespace ToysAndGifts.Repositories
{
	public class ToysRepositories : IToysRepository
	{
		private readonly AppDbContext _appDbContext;

		public ToysRepositories(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Toys> Toys => _appDbContext.Toys.Include(c => c.Category);

		public IEnumerable<Toys> PreferredToys => _appDbContext.Toys.Where(p => p.IsPreferredToy).Include(c => c.Category);

		public Toys GetToysById(int toysId) => _appDbContext.Toys.FirstOrDefault(p => p.ToyId == toysId);
		
	}
}
