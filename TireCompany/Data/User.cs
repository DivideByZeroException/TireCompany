using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TireCompany.Data
{
    public class User
    {
        [BsonId]
        public ObjectId _id;
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }

        public User(string name, string lastname, string email, string password, string login, string role)
        {
            Name = name;
            LastName = lastname;
            Email = email;
            Password = password;
            Login = login;
            Role = role;
        }
    }
}