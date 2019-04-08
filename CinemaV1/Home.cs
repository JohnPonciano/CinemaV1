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


namespace CinemaV1
{
    public partial class Home : Form
    { //Script do slide
        
        public Home()
        {
            InitializeComponent();
            // transparencia
            pictureBox1.Parent = Slideimg;
            pictureBox4.Parent = Slideimg;
            pictureBox5.Parent = Slideimg;
            
        }

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
