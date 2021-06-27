
namespace WFA_Market_Uygulaması
{
    partial class UrunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunForm));
            this.cboKategori = new System.Windows.Forms.ComboBox();
            this.nudStokAdet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnResimSil = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pboUrunResim = new System.Windows.Forms.PictureBox();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboUrunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // cboKategori
            // 
            this.cboKategori.DisplayMember = "KategoriAd";
            this.cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Location = new System.Drawing.Point(115, 82);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(148, 24);
            this.cboKategori.TabIndex = 24;
            this.cboKategori.ValueMember = "Id";
            // 
            // nudStokAdet
            // 
            this.nudStokAdet.Location = new System.Drawing.Point(115, 153);
            this.nudStokAdet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStokAdet.Name = "nudStokAdet";
            this.nudStokAdet.Size = new System.Drawing.Size(148, 22);
            this.nudStokAdet.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Stok Adedi";
            // 
            // nudBirimFiyat
            // 
            this.nudBirimFiyat.DecimalPlaces = 2;
            this.nudBirimFiyat.Location = new System.Drawing.Point(115, 121);
            this.nudBirimFiyat.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            131072});
            this.nudBirimFiyat.Name = "nudBirimFiyat";
            this.nudBirimFiyat.Size = new System.Drawing.Size(148, 22);
            this.nudBirimFiyat.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ürün Adı";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(115, 48);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(148, 22);
            this.txtUrunAd.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kategorisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Birim Fiyatı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(455, 12);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 84);
            this.btnKaydet.TabIndex = 30;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(455, 106);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(112, 75);
            this.btnIptal.TabIndex = 31;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 12);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(148, 22);
            this.txtId.TabIndex = 33;
            // 
            // btnResimSil
            // 
            this.btnResimSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResimSil.BackgroundImage")));
            this.btnResimSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResimSil.Location = new System.Drawing.Point(390, 151);
            this.btnResimSil.Name = "btnResimSil";
            this.btnResimSil.Size = new System.Drawing.Size(24, 24);
            this.btnResimSil.TabIndex = 35;
            this.btnResimSil.UseVisualStyleBackColor = true;
            this.btnResimSil.Click += new System.EventHandler(this.btnResimSil_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResimSec.BackgroundImage")));
            this.btnResimSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResimSec.Location = new System.Drawing.Point(420, 151);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(24, 24);
            this.btnResimSec.TabIndex = 29;
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pboUrunResim
            // 
            this.pboUrunResim.BackColor = System.Drawing.Color.Gainsboro;
            this.pboUrunResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboUrunResim.Location = new System.Drawing.Point(281, 12);
            this.pboUrunResim.Name = "pboUrunResim";
            this.pboUrunResim.Size = new System.Drawing.Size(167, 167);
            this.pboUrunResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboUrunResim.TabIndex = 34;
            this.pboUrunResim.TabStop = false;
            // 
            // ofdResim
            // 
            this.ofdResim.FileName = "openFileDialog1";
            this.ofdResim.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 210);
            this.Controls.Add(this.btnResimSil);
            this.Controls.Add(this.cboKategori);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pboUrunResim);
            this.Controls.Add(this.nudStokAdet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudBirimFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Name = "UrunForm";
            this.Text = "UrunForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudStokAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboUrunResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResimSil;
        private System.Windows.Forms.ComboBox cboKategori;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pboUrunResim;
        private System.Windows.Forms.NumericUpDown nudStokAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudBirimFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.OpenFileDialog ofdResim;
    }
}