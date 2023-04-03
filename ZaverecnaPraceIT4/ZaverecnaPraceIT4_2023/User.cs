using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnaPraceIT4_2023
{
    public class User
    {
        public int Id { get; }
        public string Username { get; }
        public string Role { get; set; }
        public byte[] PasswordHash { get; internal set; }
        public byte[] PasswordSalt { get; internal set; }

        SqlRepository sql = new SqlRepository();

        public User(int id, string username, string password, string role)
        {
            Id = id;
            Username = username;
            Role = role;
            sql.AddUser(username, password, role);
        }

        public User(int id, string username, byte[] passwordHash, byte[] passwordSalt, string role)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Role = role;
        }

        public bool VerifyPassword(string password)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            return hash.SequenceEqual(PasswordHash);
        }
    }
}
