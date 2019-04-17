using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CinemaV1
{
    public partial class Cadastros : Form
    {
        public Cadastros()
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
            Login frmain = new Login();
            frmain.Show();
            //-----------------------------------------------------/

        }

        private void btncadastrarfrm2_Click(object sender, EventArgs e)
        {
            try
            {
                //string de conexao
                String strConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\JR TECH\source\repos\CinemaV1\CinemaV1\bdCadastro.mdb";
                //cria a conexao
                OleDbConnection conn = new OleDbConnection(strConexao);
                //abrir conexao (conn)
                conn.Open();
                //comando slq
                String SQL;
                SQL = "Insert Into Cadastros(Nome,Email,Senha) Values";
                SQL += "('"+TxtBoxUser.Text+"','"+TxtBoxEmail.Text+"','"+TxtBoxPass.Text+"')";

               

                OleDbCommand cmd = new OleDbCommand(SQL,conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Boa! Hoje tem Cineminha? :) ");
                TxtBoxUser.Clear();
                TxtBoxEmail.Clear();
                TxtBoxPass.Clear();

                conn.Close();

                this.Hide();
                Login frmain = new Login();
                frmain.Show();

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
                
            }


        }
    }
    }
