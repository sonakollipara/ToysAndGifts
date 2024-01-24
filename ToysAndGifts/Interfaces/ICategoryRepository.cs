using ToysAndGifts.Models;

namespace ToysAndGifts.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
