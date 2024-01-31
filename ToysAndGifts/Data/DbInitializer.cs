using ToysAndGifts.Models;

namespace ToysAndGifts.Data
{
	public class DbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			//AppDbContext context =
			//applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

				context.Database.EnsureCreated();

				if (!context.Toys.Any())
				{
					context.AddRange(
						new Toys
						{
							Name = "Crossword",
							Price = 7.95M,
							ShortDescription = "The most widely used game for learning english",
							LongDescription = "Crossword is a good game 2 to 4 players can play, very interesting game, 2 to 4 people can play, there is no age limit for this game, anyone can play.",
							Category = Categories["Above5Years"],
							ImageUrl = "https://github.com/sonakollipara/ToysAndGifts/blob/master/ToysAndGifts/Project%20Images/CrossWord.jpg?raw=true",
							InStock = true,
							IsPreferredToy = true,
							ImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
						},
						new Toys
						{
							Name = "Ludo and Snake-Ladder",
							Price = 12.95M,
							ShortDescription = "Very interesting game for kids aged above 8 years.",
							LongDescription = "The board contains two games, both games can be played by 2 to 4 players.",
							Category = Categories["Above5Years"],
							ImageUrl = "https://github.com/sonakollipara/ToysAndGifts/blob/master/ToysAndGifts/Project%20Images/LudoSnake.jpg?raw=true",
							InStock = true,
							IsPreferredToy = true,
							ImageThumbnailUrl = "http://imgh.us/rumAndCokeS.jpg"
						},
						new Toys
						{
							Name = "Mec-O-Tec ",
							Price = 12.95M,
							ShortDescription = "It is purely a mechanix game.",
							LongDescription = "Very good game it is played by ne person , should be innovatively thought and played , it can be used to create bikes and cars using metal parts.",
							Category = Categories["Above5Years"],
							ImageUrl = "https://github.com/sonakollipara/ToysAndGifts/blob/master/ToysAndGifts/Project%20Images/Mec-O-Tec.jpeg?raw=true",
							InStock = true,
							IsPreferredToy = true,
							ImageThumbnailUrl = "http://imgh.us/tequilaS.jpg"
						},
						new Toys
						{
							Name = "Punch Hammer ",
							Price = 12.95M,
							ShortDescription = "Useful for kids below 5 years.",
							LongDescription = "Very good toy foor toddlers and infants, Can identity colours and shapes, Very good hand grip for hitting like a hammer, as the ball falls down kids will enjoy alot.",
							Category = Categories["Below5Years"],
							ImageUrl = "https://github.com/sonakollipara/ToysAndGifts/blob/master/ToysAndGifts/Project%20Images/HammerToy.jpg?raw=true",
							InStock = true,
							IsPreferredToy = true,
							ImageThumbnailUrl = "http://imgh.us/juiceS.jpg"
						}
						);
				}
				context.SaveChanges();
			}
			
			//context.SaveChanges();
		}
		private static Dictionary<string, Category> categories;
		public static Dictionary<string, Category> Categories
		{
			get
			{
				if (categories == null)
				{
					var genresList = new Category[]
					{
				new Category { CategoryName = "Above5Years", Description="Allowed for kids above 5years" },
				new Category { CategoryName = "Below5Years", Description="Allowed for babies and toddlers" }
					};

					categories = new Dictionary<string, Category>();

					foreach (Category genre in genresList)
					{
						categories.Add(genre.CategoryName, genre);
					}
				}

				return categories;
			}
		}
	}
}
