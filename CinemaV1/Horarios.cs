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
    public partial class Horarios : Form
    {

       
        
        public Horarios()
        {
            InitializeComponent();


            btnHorario1.Text = (DateTime.Now.ToString("HH:mm"));
            button1.Text = (DateTime.Now.ToString("12:00"));
            button2.Text = (DateTime.Now.ToString("23:30"));
            button3.Text = (DateTime.Now.ToString("16:00"));
            button4.Text = (DateTime.Now.ToString("18:30"));
            button5.Text = (DateTime.Now.ToString("03:00"));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Horarios_Load(object sender, EventArgs e)
        {

        }

        private void btnHorario1_Click(object sender, EventArgs e)
        {
            Poltronas frmLogin = new Poltronas();
            frmLogin.Show();
            this.Hide();
        }
    }
}
