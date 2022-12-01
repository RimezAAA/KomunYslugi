using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KomunYslugi.Data
{
    public class User
    {
        [BsonId]
        public ObjectId _id;
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
        //Customer
        [BsonIgnoreIfNull]
        public string FullName { get; set; }
        [BsonIgnoreIfNull]
        public string Department { get; set; }
        //Designer
        [BsonIgnoreIfNull]
        public string DesignerName { get; set; }
        [BsonIgnoreIfNull]
        public string FullNameDirector { get; set; }
        [BsonIgnoreIfNull]
        public string ChiefProjectEngineer { get; set; }
        //Developer
        [BsonIgnoreIfNull]
        public string DeveloperName { get; set; }
        [BsonIgnoreIfNull]
        public string FullNameHead { get; set; }
        //Designer+Developer
        [BsonIgnoreIfNull]
        public int OGRN { get; set; }
        [BsonIgnoreIfNull]
        public int INN { get; set; }
        [BsonIgnoreIfNull]
        public int KPP { get; set; }
        [BsonIgnoreIfNull]
        public string Address { get; set; }


        public bool IsCheck { get; set; } = false;

        public User(string fullName, string email, string password, string login, string phoneNumber, string department,string userType)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Login = login;
            PhoneNumber = phoneNumber;
            Department = department;
            UserType = userType;
            IsCheck = true;
        }

        public User(string email, string password, string login, string phoneNumber, string userType)
        {
            Email = email;
            Password = password;
            Login = login;
            PhoneNumber = phoneNumber;
            UserType = userType;
        }
    }
}
