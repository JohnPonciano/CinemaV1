﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CinemaV1
{
    public partial class Dias : Form
    {
        

        public Dias()
        {
            InitializeComponent();
            //Player do youtube

            DateTime data1 = DateTime.Today;
            Data1.Text = data1.ToString("dd/MM");
            //Data1 atualiza seu status
            DateTime data2 = new DateTime();
            Data2.Text = data2.ToString("07/04");
            //Data 2 atualiza seu status



            

           
    }

        protected override void OnLoad(EventArgs e)
        {
            //Carregar o WebBrowser
            /* base.OnLoad(e);
             var embed = "<html><head>" +
             "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
             "</head><body>" +
             "<iframe width=\"536\" height=\"279\"src=\"{0}\"" +
             "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
             "</body></html>";
             var url = "https://www.youtube.com/embed/MsQNB5hYvFc?&allowfullscreen=true";
             this.webBrowser1.DocumentText = string.Format(embed, url);
             */
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"650\" height=\"275\"src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/embed/MsQNB5hYvFc?&controls=1&autoplay=1";
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
            this.Hide();

        
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
                
        }
    }
}