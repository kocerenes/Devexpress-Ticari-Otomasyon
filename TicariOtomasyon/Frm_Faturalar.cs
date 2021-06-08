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
    public partial class Frm_Faturalar : Form
    {
        public Frm_Faturalar()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        //gridviewe fatura bilgilerini listelemek için metod
        private void _listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_FaturaBilgi", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        //araclarda yazan fatura bilgilerini silmek için metod
        private void _bilgiTemizle()
        {
            txtId.Text = "";
            cmbCari.Text = "";
            txtSeri.Text = "";
            txtSiraNo.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtVergiD.Text = "";
            txtAlici.Text = "";
            txtTeslimAlan.Text = "";
            txtTeslimEden.Text = "";
            txtSeri.Text = "";
        }

        //araclarda yazan fatura detaylarını silmek için metod
        private void _detayTemizle()
        {
            txtUrunId.Text = "";
            txtUrunAd.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
            txtTutar.Text = "";
            txtFaturaId.Text = "";
        }

        //fatura bilgisi kaydetme işlemi için metod.
        private void _faturaEkle()
        {
            //sadece fatura bilgisine kaydetme işlemi
            if (txtFaturaId.Text=="")
            {
                SqlCommand command = new SqlCommand("Insert into Tbl_FaturaBilgi (Seri,SiraNo,Tarih,Saat,VergiDaire,Alici,TeslimEden,TeslimAlan) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", txtSeri.Text);
                command.Parameters.AddWithValue("@p2", txtSiraNo.Text);
                command.Parameters.AddWithValue("@p3", mskTarih.Text);
                command.Parameters.AddWithValue("@p4", mskSaat.Text);
                command.Parameters.AddWithValue("@p5", txtVergiD.Text);
                command.Parameters.AddWithValue("@p6", txtAlici.Text);
                command.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                command.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura bilgileri başarıyla kaydedildi.");
                _listele();
            }

            //Firma harekete ekleme işlemi
            else if (txtFaturaId.Text!="" && cmbCari.Text=="Firma")
            {
                double miktar, fiyat, tutar;
                miktar = Convert.ToDouble(txtMiktar.Text);
                fiyat = Convert.ToDouble(txtFiyat.Text);
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();

                SqlCommand command1 = new SqlCommand("Insert into Tbl_FaturaDetay (UrunAd,Miktar,Fiyat,Tutar,FaturaId) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                command1.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                command1.Parameters.AddWithValue("@p2", txtMiktar.Text);
                command1.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
                command1.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
                command1.Parameters.AddWithValue("@p5", txtFaturaId.Text);
                command1.ExecuteNonQuery();
                bgl.baglanti().Close();

                // hareket tablosuna veri ekleme
                SqlCommand command2 = new SqlCommand("Insert into Tbl_FirmaHareket (UrunId,Adet,Personel,Firma,Fiyat,Toplam,FaturaId,Tarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                command2.Parameters.AddWithValue("@p1", txtUrunId.Text);
                command2.Parameters.AddWithValue("@p2", txtMiktar.Text);
                command2.Parameters.AddWithValue("@p3", luePersonel.EditValue);
                command2.Parameters.AddWithValue("@p4", lueCari.EditValue);
                command2.Parameters.AddWithValue("@p5", decimal.Parse(txtFiyat.Text));
                command2.Parameters.AddWithValue("@p6", decimal.Parse(txtTutar.Text));
                command2.Parameters.AddWithValue("@p7", txtFaturaId.Text);
                command2.Parameters.AddWithValue("@p8", mskTarih.Text);
                command2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //alınan ürün miktarını stoktan düşmek
                SqlCommand command3 = new SqlCommand("Update Tbl_Urunler set Adet=Adet-@k1 where Id=@k2", bgl.baglanti());
                command3.Parameters.AddWithValue("@k1", txtMiktar.Text);
                command3.Parameters.AddWithValue("@k2", txtUrunId.Text);
                command3.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Fatura detayları başarıyla kaydedildi.");
                _listele();
            }

            //Musteriharekete ekleme işlemi
            else if (txtFaturaId.Text != "" && cmbCari.Text == "Müşteri")
            {
                double miktar, fiyat, tutar;
                miktar = Convert.ToDouble(txtMiktar.Text);
                fiyat = Convert.ToDouble(txtFiyat.Text);
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();

                SqlCommand command1 = new SqlCommand("Insert into Tbl_FaturaDetay (UrunAd,Miktar,Fiyat,Tutar,FaturaId) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                command1.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                command1.Parameters.AddWithValue("@p2", txtMiktar.Text);
                command1.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
                command1.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
                command1.Parameters.AddWithValue("@p5", txtFaturaId.Text);
                command1.ExecuteNonQuery();
                bgl.baglanti().Close();

                // hareket tablosuna veri ekleme
                SqlCommand command2 = new SqlCommand("Insert into Tbl_MusteriHareket (UrunId,Adet,Personel,Musteri,Fiyat,Toplam,FaturaId,Tarih) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                command2.Parameters.AddWithValue("@p1", txtUrunId.Text);
                command2.Parameters.AddWithValue("@p2", txtMiktar.Text);
                command2.Parameters.AddWithValue("@p3", luePersonel.EditValue);
                command2.Parameters.AddWithValue("@p4", lueCari.EditValue);
                command2.Parameters.AddWithValue("@p5", decimal.Parse(txtFiyat.Text));
                command2.Parameters.AddWithValue("@p6", decimal.Parse(txtTutar.Text));
                command2.Parameters.AddWithValue("@p7", txtFaturaId.Text);
                command2.Parameters.AddWithValue("@p8", mskTarih.Text);
                command2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //alınan ürün miktarını stoktan düşmek
                SqlCommand command3 = new SqlCommand("Update Tbl_Urunler set Adet=Adet-@k1 where Id=@k2", bgl.baglanti());
                command3.Parameters.AddWithValue("@k1", txtMiktar.Text);
                command3.Parameters.AddWithValue("@k2", txtUrunId.Text);
                command3.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Fatura detayları başarıyla kaydedildi.");
                _listele();
            }
        }

        //fatura bilgilerini silmek için metod
        private void _faturaSil()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Banka bilgilerini silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete Tbl_FaturaBilgi where FaturaBilgiId=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtId.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                _listele();
                _bilgiTemizle();
            }
            else
            {

            }

        }

        //fatura bilgilerini güncellemek için metod
        private void _bilgiGuncelle()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Banka bilgilerini güncellemek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Update Tbl_FaturaBilgi set Seri=@p1,SiraNo=@p2,Tarih=@p3,Saat=@p4,VergiDaire=@p5,Alici=@p6,TeslimEden=@p7,TeslimAlan=@p8 where FaturaBilgiId=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtSeri.Text);
            command.Parameters.AddWithValue("@p2", txtSiraNo.Text);
            command.Parameters.AddWithValue("@p3", mskTarih.Text);
            command.Parameters.AddWithValue("@p4", mskSaat.Text);
            command.Parameters.AddWithValue("@p5", txtVergiD.Text);
            command.Parameters.AddWithValue("@p6", txtAlici.Text);
            command.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
            command.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            command.Parameters.AddWithValue("@k1", txtId.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                _listele();
                _bilgiTemizle();
            }
            else
            {

            }

        }

        //gridview deki bilgileri araçlara taşıma işlemi için metod
        private void _araclaraTasi()
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                txtId.Text = dataRow["FaturaBilgiId"].ToString();
                txtSeri.Text = dataRow["Seri"].ToString();
                txtSiraNo.Text = dataRow["SiraNo"].ToString();
                mskTarih.Text = dataRow["Tarih"].ToString();
                mskSaat.Text = dataRow["Saat"].ToString();
                txtVergiD.Text = dataRow["VergiDaire"].ToString();
                txtAlici.Text = dataRow["Alici"].ToString();
                txtTeslimEden.Text = dataRow["TeslimEden"].ToString();
                txtTeslimAlan.Text = dataRow["TeslimAlan"].ToString();
            }
        }

        //urun özellikleini bulup araclara tasımak içi gerekli metod
        private void _urunBul()
        {
            SqlCommand command = new SqlCommand("Select UrunAd,SatisFiyat from Tbl_Urunler where Id=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtUrunAd.Text = dataReader[0].ToString();
                txtFiyat.Text = dataReader[1].ToString();
            }
            bgl.baglanti().Close();
        }

        //luePersonele mevkisi satıs sorumlusu olan personelleri cekme metodu
        private void _personelCekme()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Id,Ad,Soyad from Tbl_Personeller where Gorev='Satış sorumlusu'", bgl.baglanti());
            DataTable dataTable = new DataTable();
            luePersonel.Properties.NullText = "Bir personel seçiniz..";
            dataAdapter.Fill(dataTable);
            luePersonel.Properties.ValueMember = "Id";
            luePersonel.Properties.DisplayMember = "Ad";
            luePersonel.Properties.DataSource = dataTable;
        }

        //luecariye müsteri veya firmaya göre verileri aktarma metodu
        private void _cariAktarma()
        {
            if (cmbCari.Text == "Firma")
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Id,Isim from Tbl_Firmalar", bgl.baglanti());
                DataTable dataTable = new DataTable();
                dataTable.Clear();
                lueCari.Properties.NullText = "Bir firma seçiniz..";
                dataAdapter.Fill(dataTable);
                lueCari.Properties.ValueMember = "Id";
                lueCari.Properties.DisplayMember = "Isim";
                lueCari.Properties.DataSource = dataTable;
            }
            if (cmbCari.Text == "Müşteri")
            {
                lueCari.Text = null;
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter("Select Id,Ad,Soyad from Tbl_Musteriler", bgl.baglanti());
                DataTable dataTable1 = new DataTable();
                dataTable1.Clear();
                lueCari.Properties.NullText = "Bir müşteri seçiniz..";
                dataAdapter1.Fill(dataTable1);
                lueCari.Properties.ValueMember = "Id";
                lueCari.Properties.DisplayMember = "Ad";
                lueCari.Properties.DataSource = dataTable1;
            }
            else
            {

            }
        }

        private void Frm_Faturalar_Load(object sender, EventArgs e)
        {
            _listele();
            _personelCekme();
        }

        private void pictureEdit1_Properties_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _faturaEkle();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            _bilgiTemizle();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            _detayTemizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _araclaraTasi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _faturaSil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _bilgiGuncelle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_FaturaUrunler FUrunlar = new Frm_FaturaUrunler();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                FUrunlar.id = dataRow["FaturaBilgiId"].ToString();
            }
            FUrunlar.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _urunBul();
        }

        private void cmbCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cariAktarma();
        }
    }
}
