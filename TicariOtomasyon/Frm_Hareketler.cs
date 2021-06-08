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
    public partial class Frm_Hareketler : Form
    {
        public Frm_Hareketler()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void _firmaHareket()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute FirmaHareket", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl2.DataSource = dataTable;
        }

        private void _musteriHareket()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute MusteriHareket", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        private void Frm_Hareketler_Load(object sender, EventArgs e)
        {
            _firmaHareket();
            _musteriHareket();
        }
    }
}
