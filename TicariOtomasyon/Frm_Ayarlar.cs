using DevExpress.XtraBars;
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
    public partial class Frm_Ayarlar : Form
    {
        public Frm_Ayarlar()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void _listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Admin", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        //admin ekleme metodu
        private void _kaydet()
        {
            if (txtKullanici.Text!="" && txtSifre.Text!="")
            {
                SqlCommand command = new SqlCommand("Insert into Tbl_Admin values (@p1,@p2)", bgl.baglanti());
                command.Parameters.AddWithValue("@p1", txtKullanici.Text);
                command.Parameters.AddWithValue("@p2", txtSifre.Text);
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Admin başarıyla sisteme kaydedildi.");
                txtUyarı.Text = "";
            }
            else
            {
                txtUyarı.Text = "!!! Kullanıcı adı veya şifre alanı boş bırakılamaz!!!";
            }
        }

        //temizlme metodu
        private void _temizle()
        {
            txtKullanici.Text = "";
            txtSifre.Text = "";
        }

        //verileri araclara aktarma
        private void _araclaraTasi()
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                txtKullanici.Text = dataRow[0].ToString();
                txtSifre.Text = dataRow[1].ToString();
            }
        }

        //silme islemi için metod
        private void _sil()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silmek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete from Tbl_Admin where KullaniciAd=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtKullanici.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                _listele();
            }
            else
            {

            }
        }

        //güncelleme islemi için metod
        private void _guncelle()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Update Tbl_Admin set Sifre=@p1 where KullaniciAd=@p2", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtSifre.Text);
            command.Parameters.AddWithValue("@p2", txtKullanici.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                _listele();
            }
            else
            {

            }
        }

        private void Frm_Ayarlar_Load(object sender, EventArgs e)
        {
            _listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _kaydet();
            _listele();
            _temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _araclaraTasi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _sil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _guncelle();
        }
    }
}
