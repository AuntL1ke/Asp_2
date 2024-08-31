using System;
using _02_home_asp.Pages.Models;

namespace _02_home_asp.Pages.Services
{
	public static class Restaurants
	{
		private static List<Restaurant> Items { get; set; }
		static Restaurants()
		{
			Items = new List<Restaurant>();

		}

        public static void SeedRestaurants()
        {
            Items = new List<Restaurant>()
        {
            new Restaurant()
            {
                Id = 1,
                Name="The Sapphire Spoon",
                Description = "An upscale dining destination, The Sapphire Spoon is known for its innovative approach to" +
                              " international cuisine. The restaurant blends global culinary traditions with contemporary techniques," +
                              " creating dishes that are both visually stunning and rich in flavor. Diners are treated to a menu" +
                              " that evolves with the seasons, complemented by a meticulously crafted wine list featuring selections" +
                              " from boutique vineyards and renowned wineries worldwide."
            },
            new Restaurant()
            {
                Id = 2,
                Name="Greenleaf Bistro",
                Description = "A cozy and eco-friendly eatery focusing on farm-to-table dining. Greenleaf Bistro" +
                              " offers a variety of fresh, organic, and locally sourced dishes, with a menu that caters to" +
                              " vegetarians, vegans, and those who appreciate sustainable food practices. The restaurant's warm" +
                              " atmosphere and earthy decor make it a perfect spot for a relaxed meal."
            },
            new Restaurant()
            {
                Id = 3,
                Name="Seaside Grille",
                Description = "Located right on the waterfront, Seaside Grille is a seafood lover's paradise." +
                              " This casual yet refined restaurant serves the freshest catches of the day, prepared with a" +
                              " touch of coastal flair. From grilled fish to succulent shellfish, every dish is crafted to" +
                              " highlight the natural flavors of the sea, all while guests enjoy stunning ocean views."
            },
            new Restaurant()
            {
                Id = 4,
                Name="Ember & Oak",
                Description = "Ember & Oak is a rustic-chic restaurant offering a farm-to-fire dining experience." +
                              " The menu celebrates the bounty of local farms with dishes cooked over an open flame, bringing out" +
                              " the rich, smoky flavors of high-quality ingredients. Guests can savor wood-fired meats, charred vegetables," +
                              " and artisanal flatbreads in a warm, inviting atmosphere that evokes the charm of countryside dining."
            }
        };
            }

    public static List<Restaurant> GetAll() => Items;

    public static Restaurant GetById(int id) => Items.FirstOrDefault(restaurant => restaurant.Id == id)!;
    }
}

