using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbSetInitializer : DropCreateDatabaseAlways<MusicStoreDB>
    {
            protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });

            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Heavy D and the Boyz" },
                Genre = new Genre { Name = "Hip Hop" },
                Price = 9.99m,
                Title = "Peaceful Journey"
            });


            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "The Gap Band" },
                Genre = new Genre { Name = "Funk" },
                Price = 9.99m,
                Title = "The Gap Band IV"
            });


            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Greenday" },
                Genre = new Genre { Name = "American Punk" },
                Price = 9.99m,
                Title = "American Idiot"
            });

            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "The Gap Band" },
                Genre = new Genre { Name = "Funk" },
                Price = 9.99m,
                Title = "The Gap Band III"
            });

            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Dj Quik" },
                Genre = new Genre { Name = "Rap" },
                Price = 17.99m,
                Title = "Balance and Options"
            });


            base.Seed(context);
        }
    }
}