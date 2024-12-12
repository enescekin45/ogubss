namespace WindowsFormsApp12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciIsleriDataSet1 = new WindowsFormsApp12.OgrenciIsleriDataSet1();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciIsleriDataSet2 = new WindowsFormsApp12.OgrenciIsleriDataSet2();
            this.ogrencilerTableAdapter = new WindowsFormsApp12.OgrenciIsleriDataSet1TableAdapters.OgrencilerTableAdapter();
            this.dersTableAdapter = new WindowsFormsApp12.OgrenciIsleriDataSet2TableAdapters.DersTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.BtnDersGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewDersler = new System.Windows.Forms.DataGridView();
            this.hocaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontenjanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kredisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtDersKredisi = new System.Windows.Forms.TextBox();
            this.txtDersKontenjan = new System.Windows.Forms.TextBox();
            this.txtDersHoca = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.dataGridViewOgrenciler = new System.Windows.Forms.DataGridView();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOgrenciBolum = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIsleriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIsleriDataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "Ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.ogrenciIsleriDataSet1;
            // 
            // ogrenciIsleriDataSet1
            // 
            this.ogrenciIsleriDataSet1.DataSetName = "OgrenciIsleriDataSet1";
            this.ogrenciIsleriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.ogrenciIsleriDataSet2;
            // 
            // ogrenciIsleriDataSet2
            // 
            this.ogrenciIsleriDataSet2.DataSetName = "OgrenciIsleriDataSet2";
            this.ogrenciIsleriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.txtDersHoca);
            this.tabPage2.Controls.Add(this.txtDersKontenjan);
            this.tabPage2.Controls.Add(this.txtDersKredisi);
            this.tabPage2.Controls.Add(this.txtDersAdi);
            this.tabPage2.Controls.Add(this.dataGridViewDersler);
            this.tabPage2.Controls.Add(this.BtnDersGuncelle);
            this.tabPage2.Controls.Add(this.btnDersSil);
            this.tabPage2.Controls.Add(this.btnDersEkle);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ders İşlemleri";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.Cyan;
            this.btnDersEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.Location = new System.Drawing.Point(200, 20);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(100, 30);
            this.btnDersEkle.TabIndex = 2;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            // 
            // btnDersSil
            // 
            this.btnDersSil.BackColor = System.Drawing.Color.Red;
            this.btnDersSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersSil.Location = new System.Drawing.Point(200, 60);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(100, 30);
            this.btnDersSil.TabIndex = 3;
            this.btnDersSil.Text = "Sil";
            this.btnDersSil.UseVisualStyleBackColor = false;
            // 
            // BtnDersGuncelle
            // 
            this.BtnDersGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.BtnDersGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDersGuncelle.Location = new System.Drawing.Point(200, 107);
            this.BtnDersGuncelle.Name = "BtnDersGuncelle";
            this.BtnDersGuncelle.Size = new System.Drawing.Size(100, 30);
            this.BtnDersGuncelle.TabIndex = 5;
            this.BtnDersGuncelle.Text = "Güncelle";
            this.BtnDersGuncelle.UseVisualStyleBackColor = false;
            this.BtnDersGuncelle.Click += new System.EventHandler(this.BtnOgrenciGuncelle_Click);
            // 
            // dataGridViewDersler
            // 
            this.dataGridViewDersler.AutoGenerateColumns = false;
            this.dataGridViewDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn1,
            this.dersAdiDataGridViewTextBoxColumn,
            this.kredisiDataGridViewTextBoxColumn,
            this.kontenjanDataGridViewTextBoxColumn,
            this.hocaDataGridViewTextBoxColumn});
            this.dataGridViewDersler.DataSource = this.dersBindingSource;
            this.dataGridViewDersler.Location = new System.Drawing.Point(15, 210);
            this.dataGridViewDersler.Name = "dataGridViewDersler";
            this.dataGridViewDersler.RowHeadersWidth = 51;
            this.dataGridViewDersler.RowTemplate.Height = 24;
            this.dataGridViewDersler.Size = new System.Drawing.Size(285, 200);
            this.dataGridViewDersler.TabIndex = 4;
            // 
            // hocaDataGridViewTextBoxColumn
            // 
            this.hocaDataGridViewTextBoxColumn.DataPropertyName = "Hoca";
            this.hocaDataGridViewTextBoxColumn.HeaderText = "Hoca";
            this.hocaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hocaDataGridViewTextBoxColumn.Name = "hocaDataGridViewTextBoxColumn";
            this.hocaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kontenjanDataGridViewTextBoxColumn
            // 
            this.kontenjanDataGridViewTextBoxColumn.DataPropertyName = "Kontenjan";
            this.kontenjanDataGridViewTextBoxColumn.HeaderText = "Kontenjan";
            this.kontenjanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kontenjanDataGridViewTextBoxColumn.Name = "kontenjanDataGridViewTextBoxColumn";
            this.kontenjanDataGridViewTextBoxColumn.Width = 125;
            // 
            // kredisiDataGridViewTextBoxColumn
            // 
            this.kredisiDataGridViewTextBoxColumn.DataPropertyName = "Kredisi";
            this.kredisiDataGridViewTextBoxColumn.HeaderText = "Kredisi";
            this.kredisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kredisiDataGridViewTextBoxColumn.Name = "kredisiDataGridViewTextBoxColumn";
            this.kredisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersAdiDataGridViewTextBoxColumn
            // 
            this.dersAdiDataGridViewTextBoxColumn.DataPropertyName = "DersAdi";
            this.dersAdiDataGridViewTextBoxColumn.HeaderText = "DersAdi";
            this.dersAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersAdiDataGridViewTextBoxColumn.Name = "dersAdiDataGridViewTextBoxColumn";
            this.dersAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıdDataGridViewTextBoxColumn1
            // 
            this.ıdDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn1.Name = "ıdDataGridViewTextBoxColumn1";
            this.ıdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersAdi.Location = new System.Drawing.Point(15, 20);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(150, 24);
            this.txtDersAdi.TabIndex = 0;
            this.txtDersAdi.Text = "Ders Adı";
            // 
            // txtDersKredisi
            // 
            this.txtDersKredisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersKredisi.Location = new System.Drawing.Point(15, 60);
            this.txtDersKredisi.Name = "txtDersKredisi";
            this.txtDersKredisi.Size = new System.Drawing.Size(150, 24);
            this.txtDersKredisi.TabIndex = 1;
            this.txtDersKredisi.Text = "Ders Kredisi";
            // 
            // txtDersKontenjan
            // 
            this.txtDersKontenjan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersKontenjan.Location = new System.Drawing.Point(15, 107);
            this.txtDersKontenjan.Name = "txtDersKontenjan";
            this.txtDersKontenjan.Size = new System.Drawing.Size(150, 24);
            this.txtDersKontenjan.TabIndex = 6;
            this.txtDersKontenjan.Text = "Kontenjan";
            // 
            // txtDersHoca
            // 
            this.txtDersHoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDersHoca.Location = new System.Drawing.Point(15, 151);
            this.txtDersHoca.Name = "txtDersHoca";
            this.txtDersHoca.Size = new System.Drawing.Size(150, 24);
            this.txtDersHoca.TabIndex = 7;
            this.txtDersHoca.Text = "Hoca Ad:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.txtOgrenciAd);
            this.tabPage1.Controls.Add(this.txtOgrenciSoyad);
            this.tabPage1.Controls.Add(this.txtOgrenciBolum);
            this.tabPage1.Controls.Add(this.dataGridViewOgrenciler);
            this.tabPage1.Controls.Add(this.btnOgrenciSil);
            this.tabPage1.Controls.Add(this.btnOgrenciEkle);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci İşlemleri";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciEkle.Location = new System.Drawing.Point(200, 20);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(100, 30);
            this.btnOgrenciEkle.TabIndex = 3;
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.BackColor = System.Drawing.Color.Red;
            this.btnOgrenciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciSil.Location = new System.Drawing.Point(200, 60);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(100, 30);
            this.btnOgrenciSil.TabIndex = 4;
            this.btnOgrenciSil.Text = "Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = false;
            this.btnOgrenciSil.Click += new System.EventHandler(this.BtnOgrenciSil_Click);
            // 
            // dataGridViewOgrenciler
            // 
            this.dataGridViewOgrenciler.AutoGenerateColumns = false;
            this.dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn});
            this.dataGridViewOgrenciler.DataSource = this.ogrencilerBindingSource;
            this.dataGridViewOgrenciler.Location = new System.Drawing.Point(0, 195);
            this.dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            this.dataGridViewOgrenciler.RowHeadersWidth = 51;
            this.dataGridViewOgrenciler.RowTemplate.Height = 24;
            this.dataGridViewOgrenciler.Size = new System.Drawing.Size(524, 221);
            this.dataGridViewOgrenciler.TabIndex = 6;
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "Bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bolum";
            this.bolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            this.bolumDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 125;
            // 
            // txtOgrenciBolum
            // 
            this.txtOgrenciBolum.Location = new System.Drawing.Point(15, 100);
            this.txtOgrenciBolum.Name = "txtOgrenciBolum";
            this.txtOgrenciBolum.Size = new System.Drawing.Size(150, 22);
            this.txtOgrenciBolum.TabIndex = 2;
            this.txtOgrenciBolum.Text = "Bölüm";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(15, 60);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(150, 22);
            this.txtOgrenciSoyad.TabIndex = 1;
            this.txtOgrenciSoyad.Text = "Soyad";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(15, 20);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(150, 22);
            this.txtOgrenciAd.TabIndex = 0;
            this.txtOgrenciAd.Text = "Ad";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 445);
            this.tabControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1230, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Öğrenci ve Ders İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIsleriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciIsleriDataSet2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private OgrenciIsleriDataSet1 ogrenciIsleriDataSet1;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private OgrenciIsleriDataSet1TableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
        private OgrenciIsleriDataSet2 ogrenciIsleriDataSet2;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private OgrenciIsleriDataSet2TableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDersHoca;
        private System.Windows.Forms.TextBox txtDersKontenjan;
        private System.Windows.Forms.TextBox txtDersKredisi;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kredisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontenjanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnDersGuncelle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtOgrenciBolum;
        private System.Windows.Forms.DataGridView dataGridViewOgrenciler;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
