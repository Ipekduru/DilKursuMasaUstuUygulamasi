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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }
        private void ClearGroupBoxInputs(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear(); // TextBox'u temizle
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1; // ComboBox'u temizle
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now; // DateTimePicker'i sıfırla
                }
            }
        }
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            grpOgrenciEkle.Visible = true;
            groupBoxOgrenciSil.Visible = false;
            dataGridView1.Visible = false;
            ogrenciGuncelleAra.Visible = false;
            btnOgrenciKaydiGuncelle.Visible = false;
            btnOgrenciSec.Visible = false;
            txtOgrenciAra.Visible = false;
           

            // Bağlantı bilgileri
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Son kullanici_id'yi bul
                    string getMaxIdQuery = "SELECT COALESCE(MAX(kullanici_id), 0) + 1 FROM kullanicilar";
                    using (NpgsqlCommand command = new NpgsqlCommand(getMaxIdQuery, baglanti))
                    {
                        int nextId = (int)command.ExecuteScalar();

                        // Öğrenci ID'yi TextBox'a yaz ve kullanıcı tarafından değiştirilmesini engelle
                        txtKullaniciId.Text = nextId.ToString();
                        txtKullaniciId.ReadOnly = true;
                    }

                    // Öğrenci Türü TextBox'ına "ogrenci" yaz ve kullanıcı tarafından değiştirilmesini engelle
                    txtKullaniciTur.Text = "ogrenci";
                    txtKullaniciTur.ReadOnly = true;

                    // Grup Box'ı görünür yap
                    grpOgrenciEkle.Visible = true;
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj göster
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnOgrenciKaydiOlustur_Click(object sender, EventArgs e)
        {
            // TextBox'ların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciSoyAdi.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciEmail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // PostgreSQL'deki INSERT sorgusu
                    string insertOgrenciQuery = @"
                    INSERT INTO public.ogrenci (ad, soy_ad, telefon, email, kullanici_turu, kayit_tarihi)
                    VALUES (@ad, @soy_ad, @telefon, @email, @kullanici_turu, @kayit_tarihi)";

                    using (NpgsqlCommand command = new NpgsqlCommand(insertOgrenciQuery, baglanti))
                    {
                        // Parametreleri PostgreSQL sorgusuna gönder
                        command.Parameters.AddWithValue("@ad", txtKullaniciAdi.Text);
                        command.Parameters.AddWithValue("@soy_ad", txtKullaniciSoyAdi.Text);
                        command.Parameters.AddWithValue("@telefon", txtKullaniciTelefon.Text);
                        command.Parameters.AddWithValue("@email", txtKullaniciEmail.Text);
                        command.Parameters.AddWithValue("@kullanici_turu", "ogrenci");

                        // Tarihi uygun formatta göndermek için DateTime nesnesi kullanılır
                        command.Parameters.AddWithValue("@kayit_tarihi", dTPKayitTarihi.Value.Date);

                        // Sorguyu çalıştır
                        command.ExecuteNonQuery();
                    }

                    // Başarı mesajı
                    MessageBox.Show("Öğrenci başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpOgrenciEkle.Visible = false;
                    ClearGroupBoxInputs(grpOgrenciEkle);
                    LoadOgrencilerToComboBox();

                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj göster
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadOgrencilerToComboBox()
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Öğrenci listesini çekmek için sorgu
                    string query = "SELECT kullanici_id, ad, soy_ad FROM public.ogrenci";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, baglanti))
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        cmbOgrenciSil.Items.Clear(); // ComboBox'ı temizle

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string ad = reader.GetString(1);
                            string soyAd = reader.GetString(2);

                            // ComboBox'ta "ID - Ad Soyad" formatında göster
                            cmbOgrenciSil.Items.Add($"{id} - {ad} {soyAd}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Öğrenci listesi yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            groupBoxOgrenciSil.Visible = true;
            grpOgrenciEkle.Visible = false;
            btnOgrenciSec.Visible = false;
            ogrenciGuncelleAra.Visible = false;
            btnOgrenciSec.Visible=false;
            dataGridView1.Visible = false;
            
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            LoadOgrencilerToComboBox();

        }
        private void btnOgrenciKaydiGuncelle_Click(object sender, EventArgs e)
        {
            // TextBox'ların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciSoyAdi.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciEmail.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // PostgreSQL'deki update_ogrenci fonksiyonunu çağıran sorgu
                    string updateQuery = @"
                        SELECT update_ogrenci(
                            @kullanici_id,
                            @ad,
                            @soy_ad,
                            @telefon,
                            @email,
                            @kayit_tarihi
                        )";

                    using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, baglanti))
                    {
                        // Parametreleri PostgreSQL sorgusuna gönder
                        command.Parameters.AddWithValue("@kullanici_id", int.Parse(txtKullaniciId.Text));
                        command.Parameters.AddWithValue("@ad", txtKullaniciAdi.Text);
                        command.Parameters.AddWithValue("@soy_ad", txtKullaniciSoyAdi.Text);
                        command.Parameters.AddWithValue("@telefon", txtKullaniciTelefon.Text);
                        command.Parameters.AddWithValue("@email", txtKullaniciEmail.Text);
                        command.Parameters.AddWithValue("@kayit_tarihi", dTPKayitTarihi.Value.Date.ToString("yyyy-MM-dd"));

                        // Sorguyu çalıştır
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Öğrenci kaydı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // DataGridView'i güncelle
                    LoadOgrencilerToComboBox();
                    btnOgrenciGüncelle_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Öğrenci kaydı güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciSil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek bir öğrenci seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen öğrencinin ID'sini al
            string selectedItem = cmbOgrenciSil.SelectedItem.ToString();
            int selectedId = int.Parse(selectedItem.Split('-')[0].Trim());

            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Öğrenciyi silen SQL sorgusu
                    string deleteQuery = "SELECT delete_ogrenci(@p_kullanici_id)";
                    using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, baglanti))
                    {
                        command.Parameters.AddWithValue("@p_kullanici_id", selectedId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Öğrenci başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ComboBox'u güncelle
                    LoadOgrencilerToComboBox();
                    groupBoxOgrenciSil.Visible = false;
                    ClearGroupBoxInputs(groupBoxOgrenciSil);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Öğrenci silinirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOgrenciGüncelle_Click(object sender, EventArgs e)
        {
            btnOgrenciKaydiGuncelle.Visible=true;
            ClearGroupBoxInputs(grpOgrenciEkle);
            ogrenciGuncelleAra.Text = "Güncellemek İstediğiniz Öğrenciyi Seçiniz ";
            ogrenciGuncelleAra.Visible = true;
            // DataGridView'i temizle
            dataGridView1.Visible = true;
            btnOgrenciSec.Visible = true;
            groupBoxOgrenciSil.Visible=false;
            grpOgrenciEkle.Visible = true;
            btnOgrenciKaydiOlustur.Visible = false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Öğrenci bilgilerini çekmek için sorgu
                    string sorgu = "SELECT kullanici_id, ad, soy_ad, telefon, email, kullanici_turu, kayit_tarihi FROM public.ogrenci";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    // DataGridView'e ata
                    dataGridView1.DataSource = ds.Tables[0];

                    MessageBox.Show("Öğrenci bilgileri başarıyla yüklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOgrencilerToComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Öğrenci bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOgrenciSec_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir öğrenci seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili satırı al
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // TextBox'lara değer aktar ve readonly yap
            txtKullaniciId.Text = selectedRow.Cells["kullanici_id"].Value.ToString();
            txtKullaniciId.ReadOnly = true;

            txtKullaniciAdi.Text = selectedRow.Cells["ad"].Value.ToString();
            txtKullaniciAdi.ReadOnly = true;

            txtKullaniciSoyAdi.Text = selectedRow.Cells["soy_ad"].Value.ToString();
            txtKullaniciSoyAdi.ReadOnly = true;

            txtKullaniciTelefon.Text = selectedRow.Cells["telefon"].Value.ToString();
            txtKullaniciTelefon.ReadOnly = false; // Telefon bilgisi düzenlenebilir

            txtKullaniciEmail.Text = selectedRow.Cells["email"].Value.ToString();
            txtKullaniciEmail.ReadOnly = false; // E-posta bilgisi düzenlenebilir

            txtKullaniciTur.Text = selectedRow.Cells["kullanici_turu"].Value.ToString();
            txtKullaniciTur.ReadOnly = true; // Tür değiştirilemez

            dTPKayitTarihi.Value = Convert.ToDateTime(selectedRow.Cells["kayit_tarihi"].Value);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtKullaniciAdi.Text = selectedRow.Cells["ad"].Value.ToString();
                txtKullaniciSoyAdi.Text = selectedRow.Cells["soy_ad"].Value.ToString();
                txtKullaniciTelefon.Text = selectedRow.Cells["telefon"].Value.ToString();
                txtKullaniciEmail.Text = selectedRow.Cells["email"].Value.ToString();
                txtKullaniciTur.Text = selectedRow.Cells["kullanici_turu"].Value.ToString();
                dTPKayitTarihi.Value = Convert.ToDateTime(selectedRow.Cells["kayit_tarihi"].Value);
            }
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)
        {
          
            string searchTerm = txtOgrenciAra.Text.Trim();

            // Eğer TextBox boşsa DataGridView'i temizle ve işlemi durdur
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                return;
            }

            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Arama sorgusu
                    string sorgu = @"
                SELECT kullanici_id, ad, soy_ad, telefon, email, kullanici_turu, kayit_tarihi
                FROM public.ogrenci
                WHERE ad ILIKE @searchTerm";

                    using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
                    {
                        // Parametre olarak arama terimi
                        command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        // Veriyi çek ve DataGridView'e ata
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Arama yapılırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnOgrenciAra_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            txtOgrenciAra.Visible = true;
            ogrenciGuncelleAra.Text = "Öğrenci Adını Giriniz";
            ogrenciGuncelleAra.Visible = true;
            groupBoxOgrenciSil.Visible = false;
            grpOgrenciEkle.Visible = false;
            dataGridView1.Visible=true;
            btnOgrenciSec.Visible = false;


        }

        private void btnOgrencileriListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            grpOgrenciEkle.Visible=false;
            groupBoxOgrenciSil.Visible=false;
            btnOgrenciSec.Visible=false;
            dataGridView1.Visible = true;
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Tüm öğrenci bilgilerini getiren sorgu
                    string sorgu = @"
                SELECT kullanici_id, ad, soy_ad, telefon, email, kullanici_turu, kayit_tarihi
                FROM public.ogrenci";

                    using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
                    {
                        // Veriyi çek ve DataGridView'e ata
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Öğrenciler listelenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
    
