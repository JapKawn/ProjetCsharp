using Projet.Entities;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using Projet.Service;
using System;

namespace Projet.Manager
{
    class ProduitManager
    {
        public void CreateProduit(Produit produit)
        {
            string query = "INSERT INTO produit (idProduit, designation, description, dateAjout, qte, prix, fichierImage, pk_fournisseur) VALUES (@idProduit, @designation, @description, @dateAjout, @qte, @prix, @fichierImage, @pk_fournisseur)";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
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
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de la création du produit : {ex.Message}");
                        // Gérer l'exception selon les besoins
                    }
                }
                connection.Close();
            }
        }

        public Collection<Produit> ReadAllProduits()
        {
            string query = "SELECT * FROM produit";
            Collection<Produit> produitCollection = new Collection<Produit>();

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
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

                            produitCollection.Add(produit);
                        }
                    }
                }
                connection.Close();
            }

            return produitCollection;
        }

        public void UpdateProduit(Produit produit)
        {
            string query = "UPDATE produit SET designation = @designation, description = @description, dateAjout = @dateAjout, qte = @qte, prix = @prix, fichierImage = @fichierImage, pk_fournisseur = @pk_fournisseur WHERE idProduit = @idProduit";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idProduit", produit.IdProduit);
                    command.Parameters.AddWithValue("@designation", produit.Designation);
                    command.Parameters.AddWithValue("@description", produit.Description);
                    command.Parameters.AddWithValue("@dateAjout", produit.DateAjout);
                    command.Parameters.AddWithValue("@qte", produit.Qte);
                    command.Parameters.AddWithValue("@prix", produit.Prix);
                    command.Parameters.AddWithValue("@fichierImage", produit.FichierImage);
                    command.Parameters.AddWithValue("@pk_fournisseur", produit.PkFournisseur);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteProduit(Produit produit)
        {
            string query = "DELETE FROM produit WHERE idProduit = @idProduit";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idProduit", produit.IdProduit);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
