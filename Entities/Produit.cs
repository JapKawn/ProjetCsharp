using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Entities
{
    public class Produit
    {
        internal readonly string designation;

        public int IdProduit { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public DateTime DateAjout { get; set; }
        public int Qte { get; set; }
        public decimal Prix { get; set; }
        public string FichierImage { get; set; }
        public int PkFournisseur { get; set; }
    }
}
