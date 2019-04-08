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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //botao pra sair e fechar o aplicativo
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Abre o form Home e esconde o form1
            Home frmHome = new Home();
            frmHome.Show();
            this.Hide();

        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {

            //Abre o Form Cadastro e esconde o form1

            cadastro frmcadastro = new cadastro();
            frmcadastro.Show();
            this.Hide();
            //----------------------------------------------------------------------------//



        }
    }
}
