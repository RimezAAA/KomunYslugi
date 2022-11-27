using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace KomunYslugi.Data
{
    public class Developer
    {
        [BsonId]
        public ObjectId _id;
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string PhoneNumber { get; set; }
        [BsonIgnoreIfNull]
        public string DeveloperName { get; set; }
        [BsonIgnoreIfNull]
        public int OGRN { get; set; }
        [BsonIgnoreIfNull]
        public int INN { get; set; }
        [BsonIgnoreIfNull]
        public int KPP { get; set; }
        [BsonIgnoreIfNull]
        public string Address { get; set; }
        [BsonIgnoreIfNull]
        public string FullNameHead { get; set; }
        public Developer(string email, string password, string login, string phoneNumber)
        {
            Email = email;
            Password = password;
            Login = login;
            PhoneNumber = phoneNumber;
        }
    }
}
