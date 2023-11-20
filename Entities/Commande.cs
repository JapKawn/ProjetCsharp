using System;

namespace Projet.Entities
{
    public class Commande
    {
        //internal readonly object client;
        //internal readonly object id;

        public int IdCommande { get; set; }
        public DateTime Date { get; set; }
        public bool EstPayee { get; set; }
        public bool EstExpediee { get; set; }
        public int IdClient { get; set; }

    }
}
