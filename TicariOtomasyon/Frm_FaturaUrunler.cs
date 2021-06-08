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
using DevExpress.DocumentServices.ServiceModel.ServiceOperations;

namespace TicariOtomasyon
{
    public partial class Frm_FaturaUrunler : Form
    {
        public Frm_FaturaUrunler()
        {
            InitializeComponent();
        }

        public string id;
        sqlBaglanti bgl = new sqlBaglanti();

        //faturaya ait ürünleri listelemek için metod
        private void _listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_FaturaDetay where FaturaId= '" + id + "'", bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void Frm_FaturaUrunler_Load(object sender, EventArgs e)
        {
            _listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Frm_FaturaDetayDüzenleme detayDüzenle = new Frm_FaturaDetayDüzenleme();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                detayDüzenle.urunId = dataRow["FaturaUrunId"].ToString();
            }
            detayDüzenle.Show();
        }
    }
}
