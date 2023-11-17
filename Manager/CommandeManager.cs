using System;
using Projet.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

class CommandeManager
{
    private List<Commande> commandes = new List<Commande>();
    private SqlConnection connection = new SqlConnection("Database=menagelecsharp;Server=localhost;User=root;Password=");

    public bool ConnexionMysql()
    {
        try
        {
            connection.Open();
            MessageBox.Show("Connecté");
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur de connexion : " + ex.Message);
            return false;
        }
    }

    public bool CloseMysql()
    {
        try
        {
            connection.Close();
            MessageBox.Show("Déconnecté");
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors de la déconnexion : " + ex.Message);
            return false;
        }
    }

    public void createCommande(Commande commande)
    {
        commandes.Add(commande);
    }

    public List<Commande> readCommande()
    {
        // Simulez la récupération des données depuis la base de données
        // Remplacez ceci par votre logique de récupération réelle depuis la base de données
        return commandes;
    }

    public void saveCommande(Commande commande)
    {
        // Implémentez la logique de sauvegarde dans une base de données ou ailleurs
        Console.WriteLine("Commande sauvegardée : " + commande.id);
    }

    public void updateCommande(Commande commande)
    {
        // Implémentez la logique de mise à jour dans une base de données ou ailleurs
        Console.WriteLine("Commande mise à jour : " + commande.id);
    }

    public void deleteCommande(Commande commande)
    {
        commandes.Remove(commande);
    }
}
