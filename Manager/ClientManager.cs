using Projet.Entities;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using Projet.Service;
using System;

namespace Projet.Manager
{
    /// <summary>
    /// Classe fournissant des méthodes pour la gestion des clients dans la base de données.
    /// </summary>
    class ClientManager
    {
        /// <summary>
        /// Crée un nouveau client dans la base de données.
        /// </summary>
        /// <param name="client">Le client à créer.</param>
        public void CreateClient(Client client)
        {
            // Requête SQL pour l'insertion d'un nouveau client
            string query = "INSERT INTO client (idClient, civilite, nom, prenom, adresse, ville, cp, mail, tel) VALUES (@idClient, @civilite, @nom, @prenom, @adresse, @ville, @cp, @mail, @tel)";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@idClient", client.IdClient);
                    command.Parameters.AddWithValue("@civilite", client.Civilite);
                    command.Parameters.AddWithValue("@nom", client.Nom);
                    command.Parameters.AddWithValue("@prenom", client.Prenom);
                    command.Parameters.AddWithValue("@adresse", client.Adresse);
                    command.Parameters.AddWithValue("@ville", client.Ville);
                    command.Parameters.AddWithValue("@cp", client.Cp);
                    command.Parameters.AddWithValue("@mail", client.Mail);
                    command.Parameters.AddWithValue("@tel", client.Tel);

                    try
                    {
                        // Exécution de la requête SQL
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de la création du client : {ex.Message}");
                        // Gérer l'exception selon les besoins
                    }
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }

        /// <summary>
        /// Récupère tous les clients de la base de données.
        /// </summary>
        /// <returns>Une collection de tous les clients.</returns>
        public Collection<Client> ReadAllClients()
        {
            // Requête SQL pour la récupération de tous les clients
            string query = "SELECT * FROM client";
            Collection<Client> clientCollection = new Collection<Client>();

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL pour lire les données
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Utilisation d'un lecteur MySQL pour parcourir les résultats
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Lecture des données et création des objets Client
                        while (reader.Read())
                        {
                            Client client = new Client()
                            {
                                IdClient = reader.GetInt32("idClient"),
                                Civilite = reader.GetString("civilite"),
                                Nom = reader.GetString("nom"),
                                Prenom = reader.GetString("prenom"),
                                Adresse = reader.GetString("adresse"),
                                Ville = reader.GetString("ville"),
                                Cp = reader.GetString("cp"),
                                Mail = reader.GetString("mail"),
                                Tel = reader.GetString("tel")
                            };

                            // Ajout du client à la collection
                            clientCollection.Add(client);
                        }
                    }
                }

                // Fermeture de la connexion
                connection.Close();
            }

            return clientCollection;
        }

        /// <summary>
        /// Met à jour un client dans la base de données.
        /// </summary>
        /// <param name="client">Le client à mettre à jour.</param>
        public void UpdateClient(Client client)
        {
            // Requête SQL pour la mise à jour d'un client
            string query = "UPDATE client SET civilite = @civilite, nom = @nom, prenom = @prenom, adresse = @adresse, ville = @ville, cp = @cp, mail = @mail, tel = @tel WHERE idClient = @idClient";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@idClient", client.IdClient);
                    command.Parameters.AddWithValue("@civilite", client.Civilite);
                    command.Parameters.AddWithValue("@nom", client.Nom);
                    command.Parameters.AddWithValue("@prenom", client.Prenom);
                    command.Parameters.AddWithValue("@adresse", client.Adresse);
                    command.Parameters.AddWithValue("@ville", client.Ville);
                    command.Parameters.AddWithValue("@cp", client.Cp);
                    command.Parameters.AddWithValue("@mail", client.Mail);
                    command.Parameters.AddWithValue("@tel", client.Tel);

                    // Exécution de la requête SQL
                    command.ExecuteNonQuery();
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }

        /// <summary>
        /// Supprime un client de la base de données.
        /// </summary>
        /// <param name="client">Le client à supprimer.</param>
        public void DeleteClient(Client client)
        {
            // Requête SQL pour la suppression d'un client
            string query = "DELETE FROM client WHERE idClient = @idClient";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@idClient", client.IdClient);

                    // Exécution de la requête SQL
                    command.ExecuteNonQuery();
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }
    }
}
