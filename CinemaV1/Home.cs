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

namespace CinemaV1
{



    public partial class Home : Form
    { //Script do slide

        public Home(string Valor)
        {
            InitializeComponent();
            btnLogado.Text = Valor;
            
        }


        public Home()
        {
            InitializeComponent();

            // transparencia


            lbl2.Parent = Slideimg;
            lbl3.Parent = Slideimg;
            lbl1.Parent = Slideimg;
            lbl1.BackColor = Color.Transparent;
            lbl2.BackColor = Color.Transparent;
            lbl3.BackColor = Color.Transparent;

  // ________________________________BANCO_____________________________
            try
            {
                String strConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\JR TECH\source\repos\CinemaV1\CinemaV1\bdCadastro.mdb";
                //cria a conexao
                OleDbConnection conn = new OleDbConnection(strConexao);

                OleDbCommand comm = new OleDbCommand("select * from Filmes where Imagens , Box , Nome ", conn);
                conn.Open();

                OleDbDataReader reader = comm.ExecuteReader();

                Image img = null;

                if (reader.Read())
                {
                    byte[] foto = (byte[])reader["Imagens"];

                    MemoryStream ms = new MemoryStream(foto);
                  img = Image.FromStream(ms);
                    
                }
                Box1.Image = img;



                conn.Close();

            }

            catch
            {
                MessageBox.Show("Erro no bd");
            }
        }

        //______________________________________________BANCO__________________________________________

        

        private int imgnumber = 1;
        

        private void LoadNextImg()
        {
            if(imgnumber == 4)
            {
                imgnumber = 1;
                
            }
            Slideimg.ImageLocation = string.Format(@"slides\{0}.jpg",imgnumber);
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
            Dias frmHorarios = new Dias();
            frmHorarios.Show();
        }

        
    }
}
