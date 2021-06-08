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
    public partial class Frm_Musteriler : Form
    {
        public Frm_Musteriler()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void _listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Musteriler", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void _sehirListe()
        {
            SqlCommand command = new SqlCommand("select sehir from Tbl_Iller", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIl.Properties.Items.Add(dataReader[0]);
            }
            bgl.baglanti().Close();
        }

        private void _temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTel1.Text = "";
            mskTel2.Text = "";
            mskTc.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtVergiD.Text = "";
            rtbAdres.Text = "";
        }

        private void Frm_Musteriler_Load(object sender, EventArgs e)
        {
            _listele();
            _sehirListe();
            _temizle();
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Properties.Items.Clear();

            SqlCommand command = new SqlCommand("Select ilce from Tbl_Ilceler where sehir=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbIlce.Properties.Items.Add(dataReader[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Musteriler (Ad,Soyad,Telefon,Telefon2,Tc,Mail,Il,Ilce,VergiDairesi,Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", mskTel1.Text);
            command.Parameters.AddWithValue("@p4", mskTel2.Text);
            command.Parameters.AddWithValue("@p5", mskTc.Text);
            command.Parameters.AddWithValue("@p6", txtMail.Text);
            command.Parameters.AddWithValue("@p7", cmbIl.Text);
            command.Parameters.AddWithValue("@p8", cmbIlce.Text);
            command.Parameters.AddWithValue("@p9", txtVergiD.Text);
            command.Parameters.AddWithValue("@p10", rtbAdres.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müsteri başarıyla eklendi.");
            _listele();
            _temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                txtId.Text = dataRow["Id"].ToString();
                txtAd.Text = dataRow["Ad"].ToString();
                txtSoyad.Text = dataRow["Soyad"].ToString();
                mskTel1.Text = dataRow["Telefon"].ToString();
                mskTel2.Text = dataRow["Telefon2"].ToString();
                mskTc.Text = dataRow["Tc"].ToString();
                txtMail.Text = dataRow["Mail"].ToString();
                cmbIl.Text = dataRow["Il"].ToString();
                cmbIlce.Text = dataRow["Ilce"].ToString();
                txtVergiD.Text = dataRow["VergiDairesi"].ToString();
                rtbAdres.Text = dataRow["Adres"].ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Müşteriyi silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete from Tbl_Musteriler where Id=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@k1", txtId.Text);

            if (dialogResult==DialogResult.Yes)
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Müsteri bilgilerini güncellemek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Update Tbl_Musteriler set Ad=@p1,Soyad=@p2,Telefon=@p3,Telefon2=@p4,Tc=@p5,Mail=@p6,Il=@p7,Ilce=@p8,VergiDairesi=@p9,Adres=@p10 where Id=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", mskTel1.Text);
            command.Parameters.AddWithValue("@p4", mskTel2.Text);
            command.Parameters.AddWithValue("@p5", mskTc.Text);
            command.Parameters.AddWithValue("@p6", txtMail.Text);
            command.Parameters.AddWithValue("@p7", cmbIl.Text);
            command.Parameters.AddWithValue("@p8", cmbIlce.Text);
            command.Parameters.AddWithValue("@p9", txtVergiD.Text);
            command.Parameters.AddWithValue("@p10", rtbAdres.Text);
            command.Parameters.AddWithValue("@k1", txtId.Text);

            if (dialogResult==DialogResult.Yes)
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

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            _temizle();
        }
    }
}
