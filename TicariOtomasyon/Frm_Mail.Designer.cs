namespace TicariOtomasyon
{
    partial class Frm_Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mail));
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbMesaj = new System.Windows.Forms.RichTextBox();
            this.btnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.Indigo;
            this.lblMail.Location = new System.Drawing.Point(23, 109);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(124, 25);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail adresi:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(141, 107);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(270, 30);
            this.txtMail.TabIndex = 1;
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(141, 154);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(270, 30);
            this.txtkonu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(70, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Konu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(64, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesaj:";
            // 
            // rtbMesaj
            // 
            this.rtbMesaj.Location = new System.Drawing.Point(141, 205);
            this.rtbMesaj.Name = "rtbMesaj";
            this.rtbMesaj.Size = new System.Drawing.Size(270, 222);
            this.rtbMesaj.TabIndex = 3;
            this.rtbMesaj.Text = "";
            // 
            // btnGonder
            // 
            this.btnGonder.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGonder.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGonder.Appearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnGonder.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Appearance.Options.UseBackColor = true;
            this.btnGonder.Appearance.Options.UseBorderColor = true;
            this.btnGonder.Appearance.Options.UseFont = true;
            this.btnGonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGonder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGonder.ImageOptions.SvgImage")));
            this.btnGonder.Location = new System.Drawing.Point(200, 433);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(164, 51);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(22, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "MAİL GÖNDERME PANELİ";
            // 
            // Frm_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.rtbMesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Frm_Mail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbMesaj;
        private DevExpress.XtraEditors.SimpleButton btnGonder;
        private System.Windows.Forms.Label label3;
    }
}