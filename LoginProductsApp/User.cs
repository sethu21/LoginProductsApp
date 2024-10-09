using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProductsApp
{
    public class User
    {
        // Properties
        public int Id { get; set; }          // User ID
        public string Username { get; set; } // User's username
        public string Name { get; set; }     // User's full name
        public string Password { get; set; }  // User's password
        public string Email { get; set; }     // User's email address

        // Constructor
        public User(int id, string username, string name, string password, string email)
        {
            Id = id;
            Username = username;
            Name = name;
            Password = password;
            Email = email;
        }
    }
}
