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
using DevExpress.XtraBars;

namespace TicariOtomasyon
{
    public partial class Frm_FaturaDetayDüzenleme : Form
    {
        public Frm_FaturaDetayDüzenleme()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        public string urunId;

        //urun detaylarını araclara cekmek için metod
        private void _detayTasi()
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_FaturaDetay where FaturaUrunId=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtUrunAd.Text = dataReader[1].ToString();
                txtMiktar.Text = dataReader[2].ToString();
                txtFiyat.Text = dataReader[3].ToString();
                txtTutar.Text = dataReader[4].ToString();
            }
            bgl.baglanti().Close();
        }

        // ürünün bilgilerini güncellemek için metod
        private void _detayGuncelle()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Faturadaki ürün detaylarını güncellemek istediğinize emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            double miktar, fiyat, tutar;
            miktar = Convert.ToDouble(txtMiktar.Text);
            fiyat = Convert.ToDouble(txtFiyat.Text);
            tutar = miktar * fiyat;
            txtTutar.Text = tutar.ToString();

            SqlCommand command = new SqlCommand("Update Tbl_FaturaDetay set UrunAd=@p1,Miktar=@p2,Fiyat=@p3,Tutar=@p4 where FaturaUrunId=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            command.Parameters.AddWithValue("@p2", txtMiktar.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
            command.Parameters.AddWithValue("@k1", txtUrunId.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        // ürünü silmek için metod
        private void _detaySil()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Faturadaki ürün detaylarını güncellemek istediğinize emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete Tbl_FaturaDetay where FaturaUrunId=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtUrunId.Text);

            if (dialog == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void Frm_FaturaDetayDüzenleme_Load(object sender, EventArgs e)
        {
            txtUrunId.Text = urunId;
            _detayTasi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _detayGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _detaySil();
        }
    }
}
