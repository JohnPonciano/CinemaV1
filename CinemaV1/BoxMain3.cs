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
    public partial class BoxMain3 : Form
    {
        public BoxMain3()
        {
            InitializeComponent();
            //Player do youtube

            DateTime data1 = DateTime.Today;
            Data1.Text = data1.ToString("dd/MM");
            //Data1 atualiza seu status

            DateTime data2 = new DateTime();
            Data2.Text = data2.ToString("14/04");
            //Data 2 atualiza seu status




        }
           

        protected override void OnLoad(EventArgs e)
        {
            //Carregar o WebBrowser
            /* base.OnLoad(e);
             var embed = "<html><head>" +
             "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
             "</head><body>" +
             "background-color:#404040"+
             "<iframe width=\"536\" height=\"279\"src=\"{0}\"" +
             "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
             "</body></html>";
             var url = "https://www.youtube.com/embed/MsQNB5hYvFc?&controls=1&autoplay=1";
             this.webBrowser1.DocumentText = string.Format(embed, url);
             */

            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"500\" height=\"265\"src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen = \"1\" allowInlineMediaPlayBack = \"TRUE\" ></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/embed/4QRdB4RAQMs?&controls=1&autoplay=1&allowsInlineMediaPlayback=0";

            this.webBrowser1.DocumentText = string.Format(embed, url);




        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void Data1_Click(object sender, EventArgs e)
        {

            //Abre o form Home e esconde o form1
            Horarios frmHoras = new Horarios();
            frmHoras.Show();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Data2_Click(object sender, EventArgs e)
        {
            //Abre o form Home e esconde o form1
            Horarios frmHoras = new Horarios();
            frmHoras.Show();

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Data1_Click_1(object sender, EventArgs e)
        {
            //Abre o form Home e esconde o form1
            Horarios frmHoras = new Horarios();
            frmHoras.Show();
        }
    }

        
    }

