using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ThemeDoraemon.ThemeCharacters;
using System;
using System.Linq;

namespace ThemeDoraemon.ThemeCharacters
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ThemeDoraemoncharacterContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ThemeDoraemoncharacterContext>>()))
            {
                // Look for any movies.
                if (context.character.Any())
                {
                    return;   // DB has been seeded
                }

                context.character.AddRange(
                    new character
                    {
                        Character_Name = "Doraemon",
                        Favorite_Colour = "Blue",
                        Favorite_Food = "Dorayaki",
                        Birth_Date = DateTime.Parse("2112-09-03")
                    },

                    new character
                    {                     
			Character_Name = "Nobita Nobi",
                        Favorite_Colour = "Yellow",
                        Favorite_Food = "Pancakes",
                        Birth_Date = DateTime.Parse("1989-2-12")
                    },

                    new character
                    {                     
			Character_Name = "Shizuka Minamoto",
                        Favorite_Colour = "Pink",
                        Favorite_Food = "Roasted Sweet Potatoes",
                        Birth_Date = DateTime.Parse("1999-05-08")
                    },

                    new character
                    {
			Character_Name = "Takeshi Gouda",
                        Favorite_Colour = "Orange",
                        Favorite_Food = "Stuffed Capsicum",
                        Birth_Date = DateTime.Parse("2000-06-07")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}




















