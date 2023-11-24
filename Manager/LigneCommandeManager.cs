using Projet.Entities;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using Projet.Service;
using System;

namespace Projet.Manager
{
    /// <summary>
    /// Classe fournissant des méthodes pour la gestion des lignes de commande dans la base de données.
    /// </summary>
    class LigneCommandeManager
    {
        /// <summary>
        /// Crée une nouvelle ligne de commande dans la base de données.
        /// </summary>
        /// <param name="ligneCommande">La ligne de commande à créer.</param>
        public void CreateLigneCommande(LigneCommande ligneCommande)
        {
            // Requête SQL pour l'insertion d'une nouvelle ligne de commande
            string query = "INSERT INTO lignecommande (produit, commande, quantite) VALUES (@produit, @commande, @quantite)";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@produit", ligneCommande.Produit);
                    command.Parameters.AddWithValue("@commande", ligneCommande.Commande);
                    command.Parameters.AddWithValue("@quantite", ligneCommande.Quantite);

                    try
                    {
                        // Exécution de la requête SQL
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de la création de la ligne de commande : {ex.Message}");
                        // Gérer l'exception selon les besoins
                    }
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }

        /// <summary>
        /// Récupère toutes les lignes de commande de la base de données.
        /// </summary>
        /// <returns>Une collection de toutes les lignes de commande.</returns>
        public Collection<LigneCommande> ReadAllLigneCommandes()
        {
            // Requête SQL pour la récupération de toutes les lignes de commande
            string query = "SELECT * FROM lignecommande";
            Collection<LigneCommande> ligneCommandeCollection = new Collection<LigneCommande>();

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
                        // Lecture des données et création des objets LigneCommande
                        while (reader.Read())
                        {
                            LigneCommande ligneCommande = new LigneCommande()
                            {
                                Produit = reader.GetInt32("produit"),
                                Commande = reader.GetInt32("commande"),
                                Quantite = reader.GetInt32("quantite")
                            };

                            // Ajout de la ligne de commande à la collection
                            ligneCommandeCollection.Add(ligneCommande);
                        }
                    }
                }

                // Fermeture de la connexion
                connection.Close();
            }

            return ligneCommandeCollection;
        }

        /// <summary>
        /// Met à jour une ligne de commande dans la base de données.
        /// </summary>
        /// <param name="ligneCommande">La ligne de commande à mettre à jour.</param>
        public void UpdateLigneCommande(LigneCommande ligneCommande)
        {
            // Requête SQL pour la mise à jour d'une ligne de commande
            string query = "UPDATE lignecommande SET quantite = @quantite WHERE produit = @produit AND commande = @commande";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@produit", ligneCommande.Produit);
                    command.Parameters.AddWithValue("@commande", ligneCommande.Commande);
                    command.Parameters.AddWithValue("@quantite", ligneCommande.Quantite);

                    // Exécution de la requête SQL
                    command.ExecuteNonQuery();
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }

        /// <summary>
        /// Supprime une ligne de commande de la base de données.
        /// </summary>
        /// <param name="ligneCommande">La ligne de commande à supprimer.</param>
        public void DeleteLigneCommande(LigneCommande ligneCommande)
        {
            // Requête SQL pour la suppression d'une ligne de commande
            string query = "DELETE FROM lignecommande WHERE produit = @produit AND commande = @commande";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@produit", ligneCommande.Produit);
                    command.Parameters.AddWithValue("@commande", ligneCommande.Commande);

                    // Exécution de la requête SQL
                    command.ExecuteNonQuery();
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }
    }
}
