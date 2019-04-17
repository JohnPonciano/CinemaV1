using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaV1
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }


        //CONVERSOR DE IMAGEM PARA B
        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            //abrir imagem e carregar na picture box
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                //convertemos pegar o caminho da imagem e convertemos para string
                string foto = file.FileName.ToString();
                imgload.Text = foto;
                imgload.ImageLocation = file.FileName;
            }


        }
        // AQUI FICA TUDO QUE TEM QUE SER GUARDADO PELO BANCO // AQUI FICA TUDO QUE TEM QUE SER GUARDADO PELO BANCO // AQUI FICA TUDO QUE TEM QUE SER GUARDADO PELO BANCO
        private void radioBTNbox1_CheckedChanged(object sender, EventArgs e)
        {
            Box = "Box1";
        }
        private void radioBTNbox2_CheckedChanged(object sender, EventArgs e)
        {
            Box = "Box2";
        }
        private void radioBTNbox3_CheckedChanged(object sender, EventArgs e)
        {
            Box = "Box3";
        }
        string Box;
        
        private void BtnUploadAll_Click(object sender, EventArgs e)
        {
           
            try
            {

                //defini uma arrey de binarios, onde sera a feita a conversão pra byte 
                byte[] imgByte = null;

                FileStream fstream = new FileStream(this.imgload.Text, FileMode.Open, FileAccess.Read);

                BinaryReader BinReader = new BinaryReader(fstream);

                imgByte = BinReader.ReadBytes((int)fstream.Length);

                //string de conexao
                String strConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\JR TECH\source\repos\CinemaV1\CinemaV1\bdCadastro.mdb";
                //cria a conexao
                OleDbConnection conn = new OleDbConnection(strConexao);
                //abrir conexao (conn)
                conn.Open();
                //comando slq
                String SQL;
                
                SQL = "Insert Into Filmes (Imagens , Sinopse , Genero, TagIdade  ,VideoDoYT , Box , Nome ) Values";
                SQL += "('"+imgByte+"','" + textsinopse.Text+ "','"+checkedListGen.CheckedItems +"','"+comboTagidade.Text+"','"+textNavegacao.Text+"','"+ Box.ToString() +"','"+textNomeDoFilme.Text+"')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Otimo, o Filme foi cadastrado no Banco ");
                
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

        private void radioBTNbox3_CheckedChanged_1(object sender, EventArgs e)
        {
            Box = "Box3";
        }
        //QUI FICA


        // AQUI FICA TUDO QUE TEM QUE SER GUARDADO PELO BANCO




    }
}
