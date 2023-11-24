using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Entities
{
    public class LigneCommande
    {
        public int Produit { get; set; }
        public int Commande { get; set; }
        public int Quantite { get; set; }
    }
}
