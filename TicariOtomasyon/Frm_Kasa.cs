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
using DevExpress.XtraBars.Navigation;
using DevExpress.Charts;

namespace TicariOtomasyon
{
    public partial class Frm_Kasa : Form
    {
        public Frm_Kasa()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        public string kullaniciAd2;

        private void _musteriHareket()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute MusteriHareket", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            grdMusteri.DataSource = dataTable;
        }

        private void _firmaHareket()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute FirmaHareket", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            grdFirma.DataSource = dataTable;
        }

        //toplam tutarı labela yazdırma metodu
        private void _toplamTutar()
        {
            SqlCommand command = new SqlCommand("Select sum(Tutar) from Tbl_FaturaDetay", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblToplamTutar.Text = dataReader[0].ToString() + " TL";
            }
            bgl.baglanti().Close();
        }

        //son ayın fatura ödemelerini yazdırmak için metod
        private void _odemeler()
        {
            SqlCommand command = new SqlCommand("Select (Elektrik+Su+Dogalgaz+Internet+Ekstra) from Tbl_Giderler Order by Id ASC", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblOdemeler.Text = dataReader[0].ToString() + " TL";
            }
            bgl.baglanti().Close();
        }

        //son ayın personel maaşlarını yazdıran metod
        private void _maaslar()
        {
            SqlCommand command = new SqlCommand("select Maaslar from Tbl_Giderler Order by Id ASC", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblMaas.Text = dataReader[0].ToString() + " TL";
            }
            bgl.baglanti().Close();
        }

        //Toplam müşteri sayısını yazdırmak için metod
        private void _müsteriSayi()
        {
            SqlCommand command = new SqlCommand("Select Count(*) from Tbl_Musteriler", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblMusteriSayi.Text = dataReader[0].ToString();
            }
            bgl.baglanti().Close();
        }

        //Toplam firma sayısını yazdırmak için metod
        private void _firmaSayi()
        {
            SqlCommand command = new SqlCommand("select Count(*) from Tbl_Firmalar",bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblFirmaSayi.Text = dataReader[0].ToString();
            }
            bgl.baglanti().Close();
        }

        //firmaların şehir sayısını yazıdrmak için metod
        private void _sehirFirma()
        {
            SqlCommand command = new SqlCommand("Select Count(Distinct(Il)) from Tbl_Firmalar", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblSehirSayiF.Text = dataReader[0].ToString();
            }
            bgl.baglanti().Close();
        }

        //müşterilerin şehir sayısını yazıdrmak için metod
        private void _sehirMusteri()
        {
            SqlCommand command = new SqlCommand("Select Count(Distinct(Il)) from Tbl_Musteriler", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblSehirSayiM.Text = dataReader[0].ToString();
            }
            bgl.baglanti().Close();
        }

        //toplam personel sayısını yazdırma metodu
        private void _personelSayi()
        {
            SqlCommand command = new SqlCommand("Select Count(*) from Tbl_Personeller", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblPersonelSayi.Text = dataReader[0].ToString();
            }
            bgl.baglanti().Close();
        }

        //Toplam ürün sayısını yazdırmak için metod
        private void _toplamStok()
        {
            SqlCommand command = new SqlCommand("Select Sum(Adet) from Tbl_Urunler", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblToplamStok.Text = dataReader[0].ToString();
            }
            bgl.baglanti().Close();
        }

        //gider tablosunu gridviewe cekme metodu
        private void _giderTablo()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Giderler", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            grdGiderler.DataSource = dataTable;
        }

        // 1. charta son 4 ayın elektrik faturasını getiren metod
        private void _elektrikFatura()
        {
            SqlCommand command = new SqlCommand("Select Top 4 Ay,Elektrik from Tbl_Giderler Order By Id DESC", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
            }
            bgl.baglanti().Close();
        }

        // 1. charta son 4 ayın su faturasını getiren metod
        private void _suFatura()
        {
            SqlCommand command = new SqlCommand("Select Top 4 Ay,Su from Tbl_Giderler Order by Id DESC", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
            }
            bgl.baglanti().Close();
        }

        // 1. charta son 4 ayın su faturasını getiren metod
        private void _dogalgazFatura()
        {
            SqlCommand command = new SqlCommand("Select Top 4 Ay,Dogalgaz from Tbl_Giderler Order By Id DESC", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
            }
            bgl.baglanti().Close();
        }

        // 1. charta son 4 ayın İnternet faturasını getiren metod
        private void _internetFatura()
        {
            SqlCommand command = new SqlCommand("Select Top 4 Ay,Internet from Tbl_Giderler Order by Id DESC", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
            }
            bgl.baglanti().Close();
        }

        // 1. charta son 4 ayın ekstrasını getiren metod
        private void _ekstra()
        {
            SqlCommand command = new SqlCommand("Select Top 4 Ay,Ekstra from Tbl_Giderler Order by Id DESC", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dataReader[0], dataReader[1]));
            }
            bgl.baglanti().Close();
        }

        private void Frm_Kasa_Load(object sender, EventArgs e)
        {
            _musteriHareket();
            _firmaHareket();
            _toplamTutar();
            _odemeler();
            _maaslar();
            _müsteriSayi();
            _firmaSayi();
            _sehirFirma();
            _sehirMusteri();
            _personelSayi();
            _toplamStok();
            lblAktifKullanici.Text = kullaniciAd2;
            _giderTablo();
        }

        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            //elektrik fatura
            if (sayac>0 && sayac<=5)
            {
                groupControl10.Text = "Elektrik";
                chartControl1.Series["Aylar"].Points.Clear();
                _elektrikFatura();
            }
            // su fatura
            if (sayac>6 && sayac<=10)
            {
                groupControl10.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                _suFatura();
            }
            // doğalgaz fatura
            if (sayac>11 && sayac<=15)
            {
                groupControl10.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                _dogalgazFatura();
            }
            //İnternet fatura
            if (sayac>16 && sayac<=20)
            {
                groupControl10.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                _internetFatura();
            }
            //ekstra
            if (sayac>21 && sayac<=25)
            {
                groupControl10.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                _ekstra();
            }
            if (sayac==26)
            {
                sayac = 0;
            }

        }

        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;

            //elektrik fatura
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl11.Text = "Elektrik";
                chartControl2.Series["Aylar"].Points.Clear();
                _elektrikFatura();
            }
            // su fatura
            if (sayac2 > 6 && sayac2 <= 10)
            {
                groupControl11.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear();
                _suFatura();
            }
            // doğalgaz fatura
            if (sayac2 > 11 && sayac2 <= 15)
            {
                groupControl11.Text = "Doğalgaz";
                chartControl2.Series["Aylar"].Points.Clear();
                _dogalgazFatura();
            }
            //İnternet fatura
            if (sayac2 > 16 && sayac2 <= 20)
            {
                groupControl11.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                _internetFatura();
            }
            //ekstra
            if (sayac2 > 21 && sayac2 <= 25)
            {
                groupControl11.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                _ekstra();
            }
            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }
    }
}
