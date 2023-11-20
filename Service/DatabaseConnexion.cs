using System;
using MySql.Data.MySqlClient;

namespace Projet.Service
{
    static class InitializeConnection
    {
        private static MySqlConnection Connexion;

        private const string _server = "localhost";
        private const string _port = "3306";
        private const string _user = "root";
        private const string _password = "";
        private const string _database = "menagelecsharp";

        public static MySqlConnection GetConnection()
        {
            var connectionString = $"server={_server};" +
                                    $"port={_port};" +
                                    $"user={_user};" +
                                    $"password={_password};" +
                                    $"database={_database};";

            Connexion = new MySqlConnection(connectionString);
            return Connexion;
        }
    }
}
