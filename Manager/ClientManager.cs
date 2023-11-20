using System;
using System.Collections.Generic;
using Projet.Entities;

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

        }

        public void updateClient(Client client)
        {

        }

        public void deleteClient(Client client)
        {

        }
    }
}