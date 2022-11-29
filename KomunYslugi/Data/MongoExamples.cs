using MongoDB.Driver;

namespace KomunYslugi.Data
{
    public class MongoExamples
    {
        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<User>("User");
            collection.InsertOne(user);
        }

        public static User Find(string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<User>("User");
            var one = collection.Find(x => x.Login == login).FirstOrDefault();
            return one;
        }

        public static void ReplaceByName(string login, User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<User>("User");
            collection.ReplaceOne(x => x.Login == login, user);
        }
    }
}
