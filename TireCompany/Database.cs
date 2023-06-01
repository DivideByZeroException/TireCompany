﻿using MongoDB.Driver;
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
    }
}
