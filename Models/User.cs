namespace MinimalJwt.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public string GivenName { get; set; }
        public string Surename { get; set; }    
        public string Role { get; set; }
    }
}
