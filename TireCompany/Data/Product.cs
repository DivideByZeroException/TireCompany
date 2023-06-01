using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TireCompany.Data
{
    public class Product
    {
        [BsonId]
        public ObjectId _id;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }

        
    }
}