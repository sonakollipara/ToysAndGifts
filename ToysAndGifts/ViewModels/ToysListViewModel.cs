using ToysAndGifts.Models;

namespace ToysAndGifts.ViewModels
{
	public class ToysListViewModel
	{
		public IEnumerable<Toys> Toys { get; set; }
        public string CurrentCategory { get; set; }

    }
}
