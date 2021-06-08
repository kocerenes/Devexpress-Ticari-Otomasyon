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
    public partial class Frm_Giderler : Form
    {
        public Frm_Giderler()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void _giderListe()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Giderler", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void _temizle()
        {
            txtId.Text = "";
            cmbAy.Text = "";
            cmbYil.Text = "";
            txtElektrik.Text = "";
            txtSu.Text = "";
            txtDogalgaz.Text = "";
            txtInternet.Text = "";
            txtMaas.Text = "";
            txtEkstra.Text = "";
            rtbNot.Text = "";
        }

        private void _araclaraTasi()
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                txtId.Text = dataRow["Id"].ToString();
                cmbAy.Text = dataRow["Ay"].ToString();
                cmbYil.Text = dataRow["Yil"].ToString();
                txtElektrik.Text = dataRow["Elektrik"].ToString();
                txtSu.Text = dataRow["Su"].ToString();
                txtDogalgaz.Text = dataRow["Dogalgaz"].ToString();
                txtInternet.Text = dataRow["Internet"].ToString();
                txtMaas.Text = dataRow["Maaslar"].ToString();
                txtEkstra.Text = dataRow["Ekstra"].ToString();
                rtbNot.Text = dataRow["Notlar"].ToString();
            }
        }

        private void _giderEkle()
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Giderler (Ay,Yil,Elektrik,Su,Dogalgaz,Internet,Maaslar,Ekstra,Notlar) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbAy.Text);
            command.Parameters.AddWithValue("@p2", cmbYil.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrik.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
            command.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
            command.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(txtMaas.Text));
            command.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            command.Parameters.AddWithValue("@p9", rtbNot.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Giderleri ekleme işlemi başarıyla tanımlanmıştır.");
            _giderListe();
        }

        private void _giderSil()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Gider satırını silmek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Delete from Tbl_Giderler where Id=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@k1", txtId.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                _giderListe();
                _temizle();
            }
            else
            {

            }
        }

        private void _giderGuncelle()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Gider satırındaki bilgileri güncellemek istediğinizden emin misiniz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlCommand command = new SqlCommand("Update Tbl_Giderler set Ay=@p1,Yil=@p2,Elektrik=@p3,Su=@p4,Dogalgaz=@p5,Internet=@p6,Maaslar=@p7,Ekstra=@p8,Notlar=@p8 where Id=@k1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", cmbAy.Text);
            command.Parameters.AddWithValue("@p2", cmbYil.Text);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtElektrik.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
            command.Parameters.AddWithValue("@p5", decimal.Parse(txtDogalgaz.Text));
            command.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(txtMaas.Text));
            command.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
            command.Parameters.AddWithValue("@p9", rtbNot.Text);
            command.Parameters.AddWithValue("@k1", txtId.Text);

            if (dialog==DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                bgl.baglanti().Close();
                _giderListe();
                _temizle();
            }
            else
            {

            }
        }

        private void Frm_Giderler_Load(object sender, EventArgs e)
        {
            _giderListe();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _araclaraTasi();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _giderEkle();
        }

        private void pictureEdit1_Properties_Click(object sender, EventArgs e)
        {
            _temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _giderSil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _giderGuncelle();
        }
    }
}
