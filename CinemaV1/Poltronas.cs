using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaV1
{
    public partial class Poltronas : Form
    {
        public Poltronas()
        {
            InitializeComponent();
        }

        private void poltronaVerde1_Click(object sender, EventArgs e)
        {
            poltronaVerde1.Hide();
            poltronaVermelha1.Show();
        }

        private void poltronaVermelha1_Click(object sender, EventArgs e)
        {
            poltronaVermelha1.Hide();
            poltronaVerde1.Show();

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Compras frmCompras = new Compras();
            frmCompras.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void poltronaVerde2_Click_1(object sender, EventArgs e)
        {
            poltronaVerde2.Hide();
            poltronaVermelha2.Show();
        }

        private void poltronaVermelha2_Click(object sender, EventArgs e)
        {
            poltronaVermelha2.Hide();
            poltronaVerde2.Show();
        }
    }
}
