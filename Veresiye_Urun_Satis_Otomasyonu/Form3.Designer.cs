namespace Veresiye_Urun_Satis_Otomasyonu
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiyatGuncelle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnDetay = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERADSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERMESLEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERBORCDURUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERTELEFONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLVERESIYEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veresiyeVeriTabani = new Veresiye_Urun_Satis_Otomasyonu.VeresiyeVeriTabaniDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.tBL_VERESIYETableAdapter = new Veresiye_Urun_Satis_Otomasyonu.VeresiyeVeriTabaniDataSetTableAdapters.TBL_VERESIYETableAdapter();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVERESIYEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeVeriTabani)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.mskTelefon);
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(71, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kaydet/Sil";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(160, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(41, 30);
            this.txtID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(71, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID:";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSil.Location = new System.Drawing.Point(116, 343);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 43);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnKaydet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnKaydet.Location = new System.Drawing.Point(116, 282);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 43);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(160, 161);
            this.mskTelefon.Mask = "0000000000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(108, 30);
            this.mskTelefon.TabIndex = 7;
            this.mskTelefon.ValidatingType = typeof(int);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(160, 218);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(168, 30);
            this.txtMeslek.TabIndex = 6;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(160, 110);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(168, 30);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(26, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Meslek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(24, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(6, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnFiyatGuncelle);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnDetay);
            this.groupBox2.Location = new System.Drawing.Point(623, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 392);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnFiyatGuncelle
            // 
            this.btnFiyatGuncelle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnFiyatGuncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatGuncelle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnFiyatGuncelle.Location = new System.Drawing.Point(117, 300);
            this.btnFiyatGuncelle.Name = "btnFiyatGuncelle";
            this.btnFiyatGuncelle.Size = new System.Drawing.Size(132, 68);
            this.btnFiyatGuncelle.TabIndex = 3;
            this.btnFiyatGuncelle.Text = "Fiyat Güncelle";
            this.btnFiyatGuncelle.UseVisualStyleBackColor = false;
            this.btnFiyatGuncelle.Click += new System.EventHandler(this.btnFiyatGuncelle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGuncelle.Location = new System.Drawing.Point(117, 178);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(132, 68);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnDetay
            // 
            this.btnDetay.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDetay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDetay.Location = new System.Drawing.Point(117, 51);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(132, 68);
            this.btnDetay.TabIndex = 0;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = false;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(0, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1078, 340);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Tablosu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pERIDDataGridViewTextBoxColumn,
            this.pERADSOYADDataGridViewTextBoxColumn,
            this.pERMESLEKDataGridViewTextBoxColumn,
            this.pERBORCDURUMDataGridViewTextBoxColumn,
            this.pERTELEFONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLVERESIYEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pERIDDataGridViewTextBoxColumn
            // 
            this.pERIDDataGridViewTextBoxColumn.DataPropertyName = "PERID";
            this.pERIDDataGridViewTextBoxColumn.HeaderText = "Personel Numarası";
            this.pERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERIDDataGridViewTextBoxColumn.Name = "pERIDDataGridViewTextBoxColumn";
            // 
            // pERADSOYADDataGridViewTextBoxColumn
            // 
            this.pERADSOYADDataGridViewTextBoxColumn.DataPropertyName = "PERADSOYAD";
            this.pERADSOYADDataGridViewTextBoxColumn.HeaderText = "Adı Soyadı";
            this.pERADSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERADSOYADDataGridViewTextBoxColumn.Name = "pERADSOYADDataGridViewTextBoxColumn";
            // 
            // pERMESLEKDataGridViewTextBoxColumn
            // 
            this.pERMESLEKDataGridViewTextBoxColumn.DataPropertyName = "PERMESLEK";
            this.pERMESLEKDataGridViewTextBoxColumn.HeaderText = "Mesleği";
            this.pERMESLEKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERMESLEKDataGridViewTextBoxColumn.Name = "pERMESLEKDataGridViewTextBoxColumn";
            // 
            // pERBORCDURUMDataGridViewTextBoxColumn
            // 
            this.pERBORCDURUMDataGridViewTextBoxColumn.DataPropertyName = "PERBORCDURUM";
            this.pERBORCDURUMDataGridViewTextBoxColumn.HeaderText = "Borcu";
            this.pERBORCDURUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERBORCDURUMDataGridViewTextBoxColumn.Name = "pERBORCDURUMDataGridViewTextBoxColumn";
            // 
            // pERTELEFONDataGridViewTextBoxColumn
            // 
            this.pERTELEFONDataGridViewTextBoxColumn.DataPropertyName = "PERTELEFON";
            this.pERTELEFONDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.pERTELEFONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERTELEFONDataGridViewTextBoxColumn.Name = "pERTELEFONDataGridViewTextBoxColumn";
            // 
            // tBLVERESIYEBindingSource
            // 
            this.tBLVERESIYEBindingSource.DataMember = "TBL_VERESIYE";
            this.tBLVERESIYEBindingSource.DataSource = this.veresiyeVeriTabani;
            // 
            // veresiyeVeriTabani
            // 
            this.veresiyeVeriTabani.DataSetName = "VeresiyeUrunSatisDataSet5";
            this.veresiyeVeriTabani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            this.label5.Visible = false;
            // 
            // tBL_VERESIYETableAdapter
            // 
            this.tBL_VERESIYETableAdapter.ClearBeforeFill = true;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.DeepPink;
            this.btnGeri.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(43, 43);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "<";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 680);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVERESIYEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeVeriTabani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFiyatGuncelle;
        private System.Windows.Forms.Label label5;
        private VeresiyeVeriTabaniDataSet veresiyeVeriTabani;
        private System.Windows.Forms.BindingSource tBLVERESIYEBindingSource;
        private VeresiyeVeriTabaniDataSetTableAdapters.TBL_VERESIYETableAdapter tBL_VERESIYETableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERADSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERMESLEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERBORCDURUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERTELEFONDataGridViewTextBoxColumn;
    }
}