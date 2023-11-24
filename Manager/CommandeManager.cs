using Projet.Entities;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using Projet.Service;
using System;

namespace Projet.Manager
{
    static class CommandeManager
    {
        public static Collection<Commande> ReadNonPayeeCommandes()
        {
            string query = "SELECT * FROM commande WHERE estPayee = 0";
            return ReadCommandes(query);
        }

        public static Collection<Commande> ReadNonExpedieeCommandes()
        {
            string query = "SELECT * FROM commande WHERE estExpediee = 0";
            return ReadCommandes(query);
        }

        private static Collection<Commande> ReadCommandes(string query)
        {
            Collection<Commande> commandes = new Collection<Commande>();

            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Commande commande = new Commande()
                            {
                                IdCommande = reader.GetInt32("id"),
                                Date = reader.GetDateTime("date"),
                                EstPayee = reader.GetBoolean("estPayee"),
                                EstExpediee = reader.GetBoolean("estExpediee"),
                                IdClient = reader.GetInt32("client")
                            };

                            commandes.Add(commande);
                        }
                    }
                }

                connexion.Close();
            }

            return commandes;
        }


        public static void CreateCommande(Commande commande)
        {
            string query = "INSERT INTO commande (id, date, estPayee, estExpediee, client) VALUES (@id, @date, @estPayee, @estExpediee, @client)";

            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    command.Parameters.AddWithValue("@id", commande.IdCommande);
                    command.Parameters.AddWithValue("@date", commande.Date);
                    command.Parameters.AddWithValue("@estPayee", commande.EstPayee);
                    command.Parameters.AddWithValue("@estExpediee", commande.EstExpediee);
                    command.Parameters.AddWithValue("@client", commande.IdClient);

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
                connexion.Close();
            }
        }

        public static Collection<Commande> ReadAllCommande()
        {
            string query = "SELECT * FROM commande";
            Collection<Commande> CommandeConnection = new Collection<Commande>();

            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Commande commande = new Commande()
                            {
                                IdCommande = reader.GetInt32("id"),
                                Date = reader.GetDateTime("date"),
                                EstPayee = reader.GetBoolean("estPayee"),
                                EstExpediee = reader.GetBoolean("estExpediee"),
                                IdClient = reader.GetInt32("client")
                            };

                            CommandeConnection.Add(commande);
                        }
                    }

                }
                connexion.Close();
            }

            return CommandeConnection;
        }



        public static void SaveCommande(Commande commande)
        {
            // Exemple d'implémentation (à personnaliser selon les besoins)
            string query = "INSERT INTO commande (id, date, estPayee, estExpediee, client) VALUES (@id, @date, @estPayee, @estExpediee, @client)";

            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    command.Parameters.AddWithValue("@id", commande.IdCommande);
                    command.Parameters.AddWithValue("@date", commande.Date);
                    command.Parameters.AddWithValue("@estPayee", commande.EstPayee);
                    command.Parameters.AddWithValue("@estExpediee", commande.EstExpediee);
                    command.Parameters.AddWithValue("@client", commande.IdClient);

                    command.ExecuteNonQuery();
                }
                connexion.Close();
            }
        }

        public static void UpdateCommande(Commande commande)
        {
            // Exemple d'implémentation (à personnaliser selon les besoins)
            string query = "UPDATE commande SET date = @date, estPayee = @estPayee, estExpediee = @estExpediee, client = @idClient WHERE id = @id";

            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    command.Parameters.AddWithValue("@id", commande.IdCommande);
                    command.Parameters.AddWithValue("@date", commande.Date);
                    command.Parameters.AddWithValue("@estPayee", commande.EstPayee);
                    command.Parameters.AddWithValue("@estExpediee", commande.EstExpediee);
                    command.Parameters.AddWithValue("@client", commande.IdClient);

                    command.ExecuteNonQuery();
                }
                connexion.Close();
            }
        }

        public static void DeleteCommande(Commande commande)
        {
            // Exemple d'implémentation (à personnaliser selon les besoins)
            string query = "DELETE FROM commande WHERE id = @id";

            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    command.Parameters.AddWithValue("@id", commande.IdCommande);

                    command.ExecuteNonQuery();
                }
                connexion.Close();
            }
        }
    }

}