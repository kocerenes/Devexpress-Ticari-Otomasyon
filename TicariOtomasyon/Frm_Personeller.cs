using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class Frm_Personeller : Form
    {
        public Frm_Personeller()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void _listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Personeller", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void _temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTc.Text = "";
            mskTel.Text = "";  
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtGorev.Text = "";
            rtbAdres.Text = "";
        }

        private void _sehirListe()
        {
            SqlCommand command = new SqlCommand("Select sehir from Tbl_Iller", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIl.Items.Add(dataReader[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void pictureEdit1_Properties_Click(object sender, EventArgs e)
        {
            _temizle();
        }

        private void Frm_Personeller_Load(object sender, EventArgs e)
        {
            _sehirListe();
            _listele();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();

            SqlCommand command = new SqlCommand("select ilce from Tbl_Ilceler where sehir=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIlce.Items.Add(dataReader[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Personeller (Ad,Soyad,Telefon,Tc,Mail,Il,Ilce,Gorev,Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", mskTel.Text);
            command.Parameters.AddWithValue("@p4", mskTc.Text);
            command.Parameters.AddWithValue("@p5", txtMail.Text);
            command.Parameters.AddWithValue("@p6", cmbIl.Text);
            command.Parameters.AddWithValue("@p7", cmbIlce.Text);
            command.Parameters.AddWithValue("@p8", txtGorev.Text);
            command.Parameters.AddWithValue("@p9", rtbAdres.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel ekleme işleme başarıyla gerçekleştirildi.");
            _listele();
            _temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Personeli silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete from Tbl_Personeller where Id=@k1", bgl.baglanti());
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                txtId.Text = dataRow["Id"].ToString();
                txtAd.Text = dataRow["Ad"].ToString();
                txtSoyad.Text = dataRow["Soyad"].ToString();
                mskTel.Text = dataRow["Telefon"].ToString();
                mskTc.Text = dataRow["Tc"].ToString();
                txtMail.Text = dataRow["Mail"].ToString();
                cmbIl.Text = dataRow["Il"].ToString();
                cmbIlce.Text = dataRow["Ilce"].ToString();
                txtGorev.Text = dataRow["Gorev"].ToString();
                rtbAdres.Text = dataRow["Adres"].ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Personelin bilgilerini güncellemek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Update Tbl_Personeller set Ad=@p1,Soyad=@p2,Telefon=@p3,Tc=@p4,Mail=@p5,Il=@p6,Ilce=@p7,Gorev=@p8,Adres=@p9 where Id=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", mskTel.Text);
            command.Parameters.AddWithValue("@p4", mskTc.Text);
            command.Parameters.AddWithValue("@p5", txtMail.Text);
            command.Parameters.AddWithValue("@p6", cmbIl.Text);
            command.Parameters.AddWithValue("@p7", cmbIlce.Text);
            command.Parameters.AddWithValue("@p8", txtGorev.Text);
            command.Parameters.AddWithValue("@p9", rtbAdres.Text);
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
    }
}
