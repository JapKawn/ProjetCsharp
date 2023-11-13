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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancier et afficher Form3
            Form3 form3 = new Form3();
            form3.Show();

            // Fermer Form2
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
