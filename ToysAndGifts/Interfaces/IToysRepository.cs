using ToysAndGifts.Models;

namespace ToysAndGifts.Interfaces
{
    public interface IToysRepository
    {
        IEnumerable<Toys> Toys { get; }
        IEnumerable<Toys> PreferredToys { get; }
        Toys GetToysById(int toysId);
    }
}
