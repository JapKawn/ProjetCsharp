using Projet.Entities;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using Projet.Service;
using System;

namespace Projet.Manager
{
    class LigneCommandeManager
    {
        public void CreateLigneCommande(LigneCommande ligneCommande)
        {
            string query = "INSERT INTO lignecommande (produit, commande, quantite) VALUES (@produit, @commande, @quantite)";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@produit", ligneCommande.Produit);
                    command.Parameters.AddWithValue("@commande", ligneCommande.Commande);
                    command.Parameters.AddWithValue("@quantite", ligneCommande.Quantite);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de la création de la ligne de commande : {ex.Message}");
                        // Gérer l'exception selon les besoins
                    }
                }
                connection.Close();
            }
        }

        public Collection<LigneCommande> ReadAllLigneCommandes()
        {
            string query = "SELECT * FROM lignecommande";
            Collection<LigneCommande> ligneCommandeCollection = new Collection<LigneCommande>();

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LigneCommande ligneCommande = new LigneCommande()
                            {
                                Produit = reader.GetInt32("produit"),
                                Commande = reader.GetInt32("commande"),
                                Quantite = reader.GetInt32("quantite")
                            };

                            ligneCommandeCollection.Add(ligneCommande);
                        }
                    }
                }
                connection.Close();
            }

            return ligneCommandeCollection;
        }

        public void UpdateLigneCommande(LigneCommande ligneCommande)
        {
            string query = "UPDATE lignecommande SET quantite = @quantite WHERE produit = @produit AND commande = @commande";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@produit", ligneCommande.Produit);
                    command.Parameters.AddWithValue("@commande", ligneCommande.Commande);
                    command.Parameters.AddWithValue("@quantite", ligneCommande.Quantite);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteLigneCommande(LigneCommande ligneCommande)
        {
            string query = "DELETE FROM lignecommande WHERE produit = @produit AND commande = @commande";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@produit", ligneCommande.Produit);
                    command.Parameters.AddWithValue("@commande", ligneCommande.Commande);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
