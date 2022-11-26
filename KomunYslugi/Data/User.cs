using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace KomunYslugi.Data
{
    public class Customer
    {
        [BsonId]
        public ObjectId _id;
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }
        public Customer(string login, string password, string email, string fullName, string phoneNumber, string department)
        {
            Login = login;
            Password = password;
            Email = email;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Department = department;
        }
    }
}
