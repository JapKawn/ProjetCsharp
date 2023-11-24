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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancier et afficher Form3
            GestionCommand form3 = new GestionCommand();
            form3.Show();

            // Fermer Form2
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
