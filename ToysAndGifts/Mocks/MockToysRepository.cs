using ToysAndGifts.Interfaces;
using ToysAndGifts.Models;

namespace ToysAndGifts.Mocks
{
    public class MockToysRepository : IToysRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Toys> Toys
        {
            get
            {
                return new List<Toys>
                {
                    new Toys {
                        Name = "Crossword",
                        Price = 7.95M, ShortDescription = "The most widely used game for learning english",
                        LongDescription = "Crossword is a good game 2 to 4 players can play, very interesting game, 2 to 4 people can play, there is no age limit for this game, anyone can play.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = true,
                        IsPreferredToy = true,
                        ImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                    },
                    new Toys {
                        Name = "Ludo and Snake-Ladder",
                        Price = 12.95M, ShortDescription = "Very interesting game for kids aged above 8 years.",
                        LongDescription = "The board contains two games, both games can be played by 2 to 4 players.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/rumCokeL.jpg",
                        InStock = true,
                        IsPreferredToy = false,
                        ImageThumbnailUrl = "http://imgh.us/rumAndCokeS.jpg"
                    },
                    new Toys {
                        Name = "Mec-O-Tec ",
                        Price = 12.95M, ShortDescription = "It is purely a mechanix game.",
                        LongDescription = "Very good game it is played by ne person , should be innovatively thought and played , it can be used to create bikes and cars using metal parts.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "http://imgh.us/tequilaL.jpg",
                        InStock = true,
                        IsPreferredToy = false,
                        ImageThumbnailUrl = "http://imgh.us/tequilaS.jpg"
                    },
                    new Toys
                    {
                        Name = "Punch Hammer ",
                        Price = 12.95M,
                        ShortDescription = "Useful for kids below 5 years.",
                        LongDescription = "Very good toy foor toddlers and infants, Can identity colours and shapes, Very good hand grip for hitting like a hammer, as the ball falls down kids will enjoy alot.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "http://imgh.us/juiceL.jpg",
                        InStock = true,
                        IsPreferredToy = false,
                        ImageThumbnailUrl = "http://imgh.us/juiceS.jpg"
                    }
                };
            }
        }
        public IEnumerable<Toys> PreferredToys { get; }
        public Toys GetToysById(int drinkId)
        {
            throw new NotImplementedException();
        }

    }
}
