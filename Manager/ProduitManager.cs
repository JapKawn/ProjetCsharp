using System;
using Projet.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Manager
{

    class ProduitManager
    {
        private List<Produit> produits = new List<Produit>();

        public void createProduit(Produit produit)
        {
            produits.Add(produit);
        }

        public List<Produit> readProduit()
        {
            return produits;
        }

        public void saveProduit(Produit produit)
        {
            // Implémentez la logique de sauvegarde dans une base de données ou ailleurs
            Console.WriteLine("Produit sauvegardé : " + produit.designation);
        }

        public void updateProduit(Produit produit)
        {
            // Implémentez la logique de mise à jour dans une base de données ou ailleurs
            Console.WriteLine("Produit mis à jour : " + produit.designation);
        }

        public void deleteProduit(Produit produit)
        {
            produits.Remove(produit);
        }
    }
}
