using MongoDB.Bson.Serialization.Attributes;
namespace KomunYslugi.Data
{
    public class File
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public byte[] Attachment { get; set; }
        public string Name { get; set; }
        public bool IsCheck { get; set; }
    }
}
