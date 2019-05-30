using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CinemaV1
{


    public partial class Home : Form
    { //Script do slide


        public Home(string Valor)
        {


            InitializeComponent();

            btnLogado.Text = Valor;

            // transparencia

            lbl2.Parent = Slideimg;
            lbl3.Parent = Slideimg;
            lbl1.Parent = Slideimg;
            lbl1.BackColor = Color.Transparent;
            lbl2.BackColor = Color.Transparent;
            lbl3.BackColor = Color.Transparent;

        }



        public Home()
        {
            InitializeComponent();

            //_______________BANCO_________//
            try
            {
               // String strConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\JR TECH\source\repos\CinemaV1\CinemaV1\bdCadastro.mdb";

                //string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\JR TECH\source\repos\CinemaV1\CinemaV1\bdGeral.mdf;Integrated Security=True";

                //cria a conexao
                OleDbConnection conn = new OleDbConnection(CinemaV1.Properties.Settings.Default.strConexao);

                //SqlConnection conn = new SqlConnection(strConexao);

                OleDbCommand comm = new OleDbCommand("select * from Filmes where Imagens , Box , Nome ", conn);

                //SqlCommand comm = new SqlCommand (" select * from Filme where Imagens, Box, Nome ", conn );


                conn.Open();

                OleDbDataReader reader = comm.ExecuteReader();

                // SqlDataReader reader = comm.ExecuteReader ();



                /*/ Image img = null;

                 if (reader.Read())
                 {
                     byte[] foto = (byte[])reader["Imagens"];

                     MemoryStream ms = new MemoryStream(foto);
                   img = Image.FromStream(ms);

                 }
                 Box1.Image = img;
                 /*/


                conn.Close();

            }

            catch
            {
                MessageBox.Show("Erro no bd");
            }
        }

<<<<<<< HEAD

=======
       
>>>>>>> 06ff7e5b3077362c29c9341aadafde5dbd7f917a

        //______________________________________________BANCO__________________________________________



        private int imgnumber = 1;


        private void LoadNextImg()
        {
            if (imgnumber == 4)
            {
                imgnumber = 1;

            }
            Slideimg.ImageLocation = string.Format(@"slides\{0}.jpg", imgnumber);
            imgnumber++;
        }
        //Script do slide


        private void btnSair_Click(object sender, EventArgs e)
        {
            //fecha o app
            Application.Exit();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImg(); //carregar slide

        }


        private void Shazam_Click(object sender, EventArgs e)
        {
            //Aqui fica os banners, onde abre a tela com horario deles etc
            BoxMain frmHorarios = new BoxMain();
            frmHorarios.Show();
        }



        private void btnLogado_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Sair?", "Deslogar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")

            {
                Login frmLogin = new Login();
                frmLogin.Show();
                this.Close();

            }

        }

        private void Box1_Click(object sender, EventArgs e)
        {
            //Aqui fica os banners, onde abre a tela com horario deles etc
            BoxMain2 frmbox2 = new BoxMain2();
            frmbox2.Show();
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            //Aqui fica os banners, onde abre a tela com horario deles etc
            BoxMain3 frmbox3 = new BoxMain3();
            frmbox3.Show();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
