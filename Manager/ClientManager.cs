using Projet.Entities;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using Projet.Service;
using System;

namespace Projet.Manager
{
    class ClientManager
    {
        public void CreateClient(Client client)
        {
            string query = "INSERT INTO client (idClient, civilite, nom, prenom, adresse, ville, cp, mail, tel) VALUES (@idClient, @civilite, @nom, @prenom, @adresse, @ville, @cp, @mail, @tel)";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idClient", client.IdClient);
                    command.Parameters.AddWithValue("@civilite", client.Civilite);
                    command.Parameters.AddWithValue("@nom", client.Nom);
                    command.Parameters.AddWithValue("@prenom", client.Prenom);
                    command.Parameters.AddWithValue("@adresse", client.Adresse);
                    command.Parameters.AddWithValue("@ville", client.Ville);
                    command.Parameters.AddWithValue("@cp", client.Cp);
                    command.Parameters.AddWithValue("@mail", client.Mail);
                    command.Parameters.AddWithValue("@tel", client.Tel);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Une erreur s'est produite lors de la création du client : {ex.Message}");
                        // Gérer l'exception selon les besoins
                    }
                }
                connection.Close();
            }
        }

        public Collection<Client> ReadAllClients()
        {
            string query = "SELECT * FROM client";
            Collection<Client> clientCollection = new Collection<Client>();

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client client = new Client()
                            {
                                IdClient = reader.GetInt32("idClient"),
                                Civilite = reader.GetString("civilite"),
                                Nom = reader.GetString("nom"),
                                Prenom = reader.GetString("prenom"),
                                Adresse = reader.GetString("adresse"),
                                Ville = reader.GetString("ville"),
                                Cp = reader.GetString("cp"),
                                Mail = reader.GetString("mail"),
                                Tel = reader.GetString("tel")
                            };

                            clientCollection.Add(client);
                        }
                    }
                }
                connection.Close();
            }

            return clientCollection;
        }

        public void UpdateClient(Client client)
        {
            string query = "UPDATE client SET civilite = @civilite, nom = @nom, prenom = @prenom, adresse = @adresse, ville = @ville, cp = @cp, mail = @mail, tel = @tel WHERE idClient = @idClient";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idClient", client.IdClient);
                    command.Parameters.AddWithValue("@civilite", client.Civilite);
                    command.Parameters.AddWithValue("@nom", client.Nom);
                    command.Parameters.AddWithValue("@prenom", client.Prenom);
                    command.Parameters.AddWithValue("@adresse", client.Adresse);
                    command.Parameters.AddWithValue("@ville", client.Ville);
                    command.Parameters.AddWithValue("@cp", client.Cp);
                    command.Parameters.AddWithValue("@mail", client.Mail);
                    command.Parameters.AddWithValue("@tel", client.Tel);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteClient(Client client)
        {
            string query = "DELETE FROM client WHERE idClient = @idClient";

            using (MySqlConnection connection = InitializeConnection.GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idClient", client.IdClient);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
