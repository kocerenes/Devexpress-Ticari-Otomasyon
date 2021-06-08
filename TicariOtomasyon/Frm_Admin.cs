using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicariOtomasyon
{
    public partial class Frm_Admin : Form
    {
        public Frm_Admin()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.Yellow;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.LemonChiffon;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Admin where KullaniciAd=@p1 and Sifre=@p2", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtKullanici.Text);
            command.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                Frm_Giris giris = new Frm_Giris();
                giris.kullaniciAd1 = txtKullanici.Text;
                giris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
