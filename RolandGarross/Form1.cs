using Npgsql;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RolandGarross
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; DataBase=rolangarros; user Id=postgres; password=100421Duruipek..");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanýcý giriþ iþlemi
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtKullaniciSifresi.Text.Trim();

            try
            {
                baglanti.Open();

                // SQL sorgusu
                string query = "SELECT COUNT(*) FROM admin WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";

                using (NpgsqlCommand command = new NpgsqlCommand(query, baglanti))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    // Sorguyu çalýþtýr ve sonuç al
                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    if (userCount > 0) // Eðer eþleþen kayýt varsa
                    {
                        // Form2'yi aç
                        AnaMenu anaMenu = new AnaMenu();
                        anaMenu.Show();

                        // Mevcut formu gizle
                        this.Hide();
                        MessageBox.Show("Giriþ baþarýlý.");
                    }
                    else
                    {
                        MessageBox.Show("Hatalý kullanýcý adý veya þifre.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
            finally
            {
                // Baðlantýyý kapat
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }



    }
}
