
using Projet.Manager;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projet
{
    public partial class Form3 : Form
    {
        private MySqlConnection connection = new MySqlConnection("Database=menagelecsharp;Server=localhost;User=root;Password=");

        public Form3()
        {
            InitializeComponent();

            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
        }

        private bool ConnexionMysql()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Connecté");
                return true;
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
                connection.Close();
                MessageBox.Show("Déconnecté");
                return true;
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
            Form2 form2 = new Form2();
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
            // Code associé à un clic dans le dataGridView1
        ]

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Code associé au clic sur le label2
        }
    }
}
