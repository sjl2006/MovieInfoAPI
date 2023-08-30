using MovieInfoAPI.Models;

namespace MovieInfoAPI
{
    public class MoviesDataStore
    {
        public List<Movie> Movies { get; set; }
        public static MoviesDataStore Current { get; } = new MoviesDataStore();

        public MoviesDataStore()
        {
            // init dummy data
            Movies = new List<Movie>()
            {
                new Movie()
                {
                     MovieId = 1,
                     MovieName = "Barbie",
                     Provider = "CinemaWorld",
                     Price = 10

                },
                new Movie()
                {
                     MovieId = 2,
                     MovieName = "Barbie",
                     Provider = "FilmWord",
                     Price = 15
                },
                new Movie()
                {
                     MovieId = 3,
                     MovieName = "BlackBerry",
                     Provider = "CinemaWorld",
                     Price = 20
                },
                new Movie()
                {
                     MovieId = 4,
                     MovieName = "BlackBerry",
                     Provider = "FilmWord",
                     Price = 25
                }
            };

        }

    }
}
