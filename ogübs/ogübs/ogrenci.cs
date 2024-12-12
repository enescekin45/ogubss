using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ogübs
{
    public partial class ogrenci : Form
    {
        public ogrenci()
        {
            InitializeComponent();
        }

        bağlanti bgl = new bağlanti();

        private void ogrenci_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenci_bilgi_sistemiDataSet3.Dersss' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dersssTableAdapter.Fill(this.ogrenci_bilgi_sistemiDataSet3.Dersss);
            // TODO: Bu kod satırı 'ogrenci_bilgi_sistemiDataSet2.ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // TODO: Bu kod satırı 'ogrenci_bilgi_sistemiDataSet11.Derss' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // TODO: Bu kod satırı 'ogrenci_bilgi_sistemiDataSet1.Ders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            DersleriYukle();
            DersleriGoster();
        }

        private void DersleriYukle()
        {
            try
            {
                SqlCommand komut = new SqlCommand("SELECT DISTINCT Dersadı FROM Dersss", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    derssec.Items.Add(dr["Dersadı"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void DersleriGoster()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Dersss", bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(derssec.Text) && !string.IsNullOrEmpty(Text))
            {
                try
                {
                    int kredisi;
                    if (!int.TryParse(Text, out kredisi)) // Check if 'Gano' is a valid number (if needed)
                    {
                        MessageBox.Show("Kredi bilgisi geçerli bir sayı olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlConnection conn = bgl.baglanti()) // Use 'using' for automatic connection management
                    {
                        SqlCommand komut = new SqlCommand("INSERT INTO Dersss (Dersadı, DersKredi,DersKontajan,) VALUES (@p1, @p2,@p3)", conn);
                        komut.Parameters.AddWithValue("@p1", derssec.Text);
                        komut.Parameters.AddWithValue("@p2", kredisi);
                        // Pass Gano.Text, not Gano directly
                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Ders başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                    DersleriGoster();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen hem Ders Adı hem de Kredi bilgilerini doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}