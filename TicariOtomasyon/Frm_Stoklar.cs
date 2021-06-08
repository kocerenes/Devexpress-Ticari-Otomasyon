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
    public partial class Frm_Stoklar : Form
    {
        public Frm_Stoklar()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        //gridviewe urunlerin ismini ve adetini kategorize eden metod
        private void _listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select UrunAd,Sum(Adet) as 'Adet' from Tbl_Urunler Group by UrunAd", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        //charta verileri cekmek için metod
        private void _chartaCek()
        {
            SqlCommand command = new SqlCommand("Select UrunAd, Sum(Adet) as 'Adet' from Tbl_Urunler Group by UrunAd", bgl.baglanti());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dataReader[0]), Convert.ToInt16(dataReader[1]));
            }
            bgl.baglanti().Close();
        }

        //ÜRÜNE İKİ KERE TIKLAYINCA ÜRÜNÜN DETAYLARINI GÖSTERMEK İÇİN METOD
        private void _urunDetay()
        {
            Frm_StokUrunDetay stokUrunDetay = new Frm_StokUrunDetay();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                stokUrunDetay.urunAd = dataRow["UrunAd"].ToString();
            }
            stokUrunDetay.Show();
        }

        private void Frm_Stoklar_Load(object sender, EventArgs e)
        {
            _listele();
            _chartaCek();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _urunDetay();
        }
    }
}
