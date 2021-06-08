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
    public partial class Frm_Bankalar : Form
    {
        public Frm_Bankalar()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        //gridviewe banka bilgilerini yazdırma metodu
        private void _listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute BankaBilgileri", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        // araclar içindeki yazıları sildirmek için yazılan metod
        private void _temizle()
        {
            txtId.Text = "";
            txtBankaAd.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtSube.Text = "";
            mskIban.Text = "";
            mskHesapNo.Text = "";
            txtYetkili.Text = "";
            mskTelefon.Text = "";
            mskTarih.Text = "";
            txtHesapTuru.Text = "";
            lueFirma.Text = null;
        }

        //yeni banka bilgileri eklemek için oluşturulan metod
        private void _bankaEkle()
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Bankalar (BankaAdi,Il,Ilce,Sube,Iban,HesapNo,Yetkili,Telefon,Tarih,HesapTuru,FirmaId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtBankaAd.Text);
            command.Parameters.AddWithValue("@p2", cmbIl.Text);
            command.Parameters.AddWithValue("@p3", cmbIlce.Text);
            command.Parameters.AddWithValue("@p4", txtSube.Text);
            command.Parameters.AddWithValue("@p5", mskIban.Text);
            command.Parameters.AddWithValue("@p6", mskHesapNo.Text);
            command.Parameters.AddWithValue("@p7", txtYetkili.Text);
            command.Parameters.AddWithValue("@p8", mskTelefon.Text);
            command.Parameters.AddWithValue("@p9", mskTarih.Text);
            command.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
            command.Parameters.AddWithValue("@p11", lueFirma.EditValue);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka bilgileri başarıyla kaydedildi.");
            _listele();
        }

        //cmbIl aracına sehirleri listelemek için olusturulan metod
        private void _sehirListe()
        {
            SqlCommand command = new SqlCommand("Select sehir from Tbl_Iller", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIl.Items.Add(dataReader[0]);
            }
            bgl.baglanti().Close();
        }

        //lookupedit e firma ıd ve ismini yazdırmak için metod olusturduk.
        private void _firmaListe()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Id,Isim from Tbl_Firmalar", bgl.baglanti());
            DataTable dataTable = new DataTable();
            lueFirma.Properties.NullText = "Bir firma seçiniz..";
            dataAdapter.Fill(dataTable);
            lueFirma.Properties.ValueMember = "Id";
            lueFirma.Properties.DisplayMember = "Isim";
            lueFirma.Properties.DataSource = dataTable;
        }

        //gridviewdeki bilgileri araçlara taşımak için olusturulan metod
        private void _araclaraTasi()
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                txtId.Text = dataRow["Id"].ToString();
                txtBankaAd.Text = dataRow["BankaAdi"].ToString();
                cmbIl.Text = dataRow["Il"].ToString();
                cmbIlce.Text = dataRow["Ilce"].ToString();
                txtSube.Text = dataRow["Sube"].ToString();
                mskIban.Text = dataRow["Iban"].ToString();
                mskHesapNo.Text = dataRow["HesapNo"].ToString();
                txtYetkili.Text = dataRow["Yetkili"].ToString();
                mskTelefon.Text = dataRow["Telefon"].ToString();
                mskTarih.Text = dataRow["Tarih"].ToString();
                txtHesapTuru.Text = dataRow["HesapTuru"].ToString();
                //lueFirma.EditValue = lueFirma.Properties.GetKeyValueByDisplayText(dataRow["FirmaId"].ToString());
            }
        }

        // sectiğimiz ıd ye göre banka bilgilerini silmek için metod
        private void _bankaSil()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Banka bilgilerini silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete Tbl_Bankalar where Id=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@k1", txtId.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                _listele();
                _temizle();
            }
            else
            {
                
            }
        }

        // sectiğimiz ıd ye göre banka bilgilerini güncellemek için metod
        private void _bankaGuncelle()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Banka bilgilerini silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Update Tbl_Bankalar set BankaAdi=@p1,Il=@p2,Ilce=@p3,Sube=@p4,Iban=@p5,HesapNo=@p6,Yetkili=@p7,Telefon=@p8,Tarih=@p9,HesapTuru=@p10,FirmaId=@p11 where Id=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtBankaAd.Text);
            command.Parameters.AddWithValue("@p2", cmbIl.Text);
            command.Parameters.AddWithValue("@p3", cmbIlce.Text);
            command.Parameters.AddWithValue("@p4", txtSube.Text);
            command.Parameters.AddWithValue("@p5", mskIban.Text);
            command.Parameters.AddWithValue("@p6", mskHesapNo.Text);
            command.Parameters.AddWithValue("@p7", txtYetkili.Text);
            command.Parameters.AddWithValue("@p8", mskTelefon.Text);
            command.Parameters.AddWithValue("@p9", mskTarih.Text);
            command.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
            command.Parameters.AddWithValue("@p11", lueFirma.EditValue);
            command.Parameters.AddWithValue("@k1", txtId.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                _listele();
                _temizle();
            }
            else
            {
                             
            }
        }

        //form açılınca
        private void Frm_Bankalar_Load(object sender, EventArgs e)
        {
            _listele();
            _temizle();
            _sehirListe();
            _firmaListe();
        }

        //kaydet butonuna tıklanınca
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _bankaEkle();
        }

        //sil butonuna tıklanınca
        private void btnSil_Click(object sender, EventArgs e)
        {
            _bankaSil();
        }

        //güncelle butonuna tıklanınca
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _bankaGuncelle();
        }

        //silgi simgesine tıklanınca
        private void pictureEdit1_Properties_Click(object sender, EventArgs e)
        {
            _temizle();
        }

        //cmbıl aracından il secildiğinde gercekleşicek durumlar
        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();

            SqlCommand command = new SqlCommand("Select ilce from Tbl_Ilceler where sehir=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                cmbIlce.Items.Add(dataReader[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _araclaraTasi();
        }
    }
}
