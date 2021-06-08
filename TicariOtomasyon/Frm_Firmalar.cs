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
using DevExpress.Utils.Extensions;

namespace TicariOtomasyon
{
    public partial class Frm_Firmalar : Form
    {
        public Frm_Firmalar()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void _listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Firmalar", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void _temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSektör.Text = "";
            txtYetkili.Text = "";
            txtStatü.Text = "";
            mskTc.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            mskTel3.Text = "";
            mskfax.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtVergiD.Text = "";
            rtbAdres.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
        }

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

        private void _cariKod()
        {
            SqlCommand command = new SqlCommand("Select FirmaKod1 from Tbl_Kodlar", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                rtbKod1.Text = dataReader[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void Frm_Firmalar_Load(object sender, EventArgs e)
        {
            _listele();
            _temizle();
            _sehirListe();
            _cariKod();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                txtId.Text = dataRow["Id"].ToString();
                txtAd.Text = dataRow["Isim"].ToString();
                txtSektör.Text = dataRow["Sektor"].ToString();
                txtYetkili.Text = dataRow["YetkiliAdSoyad"].ToString();
                txtStatü.Text = dataRow["YetkiliStatu"].ToString();
                mskTc.Text = dataRow["YetkiliTc"].ToString();
                mskTel1.Text = dataRow["Telefon1"].ToString();
                mskTel2.Text = dataRow["Telefon2"].ToString();
                mskTel3.Text = dataRow["Telefon3"].ToString();
                mskfax.Text = dataRow["Fax"].ToString();
                txtMail.Text = dataRow["Mail"].ToString();
                cmbIl.Text = dataRow["Il"].ToString();
                cmbIlce.Text = dataRow["Ilce"].ToString();
                txtVergiD.Text = dataRow["VergiDairesi"].ToString();
                rtbAdres.Text = dataRow["Adres"].ToString();
                txtKod1.Text = dataRow["OzelKod1"].ToString();
                txtKod2.Text = dataRow["OZelKod2"].ToString();
                txtKod3.Text = dataRow["OzelKod3"].ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //firma ekleme işlemi
            SqlCommand command = new SqlCommand("Insert into Tbl_Firmalar (Isim,Sektor,YetkiliAdSoyad,YetkiliStatu,YetkiliTc,Telefon1,Telefon2,Telefon3,Fax,Mail,Il,Ilce,VergiDairesi,Adres,OzelKod1,OzelKod2,OzelKod3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSektör.Text);
            command.Parameters.AddWithValue("@p3", txtYetkili.Text);
            command.Parameters.AddWithValue("@p4", txtStatü.Text);
            command.Parameters.AddWithValue("@p5", mskTc.Text);
            command.Parameters.AddWithValue("@p6", mskTel1.Text);
            command.Parameters.AddWithValue("@p7", mskTel2.Text);
            command.Parameters.AddWithValue("@p8", mskTel3.Text);
            command.Parameters.AddWithValue("@p9", mskfax.Text);
            command.Parameters.AddWithValue("@p10", txtMail.Text);
            command.Parameters.AddWithValue("@p11", cmbIl.Text);
            command.Parameters.AddWithValue("@p12", cmbIlce.Text);
            command.Parameters.AddWithValue("@p13", txtVergiD.Text);
            command.Parameters.AddWithValue("@p14", rtbAdres.Text);
            command.Parameters.AddWithValue("@p15", txtKod1.Text);
            command.Parameters.AddWithValue("@p16", txtKod2.Text);
            command.Parameters.AddWithValue("@p17", txtKod3.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma başarıyla eklenmiştir.");
            _listele();
            _temizle();
        }

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Firmayı silmek istediğinize emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete from Tbl_Firmalar where Id=@k1", bgl.baglanti());
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
                _temizle();
            }   
        }

        private void pictureEdit1_Properties_Click(object sender, EventArgs e)
        {
            _temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Firma bilgilerini güncellemek istediğinize emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Update Tbl_Firmalar set Isim=@p1,Sektor=@p2,YetkiliAdSoyad=@p3,YetkiliStatu=@p4,YetkiliTc=@p5,Telefon1=@p6,Telefon2=@p7,Telefon3=@p8,Fax=@p9,Mail=@p10,Il=@p11,Ilce=@p12,VergiDairesi=@p13,Adres=@p14,OzelKod1=@p15,OzelKod2=@p16,OzelKod3=@p17 where Id=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSektör.Text);
            command.Parameters.AddWithValue("@p3", txtYetkili.Text);
            command.Parameters.AddWithValue("@p4", txtStatü.Text);
            command.Parameters.AddWithValue("@p5", mskTc.Text);
            command.Parameters.AddWithValue("@p6", mskTel1.Text);
            command.Parameters.AddWithValue("@p7", mskTel2.Text);
            command.Parameters.AddWithValue("@p8", mskTel3.Text);
            command.Parameters.AddWithValue("@p9", mskfax.Text);
            command.Parameters.AddWithValue("@p10", txtMail.Text);
            command.Parameters.AddWithValue("@p11", cmbIl.Text);
            command.Parameters.AddWithValue("@p12", cmbIlce.Text);
            command.Parameters.AddWithValue("@p13", txtVergiD.Text);
            command.Parameters.AddWithValue("@p14", rtbAdres.Text);
            command.Parameters.AddWithValue("@p15", txtKod1.Text);
            command.Parameters.AddWithValue("@p16", txtKod2.Text);
            command.Parameters.AddWithValue("@p17", txtKod3.Text);
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
                _temizle();
            }

        }
    }
}
