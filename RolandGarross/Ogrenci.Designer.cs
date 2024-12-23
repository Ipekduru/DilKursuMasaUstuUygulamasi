namespace RolandGarross
{
    partial class Ogrenci
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
            btnGeriDon = new Button();
            panel1 = new Panel();
            btnOgrencileriListele = new Button();
            btnOgrenciGüncelle = new Button();
            btnOgrenciAra = new Button();
            btnOgrenciSil = new Button();
            btnOgrenciEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtKullaniciId = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtKullaniciSoyAdi = new TextBox();
            txtKullaniciTelefon = new TextBox();
            txtKullaniciEmail = new TextBox();
            txtKullaniciTur = new TextBox();
            dTPKayitTarihi = new DateTimePicker();
            grpOgrenciEkle = new GroupBox();
            btnOgrenciKaydiGuncelle = new Button();
            btnOgrenciKaydiOlustur = new Button();
            cmbOgrenciSil = new ComboBox();
            label8 = new Label();
            btnOgrenciKaydiSil = new Button();
            groupBoxOgrenciSil = new GroupBox();
            ogrenciGuncelleAra = new Label();
            btnOgrenciSec = new Button();
            dataGridView1 = new DataGridView();
            txtOgrenciAra = new TextBox();
            panel1.SuspendLayout();
            grpOgrenciEkle.SuspendLayout();
            groupBoxOgrenciSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(1633, 846);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(168, 61);
            btnGeriDon.TabIndex = 0;
            btnGeriDon.Text = "Geri Don";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOgrencileriListele);
            panel1.Controls.Add(btnOgrenciGüncelle);
            panel1.Controls.Add(btnOgrenciAra);
            panel1.Controls.Add(btnOgrenciSil);
            panel1.Controls.Add(btnOgrenciEkle);
            panel1.Location = new Point(-8, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2093, 63);
            panel1.TabIndex = 1;
            // 
            // btnOgrencileriListele
            // 
            btnOgrencileriListele.Location = new Point(889, 3);
            btnOgrencileriListele.Name = "btnOgrencileriListele";
            btnOgrencileriListele.Size = new Size(168, 61);
            btnOgrencileriListele.TabIndex = 5;
            btnOgrencileriListele.Text = "Öğrencileri Listele";
            btnOgrencileriListele.UseVisualStyleBackColor = true;
            btnOgrencileriListele.Click += btnOgrencileriListele_Click;
            // 
            // btnOgrenciGüncelle
            // 
            btnOgrenciGüncelle.Location = new Point(466, 3);
            btnOgrenciGüncelle.Name = "btnOgrenciGüncelle";
            btnOgrenciGüncelle.Size = new Size(168, 61);
            btnOgrenciGüncelle.TabIndex = 3;
            btnOgrenciGüncelle.Text = "Öğrenci Güncelle";
            btnOgrenciGüncelle.UseVisualStyleBackColor = true;
            btnOgrenciGüncelle.Click += btnOgrenciGüncelle_Click;
            // 
            // btnOgrenciAra
            // 
            btnOgrenciAra.Location = new Point(675, 3);
            btnOgrenciAra.Name = "btnOgrenciAra";
            btnOgrenciAra.Size = new Size(168, 61);
            btnOgrenciAra.TabIndex = 4;
            btnOgrenciAra.Text = "Öğrenci Ara";
            btnOgrenciAra.UseVisualStyleBackColor = true;
            btnOgrenciAra.Click += btnOgrenciAra_Click;
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.Location = new Point(251, 3);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(168, 61);
            btnOgrenciSil.TabIndex = 2;
            btnOgrenciSil.Text = "Öğrenci Sil";
            btnOgrenciSil.UseVisualStyleBackColor = true;
            btnOgrenciSil.Click += btnOgrenciSil_Click;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(20, 3);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(168, 61);
            btnOgrenciEkle.TabIndex = 1;
            btnOgrenciEkle.Text = "Öğrenci Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 54);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 2;
            label1.Text = "Öğrenci Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 97);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 3;
            label2.Text = "Öğrenci Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 145);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 4;
            label3.Text = "Öğrenci Soy Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 186);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 5;
            label4.Text = "Öğrenci Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 227);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 6;
            label5.Text = "Öğrenci Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 270);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 7;
            label6.Text = "Öğrenci Türü:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 308);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 8;
            label7.Text = "Öğrenci Tarihi:";
            // 
            // txtKullaniciId
            // 
            txtKullaniciId.Location = new Point(200, 54);
            txtKullaniciId.Name = "txtKullaniciId";
            txtKullaniciId.Size = new Size(236, 31);
            txtKullaniciId.TabIndex = 9;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(200, 97);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(236, 31);
            txtKullaniciAdi.TabIndex = 10;
            // 
            // txtKullaniciSoyAdi
            // 
            txtKullaniciSoyAdi.Location = new Point(200, 145);
            txtKullaniciSoyAdi.Name = "txtKullaniciSoyAdi";
            txtKullaniciSoyAdi.Size = new Size(236, 31);
            txtKullaniciSoyAdi.TabIndex = 11;
            // 
            // txtKullaniciTelefon
            // 
            txtKullaniciTelefon.Location = new Point(200, 186);
            txtKullaniciTelefon.Name = "txtKullaniciTelefon";
            txtKullaniciTelefon.Size = new Size(236, 31);
            txtKullaniciTelefon.TabIndex = 12;
            // 
            // txtKullaniciEmail
            // 
            txtKullaniciEmail.Location = new Point(200, 227);
            txtKullaniciEmail.Name = "txtKullaniciEmail";
            txtKullaniciEmail.Size = new Size(236, 31);
            txtKullaniciEmail.TabIndex = 13;
            // 
            // txtKullaniciTur
            // 
            txtKullaniciTur.Location = new Point(200, 270);
            txtKullaniciTur.Name = "txtKullaniciTur";
            txtKullaniciTur.Size = new Size(236, 31);
            txtKullaniciTur.TabIndex = 14;
            // 
            // dTPKayitTarihi
            // 
            dTPKayitTarihi.Location = new Point(200, 308);
            dTPKayitTarihi.Name = "dTPKayitTarihi";
            dTPKayitTarihi.Size = new Size(300, 31);
            dTPKayitTarihi.TabIndex = 16;
            // 
            // grpOgrenciEkle
            // 
            grpOgrenciEkle.Controls.Add(btnOgrenciKaydiGuncelle);
            grpOgrenciEkle.Controls.Add(btnOgrenciKaydiOlustur);
            grpOgrenciEkle.Controls.Add(txtKullaniciTelefon);
            grpOgrenciEkle.Controls.Add(dTPKayitTarihi);
            grpOgrenciEkle.Controls.Add(label1);
            grpOgrenciEkle.Controls.Add(txtKullaniciTur);
            grpOgrenciEkle.Controls.Add(label2);
            grpOgrenciEkle.Controls.Add(txtKullaniciEmail);
            grpOgrenciEkle.Controls.Add(label3);
            grpOgrenciEkle.Controls.Add(label4);
            grpOgrenciEkle.Controls.Add(txtKullaniciSoyAdi);
            grpOgrenciEkle.Controls.Add(label5);
            grpOgrenciEkle.Controls.Add(txtKullaniciAdi);
            grpOgrenciEkle.Controls.Add(label6);
            grpOgrenciEkle.Controls.Add(txtKullaniciId);
            grpOgrenciEkle.Controls.Add(label7);
            grpOgrenciEkle.Location = new Point(34, 90);
            grpOgrenciEkle.Name = "grpOgrenciEkle";
            grpOgrenciEkle.Size = new Size(555, 447);
            grpOgrenciEkle.TabIndex = 17;
            grpOgrenciEkle.TabStop = false;
            grpOgrenciEkle.Text = "Öğrenci Ekle /Güncelle";
            grpOgrenciEkle.Visible = false;
            // 
            // btnOgrenciKaydiGuncelle
            // 
            btnOgrenciKaydiGuncelle.Location = new Point(47, 395);
            btnOgrenciKaydiGuncelle.Name = "btnOgrenciKaydiGuncelle";
            btnOgrenciKaydiGuncelle.Size = new Size(222, 34);
            btnOgrenciKaydiGuncelle.TabIndex = 18;
            btnOgrenciKaydiGuncelle.Text = "Öğrenci Güncelle";
            btnOgrenciKaydiGuncelle.UseVisualStyleBackColor = true;
            btnOgrenciKaydiGuncelle.Click += btnOgrenciKaydiGuncelle_Click;
            // 
            // btnOgrenciKaydiOlustur
            // 
            btnOgrenciKaydiOlustur.Location = new Point(42, 355);
            btnOgrenciKaydiOlustur.Name = "btnOgrenciKaydiOlustur";
            btnOgrenciKaydiOlustur.Size = new Size(227, 34);
            btnOgrenciKaydiOlustur.TabIndex = 17;
            btnOgrenciKaydiOlustur.Text = "Öğrenci Ekle";
            btnOgrenciKaydiOlustur.UseVisualStyleBackColor = true;
            btnOgrenciKaydiOlustur.Click += btnOgrenciKaydiOlustur_Click;
            // 
            // cmbOgrenciSil
            // 
            cmbOgrenciSil.FormattingEnabled = true;
            cmbOgrenciSil.Location = new Point(271, 61);
            cmbOgrenciSil.Name = "cmbOgrenciSil";
            cmbOgrenciSil.Size = new Size(206, 33);
            cmbOgrenciSil.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 64);
            label8.Name = "label8";
            label8.Size = new Size(265, 25);
            label8.TabIndex = 19;
            label8.Text = "Kaydı Silinecek Öğrenciyi Seçiniz";
            // 
            // btnOgrenciKaydiSil
            // 
            btnOgrenciKaydiSil.Location = new Point(101, 100);
            btnOgrenciKaydiSil.Name = "btnOgrenciKaydiSil";
            btnOgrenciKaydiSil.Size = new Size(224, 46);
            btnOgrenciKaydiSil.TabIndex = 20;
            btnOgrenciKaydiSil.Text = "Öğrenci Kaydı Sil";
            btnOgrenciKaydiSil.UseVisualStyleBackColor = true;
            btnOgrenciKaydiSil.Click += button1_Click;
            // 
            // groupBoxOgrenciSil
            // 
            groupBoxOgrenciSil.Controls.Add(cmbOgrenciSil);
            groupBoxOgrenciSil.Controls.Add(btnOgrenciKaydiSil);
            groupBoxOgrenciSil.Controls.Add(label8);
            groupBoxOgrenciSil.Location = new Point(34, 571);
            groupBoxOgrenciSil.Name = "groupBoxOgrenciSil";
            groupBoxOgrenciSil.Size = new Size(489, 265);
            groupBoxOgrenciSil.TabIndex = 21;
            groupBoxOgrenciSil.TabStop = false;
            groupBoxOgrenciSil.Text = "Öğrenci Sil";
            groupBoxOgrenciSil.Visible = false;
            // 
            // ogrenciGuncelleAra
            // 
            ogrenciGuncelleAra.AutoSize = true;
            ogrenciGuncelleAra.Location = new Point(654, 106);
            ogrenciGuncelleAra.Name = "ogrenciGuncelleAra";
            ogrenciGuncelleAra.Size = new Size(309, 25);
            ogrenciGuncelleAra.TabIndex = 23;
            ogrenciGuncelleAra.Text = "Kaydı Güncellenecek Öğrenciyi Seçiniz";
            ogrenciGuncelleAra.Visible = false;
            // 
            // btnOgrenciSec
            // 
            btnOgrenciSec.Location = new Point(654, 632);
            btnOgrenciSec.Name = "btnOgrenciSec";
            btnOgrenciSec.Size = new Size(225, 51);
            btnOgrenciSec.TabIndex = 24;
            btnOgrenciSec.Text = "Öğrenci Seç";
            btnOgrenciSec.UseVisualStyleBackColor = true;
            btnOgrenciSec.Visible = false;
            btnOgrenciSec.Click += btnOgrenciSec_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(654, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(883, 455);
            dataGridView1.TabIndex = 25;
            dataGridView1.Visible = false;
            // 
            // txtOgrenciAra
            // 
            txtOgrenciAra.Location = new Point(969, 106);
            txtOgrenciAra.Name = "txtOgrenciAra";
            txtOgrenciAra.Size = new Size(410, 31);
            txtOgrenciAra.TabIndex = 26;
            txtOgrenciAra.Visible = false;
            txtOgrenciAra.TextChanged += txtOgrenciAra_TextChanged;
            // 
            // Ogrenci
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2080, 944);
            Controls.Add(txtOgrenciAra);
            Controls.Add(dataGridView1);
            Controls.Add(btnOgrenciSec);
            Controls.Add(ogrenciGuncelleAra);
            Controls.Add(groupBoxOgrenciSil);
            Controls.Add(grpOgrenciEkle);
            Controls.Add(btnGeriDon);
            Controls.Add(panel1);
            Name = "Ogrenci";
            Text = "Ogrenci";
            Load += Ogrenci_Load;
            panel1.ResumeLayout(false);
            grpOgrenciEkle.ResumeLayout(false);
            grpOgrenciEkle.PerformLayout();
            groupBoxOgrenciSil.ResumeLayout(false);
            groupBoxOgrenciSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeriDon;
        private Panel panel1;
        private Button btnOgrenciEkle;
        private Button btnOgrenciGüncelle;
        private Button btnOgrenciSil;
        private Button btnOgrenciAra;
        private Button btnOgrencileriListele;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtKullaniciId;
        private TextBox txtKullaniciAdi;
        private TextBox txtKullaniciSoyAdi;
        private TextBox txtKullaniciTelefon;
        private TextBox txtKullaniciEmail;
        private TextBox txtKullaniciTur;
        private DateTimePicker dTPKayitTarihi;
        private GroupBox grpOgrenciEkle;
        private Button btnOgrenciKaydiOlustur;
        private ComboBox cmbOgrenciSil;
        private Label label8;
        private Button btnOgrenciKaydiSil;
        private GroupBox groupBoxOgrenciSil;
        private Label ogrenciGuncelleAra;
        private Button btnOgrenciSec;
        private Button btnOgrenciKaydiGuncelle;
        private DataGridView dataGridView1;
        private TextBox txtOgrenciAra;
    }
}