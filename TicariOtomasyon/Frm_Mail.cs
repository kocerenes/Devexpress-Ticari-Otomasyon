using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TicariOtomasyon
{
    public partial class Frm_Mail : Form
    {
        public Frm_Mail()
        {
            InitializeComponent();
        }

        public string mail;

        private void Frm_Mail_Load(object sender, EventArgs e)
        {
            txtMail.Text = mail;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("Mailinizi yazınız", "şifrenizi yazınız");
            client.Port = 587;
            client.Host = "";
            client.EnableSsl = true;
            message.To.Add(txtMail.Text);
            message.From = new MailAddress("mailinizi yazınız");
            message.Subject = txtkonu.Text;
            message.Body = rtbMesaj.Text;
            client.Send(message);
        }
    }
}
