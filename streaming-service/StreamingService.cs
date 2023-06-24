using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streaming_service
{
    internal class StreamingService
    {
        MovieCatalog movieCatalog = new MovieCatalog();

        public List<Movie> getUnwatchedMovies()
        {
            List<WatchedMovie> watchedMovies = movieCatalog.GetWatchedMovies();
            List<Movie> unwatchedMovies = movieCatalog.GetMovies();

            foreach (WatchedMovie watchedMovie in watchedMovies)
            {
                Movie movie = unwatchedMovies.Find(x => x.Id == watchedMovie.Id);
                unwatchedMovies.Remove(movie);
            }

            return unwatchedMovies;
        }

        public void watchMovie(Movie movie)
        {
            WatchedMovie watchedMovie = new WatchedMovie
            {
                Id = movie.Id,
                WatchingDate = DateTime.Now,
            };

            movieCatalog.AddWatchedMovie(watchedMovie);
        }
    }
}
