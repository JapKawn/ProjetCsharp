using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class Manegelec : Form
    {
        public Manegelec()
        {
            InitializeComponent();
            this.FormClosing += Manegelec_FormClosing;
        }

        private const string Identifiant1 = "fournier";
        private const string MotDePasse1 = "1234";
        private const string Identifiant2 = "hurier";
        private const string MotDePasse2 = "5678";

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Connexion_Click_1(object sender, EventArgs e)
        {
            // Récupérer les valeurs entrées par l'utilisateur
            string identifiant = UtilisateurText.Text;
            string motDePasse = MotdepasseText.Text;

            // Vérifier les identifiants et mots de passe
            if ((identifiant == Identifiant1 && motDePasse == MotDePasse1) ||
                (identifiant == Identifiant2 && motDePasse == MotDePasse2))
            {

                Form2 form2 = new Form2();
                form2.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect");
            }
        }

        private void Manegelec_Load(object sender, EventArgs e)
        {

        }

        private void Manegelec_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void UtilisateurText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

