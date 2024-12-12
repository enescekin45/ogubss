using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        private List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        private List<Ders> dersListesi = new List<Ders>();
        private int ogrenciIdCounter = 1;
        private int dersIdCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }
        public class sqlbağlantisi
        {
            private SqlConnection connection;

            public sqlbağlantisi()
            {
                string connectionString = "Server=your_server;Database=your_db;Integrated Security=true;";
                connection = new SqlConnection(connectionString);
            }

            public DataTable VerileriGetir(string query)
            {       
                try
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri getirilirken hata oluştu: " + ex.Message);
                    return null;
                }
            }
        }
        sqlbağlantisi bgl = new sqlbağlantisi();
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Dersler"; // Dersler tablosunu örnek aldım.
            DataTable derslerTable = bgl.VerileriGetir(query);

            if (derslerTable != null)
            {
                foreach (DataRow row in derslerTable.Rows)
                {
                    // Veritabanındaki dersleri listeye ekle
                    var ders = new Ders
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        DersAdi = row["DersAdi"].ToString(),
                        Kredisi = Convert.ToInt32(row["Kredisi"]),
                        Kontenjan = Convert.ToInt32(row["Kontenjan"]),
                        Hoca = row["Hoca"].ToString(),
                    };
                    dersListesi.Add(ders);
                }

                ListeleDersler();
            }

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            this.BtnDersGuncelle.Click += new System.EventHandler(this.BtnOgrenciGuncelle_Click);
            this.btnOgrenciSil.Click += new System.EventHandler(this.BtnOgrenciSil_Click);
            // Burada tabPage2 tıklandığında yapılacak işlemleri yazabilirsiniz.
        }
        private void dataGridViewDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDersler.Rows[e.RowIndex];
                txtDersAdi.Text = row.Cells["DersAdi"].Value.ToString();
                txtDersKredisi.Text = row.Cells["Kredisi"].Value.ToString();
                txtDersKontenjan.Text = row.Cells["Kontenjan"].Value.ToString();
                txtDersHoca.Text = row.Cells["Hoca"].Value.ToString();
            }
        }


        // Ders İşlemleri
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var yeniDers = new Ders
                {
                    DersAdi = txtDersAdi.Text.Trim(),
                    Kredisi = int.Parse(txtDersKredisi.Text.Trim()),
                    Kontenjan = int.Parse(txtDersKontenjan.Text.Trim()),
                    Hoca = txtDersHoca.Text.Trim()
                };

                dersListesi.Add(yeniDers);
                ListeleDersler();
                TemizleDersFormu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void BtnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDersler.SelectedRows.Count > 0)
                {
                    int id = (int)dataGridViewDersler.SelectedRows[0].Cells[0].Value;
                    var ders = dersListesi.FirstOrDefault(d => d.Id == id);

                    if (ders != null)
                    {
                        ders.DersAdi = txtDersAdi.Text.Trim();
                        ders.Kredisi = int.Parse(txtDersKredisi.Text.Trim());
                        ders.Kontenjan = int.Parse(txtDersKontenjan.Text.Trim());
                        ders.Hoca = txtDersHoca.Text.Trim();
                        ListeleDersler();
                        TemizleDersFormu();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void BtnOgrenciSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDersler.SelectedRows.Count > 0)
                {
                    int id = (int)dataGridViewDersler.SelectedRows[0].Cells[0].Value;
                    var ders = dersListesi.FirstOrDefault(d => d.Id == id);
                    if (ders != null)
                    {
                        dersListesi.Remove(ders);
                        ListeleDersler();
                        TemizleDersFormu();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void ListeleDersler()
        {
            dataGridViewDersler.DataSource = null;
            dataGridViewDersler.DataSource = dersListesi.Select(d => new
            {
                d.Id,
                d.DersAdi,
                d.Kredisi,
                d.Kontenjan,
                d.Hoca
            }).ToList();
        }

        private void TemizleDersFormu()
        {
            txtDersAdi.Text = "";
            txtDersKredisi.Text = "";
            txtDersKontenjan.Text = "";
            txtDersHoca.Text = "";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciIsleriDataSet2.Ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersTableAdapter.Fill(this.ogrenciIsleriDataSet2.Ders);
            // TODO: Bu kod satırı 'ogrenciIsleriDataSet1.Ogrenciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencilerTableAdapter.Fill(this.ogrenciIsleriDataSet1.Ogrenciler);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }


    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bolum { get; set; }
    }

    public class Ders
    {
        public int Id { get; set; }
        public string DersAdi { get; set; }
        public int Kredisi { get; set; }
        public int Kontenjan { get; set; }
        public string Hoca { get; set; }
        public List<Ogrenci> DersAlanOgrenciler { get; set; }
    }
}
