using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Entities
{
    class Client
    {
        public int idClient { get; set; }
        public string civilite { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string ville { get; set; }
        public string cp { get; set; }
        public string mail { get; set; }
        public string tel { get; set; }
    }
}