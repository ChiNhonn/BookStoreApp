using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role  { get; set; }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public User(int id, string fullName, string username, string password, string role)
        {
            this.UserId = id;
            this.FullName = fullName;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
        public override string ToString()
        {
            return $"{FullName} ({Role})";
        }
    }
}
