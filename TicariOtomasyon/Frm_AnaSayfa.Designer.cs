namespace TicariOtomasyon
{
    partial class Frm_AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AnaSayfa));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.grdFihrist1 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grdHareket1 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdAjanda1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdStok1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFihrist1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHareket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAjanda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStok1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.xtraTabControl1.Location = new System.Drawing.Point(1044, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(478, 742);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.webBrowser1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(476, 712);
            this.xtraTabPage1.Text = "Döviz kurları";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(476, 712);
            this.xtraTabPage2.Text = "Haberler";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.groupControl4);
            this.groupControl5.Controls.Add(this.groupControl3);
            this.groupControl5.Controls.Add(this.groupControl2);
            this.groupControl5.Controls.Add(this.groupControl1);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl5.Location = new System.Drawing.Point(0, 0);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.ShowCaption = false;
            this.groupControl5.Size = new System.Drawing.Size(1039, 742);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "groupControl5";
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupControl4.Controls.Add(this.grdFihrist1);
            this.groupControl4.Location = new System.Drawing.Point(528, 370);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(497, 342);
            this.groupControl4.TabIndex = 7;
            this.groupControl4.Text = "Fihrist";
            // 
            // grdFihrist1
            // 
            this.grdFihrist1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdFihrist1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.grdFihrist1.Location = new System.Drawing.Point(2, 28);
            this.grdFihrist1.MainView = this.gridView4;
            this.grdFihrist1.Margin = new System.Windows.Forms.Padding(5);
            this.grdFihrist1.Name = "grdFihrist1";
            this.grdFihrist1.Size = new System.Drawing.Size(493, 301);
            this.grdFihrist1.TabIndex = 2;
            this.grdFihrist1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView4.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView4.Appearance.Row.Options.UseBackColor = true;
            this.gridView4.DetailHeight = 546;
            this.gridView4.GridControl = this.grdFihrist1;
            this.gridView4.Name = "gridView4";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupControl3.Controls.Add(this.grdHareket1);
            this.groupControl3.Location = new System.Drawing.Point(12, 370);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(497, 342);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Son 10 hareket";
            // 
            // grdHareket1
            // 
            this.grdHareket1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdHareket1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.grdHareket1.Location = new System.Drawing.Point(2, 28);
            this.grdHareket1.MainView = this.gridView3;
            this.grdHareket1.Margin = new System.Windows.Forms.Padding(5);
            this.grdHareket1.Name = "grdHareket1";
            this.grdHareket1.Size = new System.Drawing.Size(493, 301);
            this.grdHareket1.TabIndex = 2;
            this.grdHareket1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView3.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.DetailHeight = 546;
            this.gridView3.GridControl = this.grdHareket1;
            this.gridView3.Name = "gridView3";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupControl2.Controls.Add(this.grdAjanda1);
            this.groupControl2.Location = new System.Drawing.Point(528, 32);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(497, 332);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Ajanda";
            // 
            // grdAjanda1
            // 
            this.grdAjanda1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdAjanda1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.grdAjanda1.Location = new System.Drawing.Point(2, 28);
            this.grdAjanda1.MainView = this.gridView1;
            this.grdAjanda1.Margin = new System.Windows.Forms.Padding(5);
            this.grdAjanda1.Name = "grdAjanda1";
            this.grdAjanda1.Size = new System.Drawing.Size(493, 292);
            this.grdAjanda1.TabIndex = 2;
            this.grdAjanda1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.grdAjanda1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupControl1.Controls.Add(this.grdStok1);
            this.groupControl1.Location = new System.Drawing.Point(12, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(497, 332);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Azalan stoklar";
            // 
            // grdStok1
            // 
            this.grdStok1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdStok1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.grdStok1.Location = new System.Drawing.Point(2, 28);
            this.grdStok1.MainView = this.gridView2;
            this.grdStok1.Margin = new System.Windows.Forms.Padding(5);
            this.grdStok1.Name = "grdStok1";
            this.grdStok1.Size = new System.Drawing.Size(493, 288);
            this.grdStok1.TabIndex = 2;
            this.grdStok1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.DetailHeight = 546;
            this.gridView2.GridControl = this.grdStok1;
            this.gridView2.Name = "gridView2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(476, 712);
            this.webBrowser1.TabIndex = 0;
            // 
            // Frm_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 742);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.xtraTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_AnaSayfa";
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Frm_AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFihrist1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHareket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAjanda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStok1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl grdFihrist1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl grdHareket1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grdAjanda1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grdStok1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}