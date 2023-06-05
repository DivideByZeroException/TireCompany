using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TireCompany.Data
{
    public class MaterialCount
    {
        public MaterialCount(ObjectId material, int count)
        {
            Material = material;
            Count = count;
        }

        public ObjectId Material { get; set; }
        public int Count { get; set; }



    }
}