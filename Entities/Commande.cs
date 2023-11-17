using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Entities
{
    public class Commande
    {
        internal readonly object client;
        internal readonly object date;
        internal readonly object id;

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool EstPayee { get; set; }
        public bool EstExpediee { get; set; }
        public int ClientId { get; set; }
    }
}
