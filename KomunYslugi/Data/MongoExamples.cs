using MongoDB.Driver;

namespace KomunYslugi.Data
{
    public class MongoExamples
    {
        public static void AddToDB(Customer user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<Customer>("Customer");
            collection.InsertOne(user);
        }

        public static void AddToDB(Designer user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<Designer>("Designer");
            collection.InsertOne(user);
        }

        public static void AddToDB(Developer user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<Developer>("Developer");
            collection.InsertOne(user);
        }
    }
}
