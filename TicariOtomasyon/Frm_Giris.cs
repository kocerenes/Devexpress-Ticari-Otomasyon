using DevExpress.Utils.DirectXPaint.Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }

        Frm_Urunler urunler; //frm_urunler formunun nesnesini olusturdum
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // urunler formunun arka arkaya sınırsız sekilde acılmasının önüne gectik.
            if (urunler==null || urunler.IsDisposed)
            {
                urunler = new Frm_Urunler();
                urunler.MdiParent = this;
                urunler.Show();
            }
        }

        Frm_Musteriler musteriler;
        private void btnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteriler==null || musteriler.IsDisposed)
            {
                musteriler = new Frm_Musteriler();
                musteriler.MdiParent = this;
                musteriler.Show();
            }
        }

        Frm_Firmalar firmalar;
        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (firmalar==null||musteriler.IsDisposed)
            {
                firmalar = new Frm_Firmalar();
                firmalar.MdiParent = this;
                firmalar.Show();
            }
        }

        Frm_Personeller personel;
        private void btnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personel==null||personel.IsDisposed)
            {
                personel = new Frm_Personeller();
                personel.MdiParent = this;
                personel.Show();
            }
        }

        Frm_Rehber rehber;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rehber==null||rehber.IsDisposed)
            {
                rehber = new Frm_Rehber();
                rehber.MdiParent = this;
                rehber.Show();
            }
        }

        Frm_Giderler giderler;
        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (giderler==null || giderler.IsDisposed)
            {
                giderler = new Frm_Giderler();
                giderler.MdiParent = this;
                giderler.Show();
            }
        }

        Frm_Bankalar bankalar;
        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankalar==null || bankalar.IsDisposed)
            {
                bankalar = new Frm_Bankalar();
                bankalar.MdiParent = this;
                bankalar.Show();
            }
        }

        Frm_Faturalar faturalar;
        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (faturalar==null|| faturalar.IsDisposed)
            {
                faturalar = new Frm_Faturalar();
                faturalar.MdiParent = this;
                faturalar.Show();
            }
        }

        Frm_Notlar notlar;
        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (notlar==null || notlar.IsDisposed)
            {
                notlar = new Frm_Notlar();
                notlar.MdiParent = this;
                notlar.Show();
            }
        }

        Frm_Hareketler hareketler;
        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hareketler==null || hareketler.IsDisposed)
            {
                hareketler = new Frm_Hareketler();
                hareketler.MdiParent = this;
                hareketler.Show();
            }
        }

        Frm_Raporlar raporlar;
        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (raporlar==null||raporlar.IsDisposed)
            {
                raporlar = new Frm_Raporlar();
                raporlar.MdiParent = this;
                raporlar.Show();
            }
        }

        Frm_Stoklar stok;
        private void btnStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stok==null||stok.IsDisposed)
            {
                stok = new Frm_Stoklar();
                stok.MdiParent = this;
                stok.Show();
            }
        }

        Frm_Ayarlar ayarlar;
        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ayarlar == null || ayarlar.IsDisposed)
            {
                ayarlar = new Frm_Ayarlar();
                ayarlar.Show();
            }
        }

        Frm_Kasa kasa;
        public string kullaniciAd1;
        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasa==null || kasa.IsDisposed)
            {
                kasa = new Frm_Kasa();
                kasa.kullaniciAd2 = kullaniciAd1;
                kasa.MdiParent = this;
                kasa.Show();
            }
        }

        Frm_AnaSayfa anaSayfa;
        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anaSayfa==null || anaSayfa.IsDisposed)
            {
                anaSayfa = new Frm_AnaSayfa();
                anaSayfa.MdiParent = this;
                anaSayfa.Show();
            }
        }

        private void Frm_Giris_Load(object sender, EventArgs e)
        {
            if (anaSayfa == null || anaSayfa.IsDisposed)
            {
                anaSayfa = new Frm_AnaSayfa();
                anaSayfa.MdiParent = this;
                anaSayfa.Show();
            }
        }
    }
}
