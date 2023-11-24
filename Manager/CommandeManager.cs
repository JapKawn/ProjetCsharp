using Projet.Entities;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using Projet.Service;
using System;

namespace Projet.Manager
{
    /// <summary>
    /// Classe statique fournissant des méthodes pour la gestion des commandes dans la base de données.
    /// </summary>
    static class CommandeManager
    {
        /// <summary>
        /// Crée une nouvelle commande dans la base de données.
        /// </summary>
        /// <param name="commande">La commande à créer.</param>
        public static void CreateCommande(Commande commande)
        {
            // Requête SQL pour l'insertion d'une nouvelle commande
            string query = "INSERT INTO commande (id, date, estPayee, estExpediee, client) VALUES (@id, @date, @estPayee, @estExpediee, @client)";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@id", commande.IdCommande);
                    command.Parameters.AddWithValue("@date", commande.Date);
                    command.Parameters.AddWithValue("@estPayee", commande.EstPayee);
                    command.Parameters.AddWithValue("@estExpediee", commande.EstExpediee);
                    command.Parameters.AddWithValue("@client", commande.IdClient);

                    try
                    {
                        // Exécution de la requête SQL
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

        /// <summary>
        /// Récupère toutes les commandes de la base de données.
        /// </summary>
        /// <returns>Une collection de toutes les commandes.</returns>
        public static Collection<Commande> ReadAllCommande()
        {
            // Requête SQL pour la récupération de toutes les commandes
            string query = "SELECT * FROM commande";
            Collection<Commande> CommandeConnection = new Collection<Commande>();

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                // Utilisation d'une commande MySQL pour lire les données
                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    // Utilisation d'un lecteur MySQL pour parcourir les résultats
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Lecture des données et création des objets Commande
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

                            // Ajout de la commande à la collection
                            CommandeConnection.Add(commande);
                        }
                    }
                }

                connexion.Close();
            }

            return CommandeConnection;
        }

        /// <summary>
        /// Récupère les commandes non payées de la base de données.
        /// </summary>
        /// <returns>Une collection de commandes non payées.</returns>
        public static Collection<Commande> ReadEstPayeeCommande()
        {
            // Requête SQL pour la récupération des commandes non payées
            string query = "SELECT * FROM commande WHERE estPayee = 0";
            Collection<Commande> CommandeConnection = new Collection<Commande>();

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                // Utilisation d'une commande MySQL pour lire les données
                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    // Utilisation d'un lecteur MySQL pour parcourir les résultats
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Lecture des données et création des objets Commande
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

                            // Ajout de la commande à la collection
                            CommandeConnection.Add(commande);
                        }
                    }
                }

                connexion.Close();
            }

            return CommandeConnection;
        }

        /// <summary>
        /// Récupère les commandes non expédiées de la base de données.
        /// </summary>
        /// <returns>Une collection de commandes non expédiées.</returns>
        public static Collection<Commande> ReadEstExpedieeCommande()
        {
            // Requête SQL pour la récupération des commandes non expédiées
            string query = "SELECT * FROM commande WHERE estExpediee = 0";
            Collection<Commande> CommandeConnection = new Collection<Commande>();

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                // Utilisation d'une commande MySQL pour lire les données
                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    // Utilisation d'un lecteur MySQL pour parcourir les résultats
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Lecture des données et création des objets Commande
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

                            // Ajout de la commande à la collection
                            CommandeConnection.Add(commande);
                        }
                    }
                }

                connexion.Close();
            }

            return CommandeConnection;
        }

        /// <summary>
        /// Sauvegarde une commande dans la base de données.
        /// </summary>
        /// <param name="commande">La commande à sauvegarder.</param>
        public static void SaveCommande(Commande commande)
        {
            // Requête SQL pour l'insertion d'une nouvelle commande
            string query = "INSERT INTO commande (id, date, estPayee, estExpediee, client) VALUES (@id, @date, @estPayee, @estExpediee, @client)";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@id", commande.IdCommande);
                    command.Parameters.AddWithValue("@date", commande.Date);
                    command.Parameters.AddWithValue("@estPayee", commande.EstPayee);
                    command.Parameters.AddWithValue("@estExpediee", commande.EstExpediee);
                    command.Parameters.AddWithValue("@client", commande.IdClient);

                    // Exécution de la requête SQL
                    command.ExecuteNonQuery();
                }

                connexion.Close();
            }
        }

        /// <summary>
        /// Met à jour une commande dans la base de données.
        /// </summary>
        /// <param name="commande">La commande à mettre à jour.</param>
        public static void UpdateCommande(Commande commande)
        {
            // Requête SQL pour la mise à jour d'une commande
            string query = "UPDATE commande SET date = @date, estPayee = @estPayee, estExpediee = @estExpediee, client = @idClient WHERE id = @id";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@id", commande.IdCommande);
                    command.Parameters.AddWithValue("@date", commande.Date);
                    command.Parameters.AddWithValue("@estPayee", commande.EstPayee);
                    command.Parameters.AddWithValue("@estExpediee", commande.EstExpediee);
                    command.Parameters.AddWithValue("@client", commande.IdClient);

                    // Exécution de la requête SQL
                    command.ExecuteNonQuery();
                }

                connexion.Close();
            }
        }

        /// <summary>
        /// Supprime une commande de la base de données.
        /// </summary>
        /// <param name="commande">La commande à supprimer.</param>
        public static void DeleteCommande(Commande commande)
        {
            // Requête SQL pour la suppression d'une commande
            string query = "DELETE FROM commande WHERE id = @id";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connexion = InitializeConnection.GetConnection())
            {
                connexion.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connexion))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@id", commande.IdCommande);

                    // Exécution de la requête SQL
                    command.ExecuteNonQuery();
                }

                connexion.Close();
            }
        }
    }
}
