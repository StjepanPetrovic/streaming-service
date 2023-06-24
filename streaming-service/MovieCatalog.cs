using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streaming_service
{
    internal class MovieCatalog
    {
        public List<WatchedMovie> WatchedMovies { get; set; } = new List<WatchedMovie>();

        public List<Movie> Movies { get; set; } = new List<Movie>
        { 
            new Movie
            {
                Id = 1,
                Name = "Batman",
            },

            new Movie
            {
                Id = 2,
                Name = "Superman",
            },

            new Movie
            {
                Id = 3,
                Name = "Spiderman",
            },

            new Movie
            {
                Id = 4,
                Name = "Ironman",
            },

            new Movie
            {
                Id = 5,
                Name = "Hulk",
            },
        };

        public List<Movie> GetMovies()
        {
            return Movies;
        }

        public List<WatchedMovie> GetWatchedMovies()
        {
            return WatchedMovies;
        }

        public void AddWatchedMovie(WatchedMovie watchedMovie)
        {
            WatchedMovies.Add(watchedMovie);
        }
    }
}
