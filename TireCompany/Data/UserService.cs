using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TireCompany.Data
{
    public class UserService
    {
        public ObjectId UserId { get; set; }
    }
}
