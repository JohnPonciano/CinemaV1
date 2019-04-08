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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //botão pra fechar o APP
            Application.Exit();
        }

        private void btnloginfrm2_Click(object sender, EventArgs e)
        {
            //volta para o Form1 que se chama MAIN
            this.Close();
            Main frmain = new Main();
            frmain.Show();
            //-----------------------------------------------------/

        }

        private void btncadastrarfrm2_Click(object sender, EventArgs e)
        {
           //aqui deve ficar o codigo de conexao com banco etc.
        }
    }
}
