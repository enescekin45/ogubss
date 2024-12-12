namespace ogübs
{
    partial class ogrenci
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
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.derssec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrenci_bilgi_sistemiDataSet = new ogübs.ogrenci_bilgi_sistemiDataSet();
            this.ogrencibilgisistemiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenci_bilgi_sistemiDataSet1 = new ogübs.ogrenci_bilgi_sistemiDataSet();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersTableAdapter = new ogübs.ogrenci_bilgi_sistemiDataSetTableAdapters.DersTableAdapter();
            this.ogrenci_bilgi_sistemiDataSet11 = new ogübs.ogrenci_bilgi_sistemiDataSet1();
            this.derssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.derssTableAdapter = new ogübs.ogrenci_bilgi_sistemiDataSet1TableAdapters.DerssTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kredi = new System.Windows.Forms.Label();
            this.ogrenci_bilgi_sistemiDataSet2 = new ogübs.ogrenci_bilgi_sistemiDataSet2();
            this.dersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dersTableAdapter1 = new ogübs.ogrenci_bilgi_sistemiDataSet2TableAdapters.dersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenci_bilgi_sistemiDataSet3 = new ogübs.ogrenci_bilgi_sistemiDataSet3();
            this.dersssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersssTableAdapter = new ogübs.ogrenci_bilgi_sistemiDataSet3TableAdapters.DersssTableAdapter();
            this.dersidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersKrediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersKontajanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencibilgisistemiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersssBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(735, 51);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 28;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(578, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Dersler";
            // 
            // derssec
            // 
            this.derssec.FormattingEnabled = true;
            this.derssec.Items.AddRange(new object[] {
            "internetporgramcılığı",
            "isletims sitemleri",
            "mobilprogrma",
            "mesleki inglizce",
            "c#",
            "gösel porgram"});
            this.derssec.Location = new System.Drawing.Point(510, 75);
            this.derssec.Name = "derssec";
            this.derssec.Size = new System.Drawing.Size(199, 24);
            this.derssec.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(327, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Aldığı dersler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(327, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "ÖĞRENCİ BİLGİLERİ";
            // 
            // ogrenci_bilgi_sistemiDataSet
            // 
            this.ogrenci_bilgi_sistemiDataSet.DataSetName = "ogrenci_bilgi_sistemiDataSet";
            this.ogrenci_bilgi_sistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencibilgisistemiDataSetBindingSource
            // 
            this.ogrencibilgisistemiDataSetBindingSource.DataSource = this.ogrenci_bilgi_sistemiDataSet;
            this.ogrencibilgisistemiDataSetBindingSource.Position = 0;
            // 
            // ogrenci_bilgi_sistemiDataSet1
            // 
            this.ogrenci_bilgi_sistemiDataSet1.DataSetName = "ogrenci_bilgi_sistemiDataSet";
            this.ogrenci_bilgi_sistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.ogrenci_bilgi_sistemiDataSet1;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenci_bilgi_sistemiDataSet11
            // 
            this.ogrenci_bilgi_sistemiDataSet11.DataSetName = "ogrenci_bilgi_sistemiDataSet1";
            this.ogrenci_bilgi_sistemiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // derssBindingSource
            // 
            this.derssBindingSource.DataMember = "Derss";
            this.derssBindingSource.DataSource = this.ogrenci_bilgi_sistemiDataSet11;
            // 
            // derssTableAdapter
            // 
            this.derssTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 32;
            // 
            // kredi
            // 
            this.kredi.AutoSize = true;
            this.kredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kredi.Location = new System.Drawing.Point(122, 77);
            this.kredi.Name = "kredi";
            this.kredi.Size = new System.Drawing.Size(60, 25);
            this.kredi.TabIndex = 31;
            this.kredi.Text = "kredi:";
            // 
            // ogrenci_bilgi_sistemiDataSet2
            // 
            this.ogrenci_bilgi_sistemiDataSet2.DataSetName = "ogrenci_bilgi_sistemiDataSet2";
            this.ogrenci_bilgi_sistemiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersBindingSource1
            // 
            this.dersBindingSource1.DataMember = "ders";
            this.dersBindingSource1.DataSource = this.ogrenci_bilgi_sistemiDataSet2;
            // 
            // dersTableAdapter1
            // 
            this.dersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersidDataGridViewTextBoxColumn,
            this.dersadıDataGridViewTextBoxColumn,
            this.dersKrediDataGridViewTextBoxColumn,
            this.dersKontajanDataGridViewTextBoxColumn,
            this.hocaIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dersssBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(114, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 150);
            this.dataGridView1.TabIndex = 33;
            // 
            // ogrenci_bilgi_sistemiDataSet3
            // 
            this.ogrenci_bilgi_sistemiDataSet3.DataSetName = "ogrenci_bilgi_sistemiDataSet3";
            this.ogrenci_bilgi_sistemiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersssBindingSource
            // 
            this.dersssBindingSource.DataMember = "Dersss";
            this.dersssBindingSource.DataSource = this.ogrenci_bilgi_sistemiDataSet3;
            // 
            // dersssTableAdapter
            // 
            this.dersssTableAdapter.ClearBeforeFill = true;
            // 
            // dersidDataGridViewTextBoxColumn
            // 
            this.dersidDataGridViewTextBoxColumn.DataPropertyName = "Dersid";
            this.dersidDataGridViewTextBoxColumn.HeaderText = "Dersid";
            this.dersidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersidDataGridViewTextBoxColumn.Name = "dersidDataGridViewTextBoxColumn";
            this.dersidDataGridViewTextBoxColumn.ReadOnly = true;
            this.dersidDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersadıDataGridViewTextBoxColumn
            // 
            this.dersadıDataGridViewTextBoxColumn.DataPropertyName = "Dersadı";
            this.dersadıDataGridViewTextBoxColumn.HeaderText = "Dersadı";
            this.dersadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersadıDataGridViewTextBoxColumn.Name = "dersadıDataGridViewTextBoxColumn";
            this.dersadıDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersKrediDataGridViewTextBoxColumn
            // 
            this.dersKrediDataGridViewTextBoxColumn.DataPropertyName = "DersKredi";
            this.dersKrediDataGridViewTextBoxColumn.HeaderText = "DersKredi";
            this.dersKrediDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersKrediDataGridViewTextBoxColumn.Name = "dersKrediDataGridViewTextBoxColumn";
            this.dersKrediDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersKontajanDataGridViewTextBoxColumn
            // 
            this.dersKontajanDataGridViewTextBoxColumn.DataPropertyName = "DersKontajan";
            this.dersKontajanDataGridViewTextBoxColumn.HeaderText = "DersKontajan";
            this.dersKontajanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersKontajanDataGridViewTextBoxColumn.Name = "dersKontajanDataGridViewTextBoxColumn";
            this.dersKontajanDataGridViewTextBoxColumn.Width = 125;
            // 
            // hocaIDDataGridViewTextBoxColumn
            // 
            this.hocaIDDataGridViewTextBoxColumn.DataPropertyName = "HocaID";
            this.hocaIDDataGridViewTextBoxColumn.HeaderText = "HocaID";
            this.hocaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hocaIDDataGridViewTextBoxColumn.Name = "hocaIDDataGridViewTextBoxColumn";
            this.hocaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kredi);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.derssec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "ogrenci";
            this.Text = "ogrenci";
            this.Load += new System.EventHandler(this.ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencibilgisistemiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_bilgi_sistemiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersssBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox derssec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ogrencibilgisistemiDataSetBindingSource;
        private ogrenci_bilgi_sistemiDataSet ogrenci_bilgi_sistemiDataSet;
        private ogrenci_bilgi_sistemiDataSet ogrenci_bilgi_sistemiDataSet1;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private ogrenci_bilgi_sistemiDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private ogrenci_bilgi_sistemiDataSet1 ogrenci_bilgi_sistemiDataSet11;
        private System.Windows.Forms.BindingSource derssBindingSource;
        private ogrenci_bilgi_sistemiDataSet1TableAdapters.DerssTableAdapter derssTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label kredi;
        private ogrenci_bilgi_sistemiDataSet2 ogrenci_bilgi_sistemiDataSet2;
        private System.Windows.Forms.BindingSource dersBindingSource1;
        private ogrenci_bilgi_sistemiDataSet2TableAdapters.dersTableAdapter dersTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ogrenci_bilgi_sistemiDataSet3 ogrenci_bilgi_sistemiDataSet3;
        private System.Windows.Forms.BindingSource dersssBindingSource;
        private ogrenci_bilgi_sistemiDataSet3TableAdapters.DersssTableAdapter dersssTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersKrediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersKontajanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocaIDDataGridViewTextBoxColumn;
    }
}