namespace KomunYslugi.Data
{
    public class UserService
    {
        public Customer customer { get; set; }
        public Designer designer { get; set; }
        public Developer developer { get; set; }
        public bool authorizationCheck { get; set; }
    }
}
