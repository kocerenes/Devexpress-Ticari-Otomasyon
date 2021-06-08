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
using DevExpress.Utils.DirectXPaint.Svg;

namespace TicariOtomasyon
{
    public partial class Frm_Urunler : Form
    {
        public Frm_Urunler()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void _listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Urunler", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void _temizle()
        {
            txtAd.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            mskYil.Text = "";
            nudAdet.Value = 0;
            txtAlisfiyat.Text = "";
            txtSatisfiyat.Text = "";
            rtbDetay.Text = "";
        }

        private void Frm_Urunler_Load(object sender, EventArgs e)
        { 
            _listele();
            _temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Urunler (UrunAd,Marka,Model,Yil,Adet,AlisFiyat,SatisFiyat,Detay) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtMarka.Text);
            command.Parameters.AddWithValue("@p3", txtModel.Text);
            command.Parameters.AddWithValue("@p4", mskYil.Text);
            command.Parameters.AddWithValue("@p5", int.Parse(nudAdet.Value.ToString()));
            command.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisfiyat.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisfiyat.Text));
            command.Parameters.AddWithValue("@p8", rtbDetay.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün başarıyla eklenmiştir.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _temizle();
            _listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ürünü silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete from Tbl_Urunler where Id=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txt.Text);
            if (dialog == DialogResult.Yes)
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txt.Text = dataRow["Id"].ToString();
            txtAd.Text = dataRow["UrunAd"].ToString();
            txtMarka.Text = dataRow["Marka"].ToString();
            txtModel.Text = dataRow["Model"].ToString();
            mskYil.Text = dataRow["Yil"].ToString();
            nudAdet.Value = int.Parse(dataRow["Adet"].ToString());
            txtAlisfiyat.Text = dataRow["AlisFiyat"].ToString();
            txtSatisfiyat.Text = dataRow["SatisFiyat"].ToString();
            rtbDetay.Text = dataRow["Detay"].ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Ürün bilgilerini güncellemek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Update Tbl_Urunler set UrunAd=@k1,Marka=@k2,Model=@k3,Yil=@k4,Adet=@k5,AlisFiyat=@k6,SatisFiyat=@k7,Detay=@k8 where Id=@k9", bgl.baglanti());
            command.Parameters.AddWithValue("@k1", txtAd.Text);
            command.Parameters.AddWithValue("@k2", txtMarka.Text);
            command.Parameters.AddWithValue("@k3", txtModel.Text);
            command.Parameters.AddWithValue("@k4", mskYil.Text);
            command.Parameters.AddWithValue("@k5", int.Parse(nudAdet.Value.ToString()));
            command.Parameters.AddWithValue("@k6", decimal.Parse(txtAlisfiyat.Text));
            command.Parameters.AddWithValue("@k7", decimal.Parse(txtSatisfiyat.Text));
            command.Parameters.AddWithValue("@k8", rtbDetay.Text);
            command.Parameters.AddWithValue("@k9", txt.Text);
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

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            _temizle();
        }
    }
}
