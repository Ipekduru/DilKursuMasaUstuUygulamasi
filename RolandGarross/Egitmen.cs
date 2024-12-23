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
    public partial class Egitmen : Form
    {

        public Egitmen()
        {
            InitializeComponent();
        }
        private void Egitmen_Load(object sender, EventArgs e)
        {
            LoadDillerToComboBox(); // ComboBox'u doldur
            LoadEgitmenlerToComboBox();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }

        private void btnEgitmenEkle_Click(object sender, EventArgs e)
        {
            labelEgitmenAra.Visible = false;
            labelEgitmenListele.Visible = false;
            dataGridView1.Visible = false;
            groupBoxEgitmenSil.Visible = false;
            txtEgitmenAra.Visible=false;

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

                        // Eğitmen ID'yi TextBox'a yaz ve kullanıcı tarafından değiştirilmesini engelle
                        txtKullaniciId.Text = nextId.ToString();
                        txtKullaniciId.ReadOnly = true;
                    }

                    // Eğitmen Türü TextBox'ına "egitmen" yaz ve kullanıcı tarafından değiştirilmesini engelle
                    txtKullaniciTur.Text = "egitmen";
                    txtKullaniciTur.ReadOnly = true;

                    // Grup Box'ı görünür yap
                    grpEgitmenEkle.Visible = true;
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj göster
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        private void LoadDillerToComboBox()
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";


            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Diller tablosundan dil_adi değerlerini al
                    string query = "SELECT dil_adi FROM public.diller";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, baglanti))
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // ComboBox'ı temizle
                        cmbDiller.Items.Clear();

                        // Verileri ComboBox'a ekle
                        while (reader.Read())
                        {
                            cmbDiller.Items.Add(reader.GetString(0));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Diller yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEgitmenKaydiOlustur_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string insertEgitmenQuery = @"
                INSERT INTO public.egitmen (ad, soy_ad, telefon, email, kullanici_turu, uzmanlik_alani, tecrube_yili)
                VALUES (@ad, @soy_ad, @telefon, @email, @kullanici_turu, @uzmanlik_alani, @tecrube_yili)";

                    using (NpgsqlCommand command = new NpgsqlCommand(insertEgitmenQuery, baglanti))
                    {
                        // Parametreleri PostgreSQL sorgusuna gönder
                        command.Parameters.AddWithValue("@ad", txtKullaniciAdi.Text);
                        command.Parameters.AddWithValue("@soy_ad", txtKullaniciSoyAdi.Text);
                        command.Parameters.AddWithValue("@telefon", txtKullaniciTelefon.Text);
                        command.Parameters.AddWithValue("@email", txtKullaniciEmail.Text);
                        command.Parameters.AddWithValue("@kullanici_turu", "egitmen");
                        command.Parameters.AddWithValue("@uzmanlik_alani", cmbDiller.SelectedItem.ToString()); // ComboBox'tan seçilen dil
                        command.Parameters.AddWithValue("@tecrube_yili", int.Parse(txtTecrubeYili.Text));

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Eğitmen başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ComboBox'u ve diğer alanları temizle
                    ClearGroupBoxInputs(grpEgitmenEkle);
                    grpEgitmenEkle.Visible = false;
                    LoadEgitmenlerToComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEgitmenSil_Click(object sender, EventArgs e)
        {
            txtEgitmenAra.Visible = false;
            labelEgitmenListele.Visible = false;
            labelEgitmenAra.Visible=false;
            dataGridView1.Visible = false;
            groupBoxEgitmenSil.Visible = true;
            grpEgitmenEkle.Visible = false;
        }
        private void LoadEgitmenlerToComboBox()
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Eğitmen listesini çekmek için sorgu
                    string query = "SELECT kullanici_id, ad, soy_ad FROM public.egitmen";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, baglanti))
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        cmbEgitmenSil.Items.Clear(); // ComboBox'ı temizle

                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string ad = reader.GetString(1);
                            string soyAd = reader.GetString(2);

                            // ComboBox'ta "ID - Ad Soyad" formatında göster
                            cmbEgitmenSil.Items.Add($"{id} - {ad} {soyAd}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eğitmen listesi yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEgitmenKaydiSil_Click(object sender, EventArgs e)
        {

            if (cmbEgitmenSil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek bir eğitmen seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen eğitmenin ID'sini al
            string selectedItem = cmbEgitmenSil.SelectedItem.ToString();
            int selectedId = int.Parse(selectedItem.Split('-')[0].Trim());

            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Eğitmeni silen SQL sorgusu
                    string deleteQuery = "SELECT delete_egitmen(@p_kullanici_id)";
                    using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, baglanti))
                    {
                        command.Parameters.AddWithValue("@p_kullanici_id", selectedId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Eğitmen başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ComboBox'u güncelle
                    LoadEgitmenlerToComboBox();
                    groupBoxEgitmenSil.Visible = false;
                    ClearGroupBoxInputs(groupBoxEgitmenSil);
                    LoadEgitmenlerToComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eğitmen silinirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEgitmenAra_Click(object sender, EventArgs e)
        {
            labelEgitmenAra.Visible = true;
            labelEgitmenListele.Visible = false;
            groupBoxEgitmenSil.Visible=false;
            grpEgitmenEkle.Visible=false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            // TextBox'u görünür yap
            txtEgitmenAra.Visible = true;

            dataGridView1.Visible = true;

            // Eğer TextBox hali hazırda doluysa, TextChanged olayını manuel tetikleyin
            if (!string.IsNullOrWhiteSpace(txtEgitmenAra.Text))
            {
                txtEgitmenAra_TextChanged(sender, e);
            }

        }

        private void txtEgitmenAra_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtEgitmenAra.Text.Trim();

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
                SELECT kullanici_id, ad, soy_ad, telefon, email, uzmanlik_alani, tecrube_yili
                FROM public.egitmen
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
                    MessageBox.Show($"Eğitmen arama yapılırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEgitmenleriListele_Click(object sender, EventArgs e)
        {
            grpEgitmenEkle.Enabled = false;
            groupBoxEgitmenSil.Visible = false;
            txtEgitmenAra.Visible = false;
            dataGridView1.Visible=true;
            labelEgitmenListele.Visible=true;
            labelEgitmenAra.Visible=false;
            // DataGridView'i temizle
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
    }
}
