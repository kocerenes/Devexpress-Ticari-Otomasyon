namespace TicariOtomasyon
{
    partial class Frm_Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Giris));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnStok = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteri = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersonel = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketler = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.btnStok,
            this.btnAnaSayfa,
            this.btnMusteri,
            this.btnFirmalar,
            this.btnPersonel,
            this.btnGiderler,
            this.btnKasa,
            this.btnNotlar,
            this.btnBankalar,
            this.btnFaturalar,
            this.btnAyarlar,
            this.barButtonItem13,
            this.btnRehber,
            this.btnUrunler,
            this.btnHareketler,
            this.btnRaporlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(10);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(1924, 98);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "ÜRÜNLER";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnStok
            // 
            this.btnStok.Caption = "STOKLAR";
            this.btnStok.Id = 2;
            this.btnStok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStok.ImageOptions.Image")));
            this.btnStok.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStok.ImageOptions.LargeImage")));
            this.btnStok.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStok.Name = "btnStok";
            this.btnStok.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStok_ItemClick);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Caption = "ANASAYFA";
            this.btnAnaSayfa.Id = 3;
            this.btnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.Image")));
            this.btnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.LargeImage")));
            this.btnAnaSayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAnaSayfa.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnaSayfa_ItemClick);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Caption = "MÜŞTERİLER";
            this.btnMusteri.Id = 4;
            this.btnMusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteri.ImageOptions.Image")));
            this.btnMusteri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteri.ImageOptions.LargeImage")));
            this.btnMusteri.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteri_ItemClick);
            // 
            // btnFirmalar
            // 
            this.btnFirmalar.Caption = "Firmalar";
            this.btnFirmalar.Id = 5;
            this.btnFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.Image")));
            this.btnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.LargeImage")));
            this.btnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFirmalar.Name = "btnFirmalar";
            this.btnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirmalar_ItemClick);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Caption = "Personeller";
            this.btnPersonel.Id = 6;
            this.btnPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.ImageOptions.Image")));
            this.btnPersonel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersonel.ImageOptions.LargeImage")));
            this.btnPersonel.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersonel_ItemClick);
            // 
            // btnGiderler
            // 
            this.btnGiderler.Caption = "Giderler";
            this.btnGiderler.Id = 7;
            this.btnGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.Image")));
            this.btnGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.LargeImage")));
            this.btnGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderler_ItemClick);
            // 
            // btnKasa
            // 
            this.btnKasa.Caption = "Kasa";
            this.btnKasa.Id = 8;
            this.btnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.Image")));
            this.btnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.LargeImage")));
            this.btnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasa_ItemClick);
            // 
            // btnNotlar
            // 
            this.btnNotlar.Caption = "Notlar";
            this.btnNotlar.Id = 9;
            this.btnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.Image")));
            this.btnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.LargeImage")));
            this.btnNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotlar_ItemClick);
            // 
            // btnBankalar
            // 
            this.btnBankalar.Caption = "Bankalar";
            this.btnBankalar.Id = 10;
            this.btnBankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.Image")));
            this.btnBankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.LargeImage")));
            this.btnBankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankalar_ItemClick);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.Caption = "Faturalar";
            this.btnFaturalar.Id = 11;
            this.btnFaturalar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFaturalar.ImageOptions.SvgImage")));
            this.btnFaturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFaturalar_ItemClick);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "Ayarlar";
            this.btnAyarlar.Id = 12;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAyarlar_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Hareketler";
            this.barButtonItem13.Id = 13;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // btnRehber
            // 
            this.btnRehber.Caption = "Rehber";
            this.btnRehber.Id = 14;
            this.btnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.Image")));
            this.btnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.LargeImage")));
            this.btnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRehber.Name = "btnRehber";
            this.btnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRehber_ItemClick);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "ÜRÜNLER";
            this.btnUrunler.Id = 15;
            this.btnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.Image")));
            this.btnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.LargeImage")));
            this.btnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnHareketler
            // 
            this.btnHareketler.Caption = "Hareketler";
            this.btnHareketler.Id = 16;
            this.btnHareketler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHareketler.ImageOptions.SvgImage")));
            this.btnHareketler.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHareketler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHareketler.Name = "btnHareketler";
            this.btnHareketler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHareketler_ItemClick);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Caption = "Raporlar";
            this.btnRaporlar.Id = 17;
            this.btnRaporlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporlar.ImageOptions.SvgImage")));
            this.btnRaporlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporlar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ticari Otomasyon";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnaSayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStok);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteri);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersonel);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHareketler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRaporlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Frm_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticari Otomasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnStok;
        private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem btnMusteri;
        private DevExpress.XtraBars.BarButtonItem btnFirmalar;
        private DevExpress.XtraBars.BarButtonItem btnPersonel;
        private DevExpress.XtraBars.BarButtonItem btnGiderler;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarButtonItem btnNotlar;
        private DevExpress.XtraBars.BarButtonItem btnBankalar;
        private DevExpress.XtraBars.BarButtonItem btnFaturalar;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem btnRehber;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnHareketler;
        private DevExpress.XtraBars.BarButtonItem btnRaporlar;
    }
}

