using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport_Team_Hub.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GamerTag { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        // Role has to be changed to a enum or a more structured type in the future
        public string Role { get; set; } // e.g., "Admin", "Player", "Coach"
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }

        public User()
        {
            CreatedAt = DateTime.Now;
            LastLogin = DateTime.Now;
        }

        public User(int id, string username, string password, string firstName, string lastName, string gamerTag, DateTime dateOfBirth, string nationality, string email, string role, DateTime createdAt, DateTime lastLogin)
        {
            Id = id;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            GamerTag = gamerTag;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
            Email = email;
            Role = role;
            CreatedAt = createdAt;
            LastLogin = lastLogin;
        }
    }
}
