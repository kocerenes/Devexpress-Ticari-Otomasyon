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
    public partial class Frm_StokUrunDetay : Form
    {
        public Frm_StokUrunDetay()
        {
            InitializeComponent();
        }

        public string urunAd;

        sqlBaglanti bgl = new sqlBaglanti();

        //ürün adına göre ürün bilgilerini getiren metod
        private void _urunBilgi()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Urunler where UrunAd='" + urunAd+"'", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void Frm_StokUrunDetay_Load(object sender, EventArgs e)
        {
            _urunBilgi();
        }
    }
}
