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
    public partial class Frm_Notlar : Form
    {
        public Frm_Notlar()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        // notları gridviewe listelemek için metod
        private void _listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Notlar", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void _temizle()
        {
            txtId.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtBaslik.Text = "";
            txtOlusturan.Text = "";
            txtKime.Text = "";
            rtbDetay.Text = "";
        }

        //YEni not eklemek için metod
        private void _notEkle()
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Notlar (Tarih,Saat,Baslik,Olusturan,Kime,Detay) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", mskTarih.Text);
            command.Parameters.AddWithValue("@p2", mskSaat.Text);
            command.Parameters.AddWithValue("@p3", txtBaslik.Text);
            command.Parameters.AddWithValue("@p4", txtOlusturan.Text);
            command.Parameters.AddWithValue("@p5", txtKime.Text);
            command.Parameters.AddWithValue("@p6", rtbDetay.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not başarıyla eklendi.");
            _listele();
            _temizle();
        }

        //araçlara verileri taşıma için metod
        private void _araclaraTasi()
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                txtId.Text = dataRow["Id"].ToString();
                mskTarih.Text = dataRow["Tarih"].ToString();
                mskSaat.Text = dataRow["Saat"].ToString();
                txtBaslik.Text = dataRow["Baslik"].ToString();
                txtOlusturan.Text = dataRow["Olusturan"].ToString();
                txtKime.Text = dataRow["Kime"].ToString();
                rtbDetay.Text = dataRow["Detay"].ToString();
            }
        }

        //not silmek için metod
        private void _notSil()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Notu silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete Tbl_Notlar where Id=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", txtId.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                _listele();
            }
            else
            {

            }
        }

        //notu güncellemek için metod
        private void _notGuncelle()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Notu silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Update Tbl_Notlar set Tarih=@p1,Saat=@p2,Baslik=@p3,Olusturan=@p4,Kime=@p5,Detay=@p6 where Id=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", mskTarih.Text);
            command.Parameters.AddWithValue("@p2", mskSaat.Text);
            command.Parameters.AddWithValue("@p3", txtBaslik.Text);
            command.Parameters.AddWithValue("@p4", txtOlusturan.Text);
            command.Parameters.AddWithValue("@p5", txtKime.Text);
            command.Parameters.AddWithValue("@p6", rtbDetay.Text);
            command.Parameters.AddWithValue("@k1", txtId.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                _listele();
            }
            else
            {

            }
        }

        //cift tıklandıgında notu baska forma aktarmak için metod
        private void _notAktar()
        {
            Frm_NotDetay notDetay = new Frm_NotDetay();

            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                notDetay.not = dataRow["Detay"].ToString();
            }
            notDetay.Show();
        }


        private void Frm_Notlar_Load(object sender, EventArgs e)
        {
            _listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _notEkle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _araclaraTasi();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            _temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _notSil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _notGuncelle();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            _notAktar();
        }
    }
}
