using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TireCompany.Data
{
    public class Material
    {
        [BsonId]
        public ObjectId _id;

        public Material(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
        

        
    }
}