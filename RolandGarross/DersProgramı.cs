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
    public partial class DersProgramı : Form
    {
        public DersProgramı()
        {
            InitializeComponent();
        }
        private void LoadKurslariToDataGridView()
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Kurs bilgilerini getiren sorgu
                    string query = "SELECT kur_id, kur_adi, egitmen_id, diller, seviye FROM public.kurlar";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, baglanti))
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }

                    MessageBox.Show("Kurslar başarıyla listelendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kurslar listelenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridViewKurslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Seçilen satırı al
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // kur_id'yi TextBox'a yaz
                txtKurId.Text = selectedRow.Cells["kur_id"].Value.ToString();
            }
        }
        private void LoadNextProgramId()
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Son program_id'yi bul ve bir fazlasını al
                    string query = "SELECT COALESCE(MAX(program_id), 0) + 1 FROM public.program";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, baglanti))
                    {
                        int nextProgramId = (int)command.ExecuteScalar();

                        // Program ID'yi TextBox'a yaz ve sadece okunabilir yap
                        txtProgramId.Text = nextProgramId.ToString();
                        txtProgramId.ReadOnly = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Program ID alınırken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            grpProgramOlustur.Visible = true;
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            btnOgrenciyiProgramaDahilEt.Visible = false;
            LoadKurslariToDataGridView();
            LoadNextProgramId();


        }

        private int selectedProgramId;
        private int selectedOgrenciId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedProgramId = Convert.ToInt32(row.Cells["program_id"].Value);
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                selectedOgrenciId = Convert.ToInt32(row.Cells["kullanici_id"].Value);
            }
        }

        private void btnProgramKaydiOlustur_Click(object sender, EventArgs e)
        { // Gerekli bilgileri al
            int programId = int.Parse(txtProgramId.Text.Trim());
            int kurId = int.Parse(txtKurId.Text.Trim());
            DateTime gun = dateTimePicker1.Value; // Gün DateTimePicker'dan alınır
            string saatAraligi = txtSaatAraligi.Text.Trim();

            // Eksik bilgi kontrolü
            if (string.IsNullOrWhiteSpace(saatAraligi))
            {
                MessageBox.Show("Lütfen saat aralığını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // Program bilgilerini eklemek için sorgu
                    string query = @"
                INSERT INTO public.program (program_id, kur_id, gun, saat_araligi)
                VALUES (@p_program_id, @p_kur_id, @p_gun, @p_saat_araligi)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, baglanti))
                    {
                        // Parametreleri sorguya ekle
                        command.Parameters.AddWithValue("@p_program_id", programId);
                        command.Parameters.AddWithValue("@p_kur_id", kurId);
                        command.Parameters.AddWithValue("@p_gun", gun); // DateTime nesnesi doğrudan sorguya eklenir
                        command.Parameters.AddWithValue("@p_saat_araligi", saatAraligi);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Program başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Alanları temizle ve yeni program ID'yi yükle
                    txtSaatAraligi.Clear();
                    LoadNextProgramId();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Program kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOgrenciyiProgramaDahilEt_Click(object sender, EventArgs e)
        {
            // Seçilen program ve öğrenci ID'lerini kontrol et
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir program ve bir öğrenci seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Program ID'yi al
                DataGridViewRow selectedProgramRow = dataGridView1.SelectedRows[0];
                int programId = Convert.ToInt32(selectedProgramRow.Cells["program_id"].Value);

                // Öğrenci ID'yi al
                DataGridViewRow selectedStudentRow = dataGridView2.SelectedRows[0];
                int ogrenciId = Convert.ToInt32(selectedStudentRow.Cells["kullanici_id"].Value);

                // Bağlantı dizesi
                string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Öğrenci-Program ilişkisini ekleyen sorgu
                    string query = @"
                INSERT INTO public.ogrenciprogram (ogrenci_id, program_id)
                VALUES (@p_ogrenci_id, @p_program_id)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p_ogrenci_id", ogrenciId);
                        command.Parameters.AddWithValue("@p_program_id", programId);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Öğrenci başarıyla programa dahil edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öğrenci programa dahil edilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadOgrencilerToDataGridView()
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT kullanici_id, ad, soy_ad, telefon, email FROM public.ogrenci";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0];
                    }

                    MessageBox.Show("Öğrenciler başarıyla yüklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Öğrenci bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProgramToDataGridView()
        {
            string connectionString = "server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT program_id, kur_id, gun, saat_araligi FROM public.program";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }

                    MessageBox.Show("Programlar başarıyla yüklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Program bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnOgrenciProgramOlustur_Click(object sender, EventArgs e)
        {
            grpProgramOlustur.Visible = false;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            // Programları getir
            LoadProgramToDataGridView();

            // Öğrencileri getir
            LoadOgrencilerToDataGridView();
        }
        private void LoadOgrenciProgramlariToDataGridView()
        {
            
        }
        private void btnOgrenciProgramlariListele_Click(object sender, EventArgs e)
        {
         
        }
    }
}
