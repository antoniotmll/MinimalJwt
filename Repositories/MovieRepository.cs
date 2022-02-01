using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new()
            {
                Id = 1,
                Title = "Eternals",
                Description = "Description of Eternals movie",
                Rating = 6.8
            },            
            
            new()
            {
                Id = 2,
                Title = "Hereditary",
                Description = "Description of Hereditary movie",
                Rating = 9
            },

            new()
            {
                Id = 3,
                Title = "El Resplandor",
                Description = "Description of El Resplandor movie",
                Rating = 8.5
            },

            new()
            {
                Id = 4,
                Title = "Borat",
                Description = "Description of Borat movie",
                Rating = 7.3
            }
        };
    }
}
