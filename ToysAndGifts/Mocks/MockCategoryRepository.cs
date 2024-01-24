using ToysAndGifts.Interfaces;
using ToysAndGifts.Models;

namespace ToysAndGifts.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                         new Category { CategoryName = "Above5Years", Description = "Allowed for kids above 5years" },
                         new Category { CategoryName = "Below5Years", Description = "Allowed for babies and toddlers" }
                     };
            }
        }
}
