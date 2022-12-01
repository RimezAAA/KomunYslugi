using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KomunYslugi.Data
{
    public class DeveloperData
    {
        public string Content { get; set; }
        public File File { get; set; } = new File();

        public DeveloperData(string content)
        {
            Content = content;
        }
    }
}
