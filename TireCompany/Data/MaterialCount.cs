using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TireCompany.Data
{
    public class MaterialCount
    {
        public MaterialCount(Material material, int count)
        {
            Material = material;
            Count = count;
        }

        public Material Material { get; set; }
        public int Count { get; set; }



    }
}