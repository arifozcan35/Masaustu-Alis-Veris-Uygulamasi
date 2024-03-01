namespace Veresiye_Urun_Satis_Otomasyonu
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnFiyatGuncelle = new System.Windows.Forms.Button();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.tBLVERESİYEFİYATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VeresiyeVeriTabaniDataSet = new Veresiye_Urun_Satis_Otomasyonu.VeresiyeVeriTabaniDataSet();
            this.txtYeniFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBL_VERESİYE_FİYATTableAdapter = new Veresiye_Urun_Satis_Otomasyonu.VeresiyeVeriTabaniDataSetTableAdapters.TBL_VERESİYE_FİYATTableAdapter();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVERESİYEFİYATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeresiyeVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiyatGuncelle
            // 
            this.btnFiyatGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnFiyatGuncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatGuncelle.ForeColor = System.Drawing.Color.Orange;
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(151, 198);
            this.btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(106, 43);
            this.btnFiyatGuncelle.TabIndex = 36;
            this.btnFiyatGuncelle.Text = "Güncelle";
            this.btnFiyatGuncelle.UseVisualStyleBackColor = false;
            this.btnFiyatGuncelle.Click += new System.EventHandler(this.btnFiyatGuncelle_Click);
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.DataSource = this.tBLVERESİYEFİYATBindingSource;
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(48, 112);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 30);
            this.cmbUrunler.TabIndex = 37;
            // 
            // tBLVERESİYEFİYATBindingSource
            // 
            this.tBLVERESİYEFİYATBindingSource.DataMember = "TBL_VERESİYE_FİYAT";
            this.tBLVERESİYEFİYATBindingSource.DataSource = this.VeresiyeVeriTabaniDataSet;
            // 
            // VeresiyeVeriTabaniDataSet
            // 
            this.VeresiyeVeriTabaniDataSet.DataSetName = "VeresiyeUrunSatisDataSet";
            this.VeresiyeVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtYeniFiyat
            // 
            this.txtYeniFiyat.Location = new System.Drawing.Point(252, 112);
            this.txtYeniFiyat.Name = "txtYeniFiyat";
            this.txtYeniFiyat.Size = new System.Drawing.Size(100, 30);
            this.txtYeniFiyat.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(70, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(248, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Yeni Fiyat";
            // 
            // tBL_VERESİYE_FİYATTableAdapter
            // 
            this.tBL_VERESİYE_FİYATTableAdapter.ClearBeforeFill = true;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.DeepPink;
            this.btnGeri.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(43, 43);
            this.btnGeri.TabIndex = 41;
            this.btnGeri.Text = "<";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 320);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYeniFiyat);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.btnFiyatGuncelle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLVERESİYEFİYATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeresiyeVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFiyatGuncelle;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.TextBox txtYeniFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private VeresiyeVeriTabaniDataSet VeresiyeVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tBLVERESİYEFİYATBindingSource;
        private VeresiyeVeriTabaniDataSetTableAdapters.TBL_VERESİYE_FİYATTableAdapter tBL_VERESİYE_FİYATTableAdapter;
        private System.Windows.Forms.Button btnGeri;
    }
}