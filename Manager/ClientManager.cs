using Projet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet.Manager
{
    class ClientManager
    {
        private List<Client> clients = new List<Client>();

        public void createClient(Client client)
        {
            clients.Add(client);
        }

        public List<Client> readClient()
        {
            return clients;
        }

        public void saveClient(Client client)
        {
            // Implémentez la logique de sauvegarde dans une base de données ou ailleurs
            Console.WriteLine("Client sauvegardé : " + client.nom);
        }

        public void updateClient(Client client)
        {
            // Implémentez la logique de mise à jour dans une base de données ou ailleurs
            Console.WriteLine("Client mis à jour : " + client.nom);
        }

        public void deleteClient(Client client)
        {
            clients.Remove(client);
        }
    }
}