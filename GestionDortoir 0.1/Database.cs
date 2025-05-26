using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDortoir_0._1
{
    internal class Database
    {
        private static string connectionString = "server=localhost;database=gestiondortoir2;uid=root;pwd=;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
