using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace TireCompany.Data
{
    public class Product
    {
        [BsonId]
        public ObjectId _id;

        public Product(string article, string title, ObjectId type, string imagePath, int peopleCount, int workshop, double price, string description,List<MaterialCount> materials)
        {
            Article = article;
            Title = title;
            Type = type;
            ImagePath = imagePath;
            PeopleCount = peopleCount;
            Workshop = workshop;
            Price = price;
            Description = description;
            Materials = materials;
        }

        public string Article { get; set; }
        public string Title { get; set; }
        public ObjectId Type { get; set; }
        public string ImagePath { get; set; }
        public int  PeopleCount { get; set; }
        public int Workshop { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public List<MaterialCount> Materials { get; set; }
    }
}