using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace CinemaV1
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void textBoxsenhacard_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*/
           SmtpClient  smtp = new SmtpClient();
            smtp.Host = ("smtp.hotmail.com");
            smtp.EnableSsl = true;

            smtp.Credentials = new System.Net.NetworkCredential("jhow.ponciano@hotmail.com", "pokemon201");

            MailMessage mail = new MailMessage(); ;
            mail.Sender = new System.Net.Mail.MailAddress("jhow.ponciano@hotmail.com","CINE-TICKET");
            m
            
            mail.To.Add(textBoxEmail.Text);

            mail.Subject = "CineOneTwoTre- Obrigado por comprar com a gente ";
            mail.Body = "Obrigado por creditar na gente, tenha uma otima sessão ";

            

            smtp.Send(mail); 
            /*/
            //enviador de E-mail 
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("jhow.ponciano@hotmail.com");
            mail.To.Add(textBoxEmail.Text);
            mail.Subject = "Obrigado por comprar no Cine-Ticket";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = "<html><body><img src=\"https://pbs.twimg.com/media/D7v4-5YXkAEkefQ.png\"></body></html>";
                

            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("jhow.ponciano@hotmail.com", "pokemon201");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);


            MessageBox.Show("Compra efetuada <3 ");
        }
    }
}
