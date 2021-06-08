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
    public partial class Frm_AnaSayfa : Form
    {
        public Frm_AnaSayfa()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        //azalan stokları gridviewe yazdırmak için metod
        private void _stoklar()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select UrunAd, Sum(Adet) as 'Adet' from Tbl_Urunler Group by UrunAd Having Sum(Adet)<=30 Order by Adet ASC", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            grdStok1.DataSource = dataTable;
        }

        //son 5 notu ajanda gridvievine cekme metodu
        private void _ajanda()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select top 10 Tarih,Saat,Baslik from Tbl_Notlar Order by Id DESC", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            grdAjanda1.DataSource = dataTable;
        }

        //Musteri hareketini gridvieve cekmek için metod
        private void _musteriHareket()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute MusteriHareketAnaSayfa", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            grdHareket1.DataSource = dataTable;
        }

        //Firma hareketini gridvieve cekmek için metod
        private void _firmaHareket()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute FirmaHareketAnaSayfa", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            grdHareket1.DataSource = dataTable;
        }

        //fihrist metod
        private void _fihrist()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Isim,Telefon1,Telefon2 from Tbl_Firmalar", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            grdFihrist1.DataSource = dataTable;
        }

        private void Frm_AnaSayfa_Load(object sender, EventArgs e)
        {
            _stoklar();
            _ajanda();
            _fihrist();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac>0 && sayac<=5)
            {
                gridView3.Columns.Clear();
                groupControl3.Text = "Son 10 Hareket (Müşteri)";
                _musteriHareket();
            }
            if (sayac>6 && sayac<=10)
            {
                gridView3.Columns.Clear();
                groupControl3.Text = "Son 10 Hareket (Firmalar)";
                _firmaHareket();
            }
            if (sayac==11)
            {
                sayac = 0;
            }
        }
    }
}
