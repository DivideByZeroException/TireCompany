using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TireCompany.Data
{
    public class ProductType
    {
        [BsonId]
        public ObjectId _id;

        public ProductType(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
        

        
    }
}