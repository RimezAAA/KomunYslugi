using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace KomunYslugi.Data
{
    public class Customer
    {
        [BsonId]
        public ObjectId _id;
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }

        public Customer(string fullName, string email, string password, string login, string phoneNumber, string department)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Login = login;
            PhoneNumber = phoneNumber;
            Department = department;
        }
    }
}
