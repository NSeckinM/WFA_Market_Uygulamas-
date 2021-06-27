
namespace WFA_Market_Uygulaması
{
    partial class AnaForm
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
            if (disposing)
            {
                con.Close();
            }
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
            this.tviKategoriler = new System.Windows.Forms.TreeView();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunDuzenle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnKategoriDuzenle = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // tviKategoriler
            // 
            this.tviKategoriler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tviKategoriler.Location = new System.Drawing.Point(14, 49);
            this.tviKategoriler.Name = "tviKategoriler";
            this.tviKategoriler.Size = new System.Drawing.Size(254, 472);
            this.tviKategoriler.TabIndex = 0;
            this.tviKategoriler.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tviKategoriler_AfterSelect);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvUrunler.Location = new System.Drawing.Point(310, 49);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 85;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(639, 471);
            this.dgvUrunler.TabIndex = 1;
            this.dgvUrunler.SelectionChanged += new System.EventHandler(this.dgvUrunler_SelectionChanged);
            this.dgvUrunler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUrunler_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UrunAd";
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BirimFiyat";
            this.Column3.HeaderText = "Birim Fiyatı (₺)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StokAdet";
            this.Column4.HeaderText = "Stok Adedi";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Resim";
            this.Column5.HeaderText = "Ürün Görseli";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategoriler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(310, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürünler";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(272, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 586);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUrunSil.BackColor = System.Drawing.Color.White;
            this.btnUrunSil.BackgroundImage = global::WFA_Market_Uygulaması.Properties.Resources.trash__2_;
            this.btnUrunSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunSil.Location = new System.Drawing.Point(441, 526);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(61, 52);
            this.btnUrunSil.TabIndex = 3;
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUrunDuzenle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUrunDuzenle.BackgroundImage = global::WFA_Market_Uygulaması.Properties.Resources._74c972e6_d86c_47ba_8785_24eb7c0399df;
            this.btnUrunDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunDuzenle.Location = new System.Drawing.Point(373, 526);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(61, 52);
            this.btnUrunDuzenle.TabIndex = 3;
            this.btnUrunDuzenle.UseVisualStyleBackColor = false;
            this.btnUrunDuzenle.Click += new System.EventHandler(this.btnUrunDuzenle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKategoriSil.BackColor = System.Drawing.Color.White;
            this.btnKategoriSil.BackgroundImage = global::WFA_Market_Uygulaması.Properties.Resources.trash__2_;
            this.btnKategoriSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKategoriSil.Location = new System.Drawing.Point(145, 526);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(61, 52);
            this.btnKategoriSil.TabIndex = 3;
            this.btnKategoriSil.TabStop = false;
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUrunEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUrunEkle.BackgroundImage = global::WFA_Market_Uygulaması.Properties.Resources.add_button;
            this.btnUrunEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunEkle.Location = new System.Drawing.Point(310, 526);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(56, 52);
            this.btnUrunEkle.TabIndex = 3;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnKategoriDuzenle
            // 
            this.btnKategoriDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKategoriDuzenle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKategoriDuzenle.BackgroundImage = global::WFA_Market_Uygulaması.Properties.Resources._74c972e6_d86c_47ba_8785_24eb7c0399df;
            this.btnKategoriDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKategoriDuzenle.Location = new System.Drawing.Point(77, 526);
            this.btnKategoriDuzenle.Name = "btnKategoriDuzenle";
            this.btnKategoriDuzenle.Size = new System.Drawing.Size(61, 52);
            this.btnKategoriDuzenle.TabIndex = 3;
            this.btnKategoriDuzenle.UseVisualStyleBackColor = false;
            this.btnKategoriDuzenle.Click += new System.EventHandler(this.btnKategoriDuzenle_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKategoriEkle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKategoriEkle.BackgroundImage = global::WFA_Market_Uygulaması.Properties.Resources.add_button;
            this.btnKategoriEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKategoriEkle.Location = new System.Drawing.Point(14, 526);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(56, 52);
            this.btnKategoriEkle.TabIndex = 3;
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunDuzenle);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnKategoriDuzenle);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.tviKategoriler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tviKategoriler;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKategoriDuzenle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunDuzenle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
    }
}

