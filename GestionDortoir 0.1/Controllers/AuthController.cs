using GestionDortoir_0._1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionDortoir_0._1.Controllers
{
    internal class AuthController
    {
        public static string GenerateSalt()
        {
            var saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var combined = Encoding.UTF8.GetBytes(password + salt);
                return Convert.ToBase64String(sha256.ComputeHash(combined));
            }
        }

        public static bool Register(Utilisateur user)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO utilisateur (nom, email, password_hash, salt, role) VALUES (@nom, @email, @hash, @salt, @role)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", user.Nom);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@hash", user.PasswordHash);
                    cmd.Parameters.AddWithValue("@salt", user.Salt);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static Utilisateur Login(string email, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM utilisateur WHERE email = @email AND est_active = TRUE";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string salt = reader["salt"].ToString();
                            string storedHash = reader["password_hash"].ToString();
                            string inputHash = HashPassword(password, salt);

                            if (inputHash == storedHash)
                            {
                                return new Utilisateur
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nom = reader["nom"].ToString(),
                                    Email = email,
                                    Role = reader["role"].ToString(),
                                    EstActive = Convert.ToBoolean(reader["est_active"])
                                };
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
