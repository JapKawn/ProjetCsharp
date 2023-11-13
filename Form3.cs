using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projet
{
    public partial class Form3 : Form
    {
         public Form3()
        {
            InitializeComponent();
            this.FormClosing += Form3_FormClosing;

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
    }
}
   