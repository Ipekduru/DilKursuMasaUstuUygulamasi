using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolandGarross
{
    public partial class Kurlar : Form
    {
        public Kurlar()
        {
            InitializeComponent();

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }

        private void LoadEgitmenlerToDataGridView()
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            // Bağlantı dizesi
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Tüm eğitmen bilgilerini getiren sorgu
                    string sorgu = @"
            SELECT kullanici_id, ad, soy_ad, telefon, email, uzmanlik_alani, tecrube_yili
            FROM public.egitmen";

                    using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
                    {
                        // Veriyi çek ve DataGridView'e ata
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }

                    MessageBox.Show("Eğitmen bilgileri başarıyla listelendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eğitmen bilgileri listelenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan hücrenin satır indeksini kontrol et
            if (e.RowIndex >= 0)
            {
                // Seçili satırı al
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // "Eğitmen ID" sütunundaki değeri al ve TextBox'a yaz
                txtEgitmenId.Text = selectedRow.Cells["kullanici_id"].Value.ToString();

            }
            if (e.RowIndex >= 0)
            {
                // Seçilen satırı alın
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // "uzmanlik_alani" sütunundan veriyi al ve TextBox'a yazdır
                txtDil.Text = selectedRow.Cells["uzmanlik_alani"].Value.ToString();

                // TextBox'ı yalnızca görüntüleme için ayarlamak isterseniz
                txtDil.ReadOnly = true;
            }
        }
        private void Kurlar_Load(object sender, EventArgs e)
        {
            txtEgitmenId.ReadOnly = true;
            LoadSeviyeToComboBox();
            LoadNextKurId();
            txtKurId.ReadOnly = true;
            txtOgrenciId.ReadOnly = true;
        }
        private void LoadNextKurId()
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Son kur_id'yi bul
                    string query = "SELECT COALESCE(MAX(kur_id), 0) + 1 FROM public.kurlar";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, baglanti))
                    {
                        int nextKurId = (int)command.ExecuteScalar();
                        txtKurId.Text = nextKurId.ToString();
                        txtKurId.ReadOnly = true; // TextBox'ı sadece okunabilir yap
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kurs ID alınırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadSeviyeToComboBox()
        {
            // ComboBox'a seviyeleri manuel olarak ekleyin
            comboBoxSeviye.Items.Clear(); // Önce temizleyin
            comboBoxSeviye.Items.Add("Başlangıç");
            comboBoxSeviye.Items.Add("Orta");
            comboBoxSeviye.Items.Add("İleri");

            // Varsayılan olarak ilk öğeyi seçmek isterseniz
            if (comboBoxSeviye.Items.Count > 0)
            {
                comboBoxSeviye.SelectedIndex = 0;
            }
        }
        private void KurlarıGetir(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            dataGridView3.Visible = true;
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Kurs bilgilerini getiren sorgu
                    string sorgu = @"
                SELECT kur_id, kur_adi, egitmen_id, diller, seviye
                FROM public.kurlar";

                    using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
                    {
                        // Veriyi çek ve DataGridView'e ata
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView3.DataSource = ds.Tables[0];
                    }

                    MessageBox.Show("Kurs bilgileri başarıyla listelendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kurs bilgileri listelenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                txtKursId.Text = selectedRow.Cells["kur_id"].Value.ToString();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                txtOgrenciId.Text = selectedRow.Cells["kullanici_id"].Value.ToString();
            }
        }
        private void LoadOgrencilerToDataGridView()
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string query = "SELECT kullanici_id, ad, soy_ad, telefon, email FROM public.ogrenci";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, baglanti))
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView2.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Öğrenci bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEgitmenleriListele_Click(object sender, EventArgs e)
        {
            LoadEgitmenlerToDataGridView();
        }
        private void btnKursOluştur_Click_1(object sender, EventArgs e)
        {
            string kurAdi = txtKursAdi.Text.Trim();
            int kurId = int.Parse(txtKurId.Text.Trim());
            int egitmenId = int.Parse(txtEgitmenId.Text.Trim());
            string diller = txtDil.Text.Trim();
            string seviye = comboBoxSeviye.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(kurAdi) || string.IsNullOrWhiteSpace(diller) || string.IsNullOrWhiteSpace(seviye))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();


                    string insertKursQuery = @"
                    INSERT INTO public.kurlar (kur_id, kur_adi, egitmen_id, diller,seviye)
                    VALUES (@p_kur_id, @p_kur_adi, @p_egitmen_id,@p_diller,@p_seviye)";

                    using (NpgsqlCommand command = new NpgsqlCommand(insertKursQuery, baglanti))
                    {
                        command.Parameters.AddWithValue("@p_kur_adi", kurAdi);
                        command.Parameters.AddWithValue("@p_kur_id", kurId);
                        command.Parameters.AddWithValue("@p_egitmen_id", egitmenId);
                        command.Parameters.AddWithValue("@p_diller", diller);
                        command.Parameters.AddWithValue("@p_seviye", seviye);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kurs başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Alanları temizle
                    txtKurId.Clear();
                    txtKursAdi.Clear();
                    txtEgitmenId.Clear();
                    txtDil.Clear();
                    comboBoxSeviye.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kurs eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKurslariListele_Click(object sender, EventArgs e)
        {  dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
           
            groupBoxKursOlustur.Visible = true;
            dataGridView1.Visible = false;
            btnEgitmenleriListele.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtKurId.Visible = false;
            txtKursAdi.Visible = false;
            txtDil.Visible = false;
            txtEgitmenId.Visible = false;
            comboBoxSeviye.Visible = false;
            btnKursOluştur.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            txtOgrenciId.Visible = false;
            txtKursId.Visible = false;
            dateTimePicker1.Visible = false;
            txtTamamlanmaDurumu.Visible = false;
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            dataGridView3.Visible = true;
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Kurs bilgilerini getiren sorgu
                    string sorgu = @"
                SELECT kur_id, kur_adi, egitmen_id, diller, seviye
                FROM public.kurlar";

                    using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
                    {
                        // Veriyi çek ve DataGridView'e ata
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView3.DataSource = ds.Tables[0];
                    }

                    MessageBox.Show("Kurs bilgileri başarıyla listelendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kurs bilgileri listelenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxKursOlustur.Visible = true;
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            dataGridView1.Visible = false;
            btnEgitmenleriListele.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtKurId.Visible = false;
            txtKursAdi.Visible = false;
            txtDil.Visible = false;
            txtEgitmenId.Visible = false;
            comboBoxSeviye.Visible = false;
            btnKursOluştur.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            txtOgrenciId.Visible = true;
            txtKursId.Visible = true;
            dateTimePicker1.Visible = true;
            txtTamamlanmaDurumu.Visible = true;
            KurlarıGetir(sender, e);
            LoadOgrencilerToDataGridView();
        }

        private void btnOgrenciKurKaydiOlustur_Click(object sender, EventArgs e)
        {
            // TextBox'lardaki değerleri alın
            int kullaniciId = int.Parse(txtOgrenciId.Text.Trim());
            int kurId = int.Parse(txtKursId.Text.Trim());
            DateTime kayitTarihi = DateTime.Now; // Varsayılan olarak bugünkü tarih
            string tamamlanmaDurumu = "Kursa Kayıt Yapıldı"; // Varsayılan durum

            if (string.IsNullOrWhiteSpace(txtOgrenciId.Text) || string.IsNullOrWhiteSpace(txtKursId.Text))
            {
                MessageBox.Show("Lütfen hem öğrenci hem de kurs seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // kurogrenci tablosuna veri ekleme sorgusu
                    string insertQuery = @"
            INSERT INTO public.kurogrenci (kullanici_id, kur_id, kayit_tarihi, tamamlanma_durumu)
            VALUES (@p_kullanici_id, @p_kur_id, @p_kayit_tarihi, @p_tamamlanma_durumu)";

                    using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, baglanti))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@p_kullanici_id", kullaniciId);
                        command.Parameters.AddWithValue("@p_kur_id", kurId);
                        command.Parameters.AddWithValue("@p_kayit_tarihi", kayitTarihi);
                        command.Parameters.AddWithValue("@p_tamamlanma_durumu", tamamlanmaDurumu);

                        // Sorguyu çalıştır
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Öğrenci başarıyla kursa eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Alanları temizle
                    txtOgrenciId.Clear();
                    txtKursId.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Öğrenci kursa eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKurOlusturAna_Click(object sender, EventArgs e)
        {
            groupBoxKursOlustur.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView1.Visible = true;
            btnEgitmenleriListele.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtKurId.Visible = true;
            txtKursAdi.Visible = true;
            txtDil.Visible = true;
            txtEgitmenId.Visible = true;
            comboBoxSeviye.Visible = true;  
            btnKursOluştur.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            txtOgrenciId.Visible = false;
            txtKursId.Visible = false;
            dateTimePicker1.Visible = false;
            txtTamamlanmaDurumu.Visible = false;



        }
    }
}