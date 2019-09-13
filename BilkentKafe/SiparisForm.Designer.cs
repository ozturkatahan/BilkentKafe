namespace BilkentKafe
{
    partial class SiparisForm
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
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUrunler = new System.Windows.Forms.ComboBox();
            this.nudUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisDetayEkle = new System.Windows.Forms.Button();
            this.lbltxtOdemeTutari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.AllowUserToAddRows = false;
            this.dgvSiparisDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(12, 57);
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.ReadOnly = true;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(605, 396);
            this.dgvSiparisDetaylar.TabIndex = 0;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMasaNo.BackColor = System.Drawing.Color.Orange;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 62F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMasaNo.Location = new System.Drawing.Point(625, 57);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMasaNo.Size = new System.Drawing.Size(228, 233);
            this.lblMasaNo.TabIndex = 1;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMasaNo.UseCompatibleTextRendering = true;
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.Location = new System.Drawing.Point(738, 305);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(53, 20);
            this.lblOdemeTutari.TabIndex = 2;
            this.lblOdemeTutari.Text = "0,00 ₺";
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSiparisIptal.BackColor = System.Drawing.Color.LightCoral;
            this.btnSiparisIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisIptal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiparisIptal.Location = new System.Drawing.Point(624, 340);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(108, 49);
            this.btnSiparisIptal.TabIndex = 3;
            this.btnSiparisIptal.Text = "TÜM SİPARİŞİ İPTAL ET";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOdemeAl.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdemeAl.Location = new System.Drawing.Point(741, 340);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(112, 49);
            this.btnOdemeAl.TabIndex = 4;
            this.btnOdemeAl.Text = "ÖDEME ALINDI HESABI KAPAT";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnaSayfa.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAnaSayfa.Location = new System.Drawing.Point(624, 395);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(229, 58);
            this.btnAnaSayfa.TabIndex = 5;
            this.btnAnaSayfa.Text = "ANA SAYFAYA DÖN";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adet:";
            // 
            // cboUrunler
            // 
            this.cboUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrunler.FormattingEnabled = true;
            this.cboUrunler.Location = new System.Drawing.Point(12, 30);
            this.cboUrunler.Name = "cboUrunler";
            this.cboUrunler.Size = new System.Drawing.Size(125, 21);
            this.cboUrunler.TabIndex = 8;
            // 
            // nudUrunAdet
            // 
            this.nudUrunAdet.Location = new System.Drawing.Point(153, 30);
            this.nudUrunAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUrunAdet.Name = "nudUrunAdet";
            this.nudUrunAdet.Size = new System.Drawing.Size(78, 20);
            this.nudUrunAdet.TabIndex = 9;
            this.nudUrunAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisDetayEkle
            // 
            this.btnSiparisDetayEkle.Location = new System.Drawing.Point(254, 28);
            this.btnSiparisDetayEkle.Name = "btnSiparisDetayEkle";
            this.btnSiparisDetayEkle.Size = new System.Drawing.Size(71, 23);
            this.btnSiparisDetayEkle.TabIndex = 10;
            this.btnSiparisDetayEkle.Text = "EKLE";
            this.btnSiparisDetayEkle.UseVisualStyleBackColor = true;
            this.btnSiparisDetayEkle.Click += new System.EventHandler(this.btnSiparisDetayEkle_Click);
            // 
            // lbltxtOdemeTutari
            // 
            this.lbltxtOdemeTutari.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltxtOdemeTutari.AutoSize = true;
            this.lbltxtOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltxtOdemeTutari.Location = new System.Drawing.Point(623, 305);
            this.lbltxtOdemeTutari.Name = "lbltxtOdemeTutari";
            this.lbltxtOdemeTutari.Size = new System.Drawing.Size(109, 20);
            this.lbltxtOdemeTutari.TabIndex = 11;
            this.lbltxtOdemeTutari.Text = "Ödeme Tutarı:";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.lbltxtOdemeTutari);
            this.Controls.Add(this.btnSiparisDetayEkle);
            this.Controls.Add(this.nudUrunAdet);
            this.Controls.Add(this.cboUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUrunler;
        private System.Windows.Forms.NumericUpDown nudUrunAdet;
        private System.Windows.Forms.Button btnSiparisDetayEkle;
        private System.Windows.Forms.Label lbltxtOdemeTutari;
    }
}