namespace BilkentKafe
{
    partial class UrunlerForm
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
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblBirimFiyati = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.nudBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(0, 9);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblBirimFiyati
            // 
            this.lblBirimFiyati.AutoSize = true;
            this.lblBirimFiyati.Location = new System.Drawing.Point(106, 9);
            this.lblBirimFiyati.Name = "lblBirimFiyati";
            this.lblBirimFiyati.Size = new System.Drawing.Size(71, 13);
            this.lblBirimFiyati.TabIndex = 1;
            this.lblBirimFiyati.Text = "Birim Fiyatı (₺)";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(3, 51);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(581, 395);
            this.dgvUrunler.TabIndex = 2;
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nudBirimFiyat
            // 
            this.nudBirimFiyat.Location = new System.Drawing.Point(109, 25);
            this.nudBirimFiyat.Name = "nudBirimFiyat";
            this.nudBirimFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudBirimFiyat.TabIndex = 3;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(3, 25);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAd.TabIndex = 4;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(246, 25);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 5;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.nudBirimFiyat);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.lblBirimFiyati);
            this.Controls.Add(this.lblUrunAdi);
            this.Name = "UrunlerForm";
            this.Text = "UrunlerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirimFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblBirimFiyati;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.NumericUpDown nudBirimFiyat;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Button btnUrunEkle;
    }
}