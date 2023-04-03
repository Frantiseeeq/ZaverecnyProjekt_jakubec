using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ZaverecnaPraceIT4_2023
{
    internal class SqlRepository
    {
        private string path = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public User? LoginUser(string username)
        {
            User? user = null;
            using (SqlConnection sqlConnection = new SqlConnection(path))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM UsersLogin WHERE User_Name=@username";
                    cmd.Parameters.AddWithValue("username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User((int)reader["User_ID"],reader["User_Name"].ToString(), (byte[])reader["PasswordHash"], (byte[])reader["PasswordSalt"], reader["User_Role"].ToString());
                        }
                    }
                }
                sqlConnection.Close();
            }
            return user;
        }


        public void AddUser(string username, string password, string role)
        {
            byte[] salt;
            byte[] hash;

            HMACSHA512 hmac = new HMACSHA512();

            hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            salt = hmac.Key;

            using (SqlConnection sqlConnection = new SqlConnection(path))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "insert into UsersLogin (User_Name,PasswordHash,PasswordSalt, User_Role) values(@username,@hash,@salt,@role)";
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("hash", hash);
                    cmd.Parameters.AddWithValue("salt", salt);
                    cmd.Parameters.AddWithValue("role", role);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        public void EditUser(string username, string password, string role) 
        {
            
        }
    }
}
