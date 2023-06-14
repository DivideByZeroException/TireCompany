using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TireCompany.Data;

namespace TireCompany
{
    public class Database
    {
        public static void AddUser(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }
        public static User FindUser(string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Login == login).FirstOrDefault();
            return one;
        }
        public static List<ProductType> GetProductTypes()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<ProductType>("ProductTypes");
            var list = collection.Find(x => true).ToList();
            return list;
        }
        public static List<Material> GetMaterials()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Material>("Materials");
            var list = collection.Find(x => true).ToList();
            return list;
        }
        public static void AddProductType(ProductType pt)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<ProductType>("ProductTypes");
            collection.InsertOne(pt);
        }

        public static void AddMaterial(Material m)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Material>("Materials");
            collection.InsertOne(m);
        }
        public static void AddProduct(Product p)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Product>("Products");
            collection.InsertOne(p);
        }
        public static List<Product> FindAllProducts()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Product>("Products");
            var list = collection.Find(x => true).ToList();
            return list;
        }

        public static List<Material> FindAllMaterials()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Material>("Materials");
            var list = collection.Find(x => true).ToList();
            return list;
        }
        public static Product FindProductById(ObjectId id)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Product>("Products");
            var one = collection.Find(x => x._id == id).FirstOrDefault();
            return one;
        }
        public static Product FindProductByArticle(string article)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Product>("Products");
            var one = collection.Find(x => x.Article == article).FirstOrDefault();
            return one;
        }
        public static ProductType FindProductTypeById(ObjectId id)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<ProductType>("ProductTypes");
            var one = collection.Find(x => x._id == id).FirstOrDefault();
            return one;
        }
        public static Material FindMaterialById(ObjectId id)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Material>("Materials");
            var one = collection.Find(x => x._id == id).FirstOrDefault();
            if(one == null)
            {
                return new Material("Материал удален");
            }
            return one;
        }
        public static void DeleteProduct(ObjectId product)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Product>("Products");
            collection.DeleteOne(z => z._id == product);

        }
        public static void EditProduct( ObjectId product,Product editedProduct)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Product>("Products");
            var update = Builders<Product>.Update.Set(p => p.Title, editedProduct.Title).Set(p => p.Description, editedProduct.Description).Set(p => p.ImagePath, editedProduct.ImagePath).Set(p => p.Article, editedProduct.Article).Set(p=>p.PeopleCount,editedProduct.PeopleCount).Set(p=>p.Workshop,editedProduct.Workshop).Set(p=>p.Price,editedProduct.Price).Set(p=>p.Materials,editedProduct.Materials).Set(p=>p.Type,editedProduct.Type).Set(p=>p.ImagePath,editedProduct.ImagePath);
            collection.UpdateMany(x => x._id == product, update);
        }
        public static void DeleteMaterial(ObjectId id)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Material>("Materials");
            collection.DeleteOne(z => z._id == id);

        }
        public static void EditMaterial(ObjectId material, Material editedMaterial)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("TireDatabase");
            var collection = database.GetCollection<Material>("Materials");
            var update = Builders<Material>.Update.Set(p => p.Title, editedMaterial.Title);
            collection.UpdateMany(x=>x._id==material,update);
        }
    }
}
