using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new()
            {
                UserName = "Antonio",
                EmailAdress = "antonio@mail.com",
                Password = "1234",
                GivenName = "Antuan",
                Surename = "Tomas",
                Role = "Admin"
            },

            new()
            {
                UserName = "Araceli",
                EmailAdress = "araceli@mail.com",
                Password = "Hola",
                GivenName = "Ara",
                Surename = "Adsuar",
                Role = "Standard"
            }
        };
    }
}
