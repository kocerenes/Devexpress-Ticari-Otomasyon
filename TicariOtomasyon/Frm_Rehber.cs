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
    public partial class Frm_Rehber : Form
    {
        public Frm_Rehber()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void _musteriListe()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Ad,Soyad,Telefon,Telefon2,Mail from Tbl_Musteriler", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void _firmaListe()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Isim,YetkiliAdSoyad,Telefon1,Telefon2,Telefon3,Fax,Mail from Tbl_Firmalar", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl2.DataSource = dataTable;
        }

        private void Frm_Rehber_Load(object sender, EventArgs e)
        {
            _musteriListe();
            _firmaListe();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_Mail fr_mail = new Frm_Mail();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                fr_mail.mail = dataRow["Mail"].ToString();
            }
            fr_mail.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            Frm_Mail fr_mail2 = new Frm_Mail();
            DataRow dataRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if (dataRow!=null)
            {
                fr_mail2.mail = dataRow["Mail"].ToString();
            }
            fr_mail2.Show();
        }
    }
}
