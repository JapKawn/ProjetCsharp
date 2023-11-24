using Projet.Manager;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projet.Entities;
using System.Collections.ObjectModel;
using Projet.Service;

namespace Projet
{
    public partial class GestionCommand : Form
    {

        public GestionCommand()
        {
            InitializeComponent();
        }

        private bool ConnexionMysql()
        {
            try
            {
                using (MySqlConnection connection = InitializeConnection.GetConnection())
                {
                    connection.Open();
                    MessageBox.Show("Connecté");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion : {ex.Message}");
                return false;
            }
        }

        private bool CloseMysql()
        {
            try
            {
                using (MySqlConnection connection = InitializeConnection.GetConnection())
                {
                    connection.Close();
                    MessageBox.Show("Déconnecté");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de déconnexion : {ex.Message}");
                return false;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Vous pouvez également appeler ChargerDonnees ici si nécessaire.
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (ConnexionMysql()) // Fermer la connexion avant de quitter l'application
                {
                    CloseMysql();
                }
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Code associé au changement de texte dans textBox1
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Code associé au changement de texte dans textBox6
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Code associé au changement de texte dans textBox4
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Code associé au clic sur le bouton2
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // Code associé au changement de texte dans textBox7
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Code associé au changement de texte dans textBox8
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
            
            
        }

        private void CheckTout_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTout.Checked)
            {
                CheckPayer.Checked = false;
                CheckExpedier.Checked = false;

                DataGridViewCommande.ColumnCount = 3;
                DataGridViewCommande.ColumnHeadersVisible = true;

                DataGridViewCommande.Columns[0].Name = "idCommande";
                DataGridViewCommande.Columns[1].Name = "date";
                DataGridViewCommande.Columns[2].Name = "client";

                Collection<Commande> commandes = CommandeManager.ReadAllCommande();

                foreach (Commande commande in commandes)
                {
                    DataGridViewCommande.Rows.Add(commande.IdCommande, commande.Date, commande.IdClient);
                }
            }
            else
            {
                DataGridViewCommande.Rows.Clear();
            }
        }

        private void CheckPayer_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPayer.Checked)
            {
                CheckTout.Checked = false;
                CheckExpedier.Checked = false;

                DataGridViewCommande.ColumnCount = 3;
                DataGridViewCommande.ColumnHeadersVisible = true;

                DataGridViewCommande.Columns[0].Name = "idCommande";
                DataGridViewCommande.Columns[1].Name = "date";
                DataGridViewCommande.Columns[2].Name = "client";

                Collection<Commande> commandes = CommandeManager.ReadEstPayeeCommande();

                foreach (Commande commande in commandes)
                {
                    DataGridViewCommande.Rows.Add(commande.IdCommande, commande.Date, commande.IdClient);
                }
            }
            else
            {
                DataGridViewCommande.Rows.Clear();
            }
        }

        private void CheckExpedier_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckExpedier.Checked)
            {
                CheckTout.Checked = false;
                CheckPayer.Checked = false;

                DataGridViewCommande.ColumnCount = 3;
                DataGridViewCommande.ColumnHeadersVisible = true;

                DataGridViewCommande.Columns[0].Name = "idCommande";
                DataGridViewCommande.Columns[1].Name = "date";
                DataGridViewCommande.Columns[2].Name = "client";

                Collection<Commande> commandes = CommandeManager.ReadEstExpedieeCommande();

                foreach (Commande commande in commandes)
                {
                    DataGridViewCommande.Rows.Add(commande.IdCommande, commande.Date, commande.IdClient);
                }
            }
            else
            {
                DataGridViewCommande.Rows.Clear();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            // Code associé au clic sur le label2
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
