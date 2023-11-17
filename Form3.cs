using Projet.Manager;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet
{
    public partial class Form3 : Form
    {
        public SqlConnection connection = new SqlConnection("Database=menagelecsharp;Server=localhost;User=root;Password=");
        public Form3()
        {
            connection.Open();
            InitializeComponent();
            DataTable table = new DataTable();
            // rajoute les colonnes
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("date", typeof(DateTime));
            table.Columns.Add("client", typeof(int));
            // les commandes sql
            SqlCommand command = new SqlCommand("SELECT id , date , client FROM commande", connection);
            //lire les donnees
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                // creer une nouvelle lignes
                DataRow dataRow = table.NewRow();
                // Remplir la nouvelle ligne
                dataRow["id"] = dataReader.GetInt32("id");
                dataRow["date"] = dataReader.GetDateTime("date");
                dataRow["client"] = dataReader.GetInt32("client");
                table.Rows.Add(dataRow);
                dataGridView1.DataSource = table;
            }
            connection.Close();
        }


        
        public bool ConnexionMysql()
        {

            try

            {
                connection.Open();
                MessageBox.Show("Connecté");
                return true;
            }
            catch
            {
                MessageBox.Show("Non Connecté");
                return false;
            }

        }
        public bool CloseMysql()
        {

            try

            {
                connection.Close();
                MessageBox.Show("Connecté");
                return true;
            }
            catch
            {
                MessageBox.Show("Non Connecté");
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

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
   