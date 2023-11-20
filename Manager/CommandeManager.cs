using Projet.Entities;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using Projet.Service;
using System;

namespace Projet.Manager
{
    class CommandeManager
    {
        public void CreateCommande(Commande commande)
        {
            string query = "INSERT INTO commande (idCommande, date, estPayee, estExpediee, idClient) VALUES (@idCommande, @date, @estPayee, @estExpediee, @idClient)";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCommande", commande.IdCommande);
                    command.Parameters.AddWithValue("@date", commande.Date);
                    command.Parameters.AddWithValue("@estPayee", commande.EstPayee);
                    command.Parameters.AddWithValue("@estExpediee", commande.EstExpediee);
                    command.Parameters.AddWithValue("@idClient", commande.IdClient);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de la création de la commande : {ex.Message}");
                        // Gérer l'exception selon les besoins
                    }
                }
            }
        }

        public Collection<Commande> ReadAllCommande()
        {
            string query = "SELECT * FROM commande";
            Collection<Commande> CommandeConnection = new Collection<Commande>();

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Commande commande = new Commande()
                            {
                                IdCommande = reader.GetInt32("idCommande"),
                                Date = reader.GetDateTime("date"),
                                EstPayee = reader.GetBoolean("estPayee"),
                                EstExpediee = reader.GetBoolean("estExpediee"),
                                IdClient = reader.GetInt32("idClient")
                            };

                            CommandeConnection.Add(commande);
                        }
                    }
                }
            }

            return CommandeConnection;
        }

        public void SaveCommande(Commande commande)
        {
            // Exemple d'implémentation (à personnaliser selon les besoins)
            string query = "INSERT INTO commande (idCommande, date, estPayee, estExpediee, idClient) VALUES (@idCommande, @date, @estPayee, @estExpediee, @idClient)";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCommande", commande.IdCommande);
                    command.Parameters.AddWithValue("@date", commande.Date);
                    command.Parameters.AddWithValue("@estPayee", commande.EstPayee);
                    command.Parameters.AddWithValue("@estExpediee", commande.EstExpediee);
                    command.Parameters.AddWithValue("@idClient", commande.IdClient);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCommande(Commande commande)
        {
            // Exemple d'implémentation (à personnaliser selon les besoins)
            string query = "UPDATE commande SET date = @date, estPayee = @estPayee, estExpediee = @estExpediee, idClient = @idClient WHERE idCommande = @idCommande";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCommande", commande.IdCommande);
                    command.Parameters.AddWithValue("@date", commande.Date);
                    command.Parameters.AddWithValue("@estPayee", commande.EstPayee);
                    command.Parameters.AddWithValue("@estExpediee", commande.EstExpediee);
                    command.Parameters.AddWithValue("@idClient", commande.IdClient);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCommande(Commande commande)
        {
            // Exemple d'implémentation (à personnaliser selon les besoins)
            string query = "DELETE FROM commande WHERE idCommande = @idCommande";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCommande", commande.IdCommande);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
