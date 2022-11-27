using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace KomunYslugi.Data
{
    public class Designer
    {
        [BsonId]
        public ObjectId _id;
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string PhoneNumber { get; set; }
        [BsonIgnoreIfNull]
        public string DesignerName { get; set; }
        [BsonIgnoreIfNull]
        public int OGRN { get; set; }
        [BsonIgnoreIfNull]
        public int INN { get; set; }
        [BsonIgnoreIfNull]
        public int KPP { get; set; }
        [BsonIgnoreIfNull]
        public string Address { get; set; }
        [BsonIgnoreIfNull]
        public string FullNameDirector { get; set; }
        [BsonIgnoreIfNull]
        public string ChiefProjectEngineer { get; set; }
        public Designer(string email, string password, string login, string phoneNumber)
        {
            Email = email;
            Password = password;
            Login = login;
            PhoneNumber = phoneNumber;
        }
    }
}
