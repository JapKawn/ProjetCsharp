using Projet.Entities;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using Projet.Service;
using System;

namespace Projet.Manager
{
    /// <summary>
    /// Classe fournissant des méthodes pour la gestion des produits dans la base de données.
    /// </summary>
    class ProduitManager
    {
        /// <summary>
        /// Crée un nouveau produit dans la base de données.
        /// </summary>
        /// <param name="produit">Le produit à créer.</param>
        public void CreateProduit(Produit produit)
        {
            // Requête SQL pour l'insertion d'un nouveau produit
            string query = "INSERT INTO produit (idProduit, designation, description, dateAjout, qte, prix, fichierImage, pk_fournisseur) VALUES (@idProduit, @designation, @description, @dateAjout, @qte, @prix, @fichierImage, @pk_fournisseur)";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@idProduit", produit.IdProduit);
                    command.Parameters.AddWithValue("@designation", produit.Designation);
                    command.Parameters.AddWithValue("@description", produit.Description);
                    command.Parameters.AddWithValue("@dateAjout", produit.DateAjout);
                    command.Parameters.AddWithValue("@qte", produit.Qte);
                    command.Parameters.AddWithValue("@prix", produit.Prix);
                    command.Parameters.AddWithValue("@fichierImage", produit.FichierImage);
                    command.Parameters.AddWithValue("@pk_fournisseur", produit.PkFournisseur);

                    try
                    {
                        // Exécution de la requête SQL
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de la création du produit : {ex.Message}");
                        // Gérer l'exception selon les besoins
                    }
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }

        /// <summary>
        /// Récupère tous les produits de la base de données.
        /// </summary>
        /// <returns>Une collection de tous les produits.</returns>
        public Collection<Produit> ReadAllProduits()
        {
            // Requête SQL pour la récupération de tous les produits
            string query = "SELECT * FROM produit";
            Collection<Produit> produitCollection = new Collection<Produit>();

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
                        // Lecture des données et création des objets Produit
                        while (reader.Read())
                        {
                            Produit produit = new Produit()
                            {
                                IdProduit = reader.GetInt32("idProduit"),
                                Designation = reader.GetString("designation"),
                                Description = reader.GetString("description"),
                                DateAjout = reader.GetDateTime("dateAjout"),
                                Qte = reader.GetInt32("qte"),
                                Prix = reader.GetDecimal("prix"),
                                FichierImage = reader.GetString("fichierImage"),
                                PkFournisseur = reader.GetInt32("pk_fournisseur")
                            };

                            // Ajout du produit à la collection
                            produitCollection.Add(produit);
                        }
                    }
                }

                // Fermeture de la connexion
                connection.Close();
            }

            return produitCollection;
        }

        /// <summary>
        /// Met à jour un produit dans la base de données.
        /// </summary>
        /// <param name="produit">Le produit à mettre à jour.</param>
        public void UpdateProduit(Produit produit)
        {
            // Requête SQL pour la mise à jour d'un produit
            string query = "UPDATE produit SET designation = @designation, description = @description, dateAjout = @dateAjout, qte = @qte, prix = @prix, fichierImage = @fichierImage, pk_fournisseur = @pk_fournisseur WHERE idProduit = @idProduit";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@idProduit", produit.IdProduit);
                    command.Parameters.AddWithValue("@designation", produit.Designation);
                    command.Parameters.AddWithValue("@description", produit.Description);
                    command.Parameters.AddWithValue("@dateAjout", produit.DateAjout);
                    command.Parameters.AddWithValue("@qte", produit.Qte);
                    command.Parameters.AddWithValue("@prix", produit.Prix);
                    command.Parameters.AddWithValue("@fichierImage", produit.FichierImage);
                    command.Parameters.AddWithValue("@pk_fournisseur", produit.PkFournisseur);

                    // Exécution de la requête SQL
                    command.ExecuteNonQuery();
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }

        /// <summary>
        /// Supprime un produit de la base de données.
        /// </summary>
        /// <param name="produit">Le produit à supprimer.</param>
        public void DeleteProduit(Produit produit)
        {
            // Requête SQL pour la suppression d'un produit
            string query = "DELETE FROM produit WHERE idProduit = @idProduit";

            // Utilisation d'une connexion MySQL
            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                // Utilisation d'une commande MySQL avec des paramètres
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Attribution des valeurs des paramètres
                    command.Parameters.AddWithValue("@idProduit", produit.IdProduit);

                    // Exécution de la requête SQL
                    command.ExecuteNonQuery();
                }

                // Fermeture de la connexion
                connection.Close();
            }
        }
    }
}
