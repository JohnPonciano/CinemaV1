using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CinemaV1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //botao pra sair e fechar o aplicativo
            Application.Exit();
        }

      
        public void BtnLogin_Click(object sender, EventArgs e)
        {
            

            try
            {
                String strConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\JR TECH\source\repos\CinemaV1\CinemaV1\bdCadastro.mdb";
               // string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\JR TECH\source\repos\CinemaV1\CinemaV1\bdGeral.mdf;Integrated Security=True";
                //cria a conexao
                OleDbConnection conn = new OleDbConnection(strConexao);
                //SqlConnection conn = new SqlConnection(strConexao);

                OleDbCommand comm = new OleDbCommand("select * from Cadastros where Nome = @user and Senha = @senha",conn);

               // SqlCommand comm = new SqlCommand("select * from Cadastros where Nome = @user and Senha = @senha", conn);

                comm.Parameters.Add("@user", OleDbType.VarChar).Value = TxtBoxUser.Text;
                //comm.Parameters.Add("@user", SqlDbType.VarChar).Value = TxtBoxUser.Text;
                //comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = TxtBoxPass.Text;
                comm.Parameters.Add("@senha", OleDbType.VarChar).Value = TxtBoxPass.Text;
                
                conn.Open();


                

                int i = int.Parse(comm.ExecuteScalar().ToString());

                if (i > 0)
                {

                    //Abre o form Home e esconde o form1
                     
                    Home frmHome = new Home(TxtBoxUser.Text);
                    frmHome.Show();
                    this.Hide();

                }
                
                else
                {
                    MessageBox.Show("Error Usuario não foi encontrado, verifique a senha e o Login");

                }
                conn.Close();
            }
            catch (Exception  )
            {

                MessageBox.Show("Error, Usuario ou Senha invalidos");
               

            }

            


            

        }

        private void btncadastroLOGIN_Click(object sender, EventArgs e)
        {
            
            //Abre o Form Cadastro e esconde o form1

            Cadastros frmcadastro = new Cadastros();
            frmcadastro.Show();
            this.Hide();
            //----------------------------------------------------------------------------//



        }

        private void btnadm_Click(object sender, EventArgs e)
        {
            adminlogin frmadmin = new adminlogin(TxtBoxUser.Text);
           frmadmin.Show();
            this.Hide();
        }
    }
}
