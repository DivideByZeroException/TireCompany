using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TireCompany.Data
{
    public class Product
    {
        [BsonId]
        public ObjectId _id;
        public string Article { get; set; }
        public string Title { get; set; }
        public ObjectId Type { get; set; }
        public string ImagePath { get; set; }
        public int  PeopleCount { get; set; }
        public int Workshop { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public MaterialCount[] Materials { get; set; }
    }
}