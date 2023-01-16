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

        public static void AddToDBProject(Project project)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<Project>("Project");
            collection.InsertOne(project);
        }

        public static List<User> FindListDeveloper()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<User>("User");
            var one = collection.Find(x => x.IsCheck == true && x.UserType == "Developer").ToList();
            return one;
        }

        public static List<User> FindListDesigner()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<User>("User");
            var one = collection.Find(x => x.IsCheck == true && x.UserType == "Designer").ToList();
            return one;
        }

        public static User Find(string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<User>("User");
            var one = collection.Find(x => x.Login == login).FirstOrDefault();
            return one;
        }

        public async static Task<User> FindAsync(string login)
        {
            await Task.Delay(3000);
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

        public static void Delete(string id)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<File>("Files");

            var file = collection.Find(x => x.Id == id).FirstOrDefault();
            file.Attachment = null;
            collection.ReplaceOne(x => x.Id == id, file);
        }

        public static File FindFiles(string Id)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<File>("Files");

            var file = collection.Find(x=>x.Id == Id).FirstOrDefault();
            return file;
        }

        public static File Save(File file)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<File>("Files");

            collection.InsertOne(file);
            return file;
        }

        public static List<File> GetFiles()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<File>("Files");

            return collection.Find(x=>x.Attachment!=null).ToList();
        }

        public static File Upload(string id)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<File>("Files");

            var file = collection.Find(x => x.Id == id).FirstOrDefault();
            if (!file.IsCheck)
                file.IsCheck = true;
            else
                file.IsCheck = false;
            collection.ReplaceOne(x => x.Id == id, file);
            return file;
        }

            public static List<Project> GetProjectsCustomers(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<Project>("Project");

            return collection.Find(x => x.customer._id == user._id).ToList();
        }

        public static List<Project> GetProjectsDesigner(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<Project>("Project");

            return collection.Find(x => x.designer._id == user._id).ToList();
        }

        public static List<Project> GetProjectsDeveloper(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<Project>("Project");

            return collection.Find(x => x.developer._id == user._id).ToList();
        }

        public static void ProjectReplace(Project project)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("KomUslugi");
            var collection = database.GetCollection<Project>("Project");
            collection.ReplaceOne(x => x._id == project._id, project);
        }
    }
}
