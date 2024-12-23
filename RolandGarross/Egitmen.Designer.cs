namespace RolandGarross
{
    partial class Egitmen
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
            grpEgitmenEkle = new GroupBox();
            cmbDiller = new ComboBox();
            txtTecrubeYili = new TextBox();
            label8 = new Label();
            btnEgitmenKaydiOlustur = new Button();
            txtKullaniciTelefon = new TextBox();
            label1 = new Label();
            txtKullaniciTur = new TextBox();
            label2 = new Label();
            txtKullaniciEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtKullaniciSoyAdi = new TextBox();
            label5 = new Label();
            txtKullaniciAdi = new TextBox();
            label6 = new Label();
            txtKullaniciId = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            btnEgitmenleriListele = new Button();
            btnEgitmenAra = new Button();
            btnEgitmenSil = new Button();
            btnEgitmenEkle = new Button();
            cmbEgitmenSil = new ComboBox();
            label9 = new Label();
            btnEgitmenKaydiSil = new Button();
            groupBoxEgitmenSil = new GroupBox();
            dataGridView1 = new DataGridView();
            labelEgitmenAra = new Label();
            labelEgitmenListele = new Label();
            txtEgitmenAra = new TextBox();
            grpEgitmenEkle.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxEgitmenSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(1533, 744);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(154, 80);
            btnGeriDon.TabIndex = 0;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // grpEgitmenEkle
            // 
            grpEgitmenEkle.Controls.Add(cmbDiller);
            grpEgitmenEkle.Controls.Add(txtTecrubeYili);
            grpEgitmenEkle.Controls.Add(label8);
            grpEgitmenEkle.Controls.Add(btnEgitmenKaydiOlustur);
            grpEgitmenEkle.Controls.Add(txtKullaniciTelefon);
            grpEgitmenEkle.Controls.Add(label1);
            grpEgitmenEkle.Controls.Add(txtKullaniciTur);
            grpEgitmenEkle.Controls.Add(label2);
            grpEgitmenEkle.Controls.Add(txtKullaniciEmail);
            grpEgitmenEkle.Controls.Add(label3);
            grpEgitmenEkle.Controls.Add(label4);
            grpEgitmenEkle.Controls.Add(txtKullaniciSoyAdi);
            grpEgitmenEkle.Controls.Add(label5);
            grpEgitmenEkle.Controls.Add(txtKullaniciAdi);
            grpEgitmenEkle.Controls.Add(label6);
            grpEgitmenEkle.Controls.Add(txtKullaniciId);
            grpEgitmenEkle.Controls.Add(label7);
            grpEgitmenEkle.Location = new Point(63, 137);
            grpEgitmenEkle.Name = "grpEgitmenEkle";
            grpEgitmenEkle.Size = new Size(511, 455);
            grpEgitmenEkle.TabIndex = 18;
            grpEgitmenEkle.TabStop = false;
            grpEgitmenEkle.Text = "Egitmen Ekle";
            grpEgitmenEkle.Visible = false;
            // 
            // cmbDiller
            // 
            cmbDiller.FormattingEnabled = true;
            cmbDiller.Location = new Point(200, 308);
            cmbDiller.Name = "cmbDiller";
            cmbDiller.Size = new Size(236, 33);
            cmbDiller.TabIndex = 21;
            // 
            // txtTecrubeYili
            // 
            txtTecrubeYili.Location = new Point(200, 359);
            txtTecrubeYili.Name = "txtTecrubeYili";
            txtTecrubeYili.Size = new Size(236, 31);
            txtTecrubeYili.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 359);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 19;
            label8.Text = "Tecrübe Yılı:";
            // 
            // btnEgitmenKaydiOlustur
            // 
            btnEgitmenKaydiOlustur.Location = new Point(179, 415);
            btnEgitmenKaydiOlustur.Name = "btnEgitmenKaydiOlustur";
            btnEgitmenKaydiOlustur.Size = new Size(227, 34);
            btnEgitmenKaydiOlustur.TabIndex = 17;
            btnEgitmenKaydiOlustur.Text = "Eğitmen Ekle";
            btnEgitmenKaydiOlustur.UseVisualStyleBackColor = true;
            btnEgitmenKaydiOlustur.Click += btnEgitmenKaydiOlustur_Click;
            // 
            // txtKullaniciTelefon
            // 
            txtKullaniciTelefon.Location = new Point(200, 186);
            txtKullaniciTelefon.Name = "txtKullaniciTelefon";
            txtKullaniciTelefon.Size = new Size(236, 31);
            txtKullaniciTelefon.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 54);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 2;
            label1.Text = "Eğitmen Id:";
            // 
            // txtKullaniciTur
            // 
            txtKullaniciTur.Location = new Point(200, 270);
            txtKullaniciTur.Name = "txtKullaniciTur";
            txtKullaniciTur.Size = new Size(236, 31);
            txtKullaniciTur.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 97);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 3;
            label2.Text = "Eğitmen Adı:";
            // 
            // txtKullaniciEmail
            // 
            txtKullaniciEmail.Location = new Point(200, 227);
            txtKullaniciEmail.Name = "txtKullaniciEmail";
            txtKullaniciEmail.Size = new Size(236, 31);
            txtKullaniciEmail.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 145);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 4;
            label3.Text = " Eğitmen Soy Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 186);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 5;
            label4.Text = "Eğitmen Telefon:";
            // 
            // txtKullaniciSoyAdi
            // 
            txtKullaniciSoyAdi.Location = new Point(200, 145);
            txtKullaniciSoyAdi.Name = "txtKullaniciSoyAdi";
            txtKullaniciSoyAdi.Size = new Size(236, 31);
            txtKullaniciSoyAdi.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 227);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 6;
            label5.Text = "Eğitmen Email:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(200, 97);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(236, 31);
            txtKullaniciAdi.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 270);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 7;
            label6.Text = "Kullanıcı Türü:";
            // 
            // txtKullaniciId
            // 
            txtKullaniciId.Location = new Point(200, 54);
            txtKullaniciId.Name = "txtKullaniciId";
            txtKullaniciId.Size = new Size(236, 31);
            txtKullaniciId.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 308);
            label7.Name = "label7";
            label7.Size = new Size(132, 25);
            label7.TabIndex = 8;
            label7.Text = "Uzmanlık Alanı:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEgitmenleriListele);
            panel1.Controls.Add(btnEgitmenAra);
            panel1.Controls.Add(btnEgitmenSil);
            panel1.Controls.Add(btnEgitmenEkle);
            panel1.Location = new Point(-9, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1706, 65);
            panel1.TabIndex = 19;
            // 
            // btnEgitmenleriListele
            // 
            btnEgitmenleriListele.Location = new Point(680, 4);
            btnEgitmenleriListele.Name = "btnEgitmenleriListele";
            btnEgitmenleriListele.Size = new Size(168, 61);
            btnEgitmenleriListele.TabIndex = 5;
            btnEgitmenleriListele.Text = "Eğitmen Listele";
            btnEgitmenleriListele.UseVisualStyleBackColor = true;
            btnEgitmenleriListele.Click += btnEgitmenleriListele_Click;
            // 
            // btnEgitmenAra
            // 
            btnEgitmenAra.Location = new Point(470, 4);
            btnEgitmenAra.Name = "btnEgitmenAra";
            btnEgitmenAra.Size = new Size(168, 61);
            btnEgitmenAra.TabIndex = 4;
            btnEgitmenAra.Text = "Eğitmen Ara";
            btnEgitmenAra.UseVisualStyleBackColor = true;
            btnEgitmenAra.Click += btnEgitmenAra_Click;
            // 
            // btnEgitmenSil
            // 
            btnEgitmenSil.Location = new Point(251, 3);
            btnEgitmenSil.Name = "btnEgitmenSil";
            btnEgitmenSil.Size = new Size(168, 61);
            btnEgitmenSil.TabIndex = 2;
            btnEgitmenSil.Text = "EğitmenSil";
            btnEgitmenSil.UseVisualStyleBackColor = true;
            btnEgitmenSil.Click += btnEgitmenSil_Click;
            // 
            // btnEgitmenEkle
            // 
            btnEgitmenEkle.Location = new Point(20, 3);
            btnEgitmenEkle.Name = "btnEgitmenEkle";
            btnEgitmenEkle.Size = new Size(168, 61);
            btnEgitmenEkle.TabIndex = 1;
            btnEgitmenEkle.Text = "Eğitmen Ekle";
            btnEgitmenEkle.UseVisualStyleBackColor = true;
            btnEgitmenEkle.Click += btnEgitmenEkle_Click;
            // 
            // cmbEgitmenSil
            // 
            cmbEgitmenSil.FormattingEnabled = true;
            cmbEgitmenSil.Location = new Point(161, 45);
            cmbEgitmenSil.Name = "cmbEgitmenSil";
            cmbEgitmenSil.Size = new Size(386, 33);
            cmbEgitmenSil.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 54);
            label9.Name = "label9";
            label9.Size = new Size(100, 25);
            label9.TabIndex = 21;
            label9.Text = "Egitmen Sil";
            // 
            // btnEgitmenKaydiSil
            // 
            btnEgitmenKaydiSil.Location = new Point(131, 96);
            btnEgitmenKaydiSil.Name = "btnEgitmenKaydiSil";
            btnEgitmenKaydiSil.Size = new Size(151, 35);
            btnEgitmenKaydiSil.TabIndex = 22;
            btnEgitmenKaydiSil.Text = "EğitmenSil";
            btnEgitmenKaydiSil.UseVisualStyleBackColor = true;
            btnEgitmenKaydiSil.Click += btnEgitmenKaydiSil_Click;
            // 
            // groupBoxEgitmenSil
            // 
            groupBoxEgitmenSil.Controls.Add(cmbEgitmenSil);
            groupBoxEgitmenSil.Controls.Add(btnEgitmenKaydiSil);
            groupBoxEgitmenSil.Controls.Add(label9);
            groupBoxEgitmenSil.Location = new Point(50, 603);
            groupBoxEgitmenSil.Name = "groupBoxEgitmenSil";
            groupBoxEgitmenSil.Size = new Size(553, 221);
            groupBoxEgitmenSil.TabIndex = 23;
            groupBoxEgitmenSil.TabStop = false;
            groupBoxEgitmenSil.Text = "Eğitmen Sil";
            groupBoxEgitmenSil.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(623, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(968, 564);
            dataGridView1.TabIndex = 24;
            dataGridView1.Visible = false;
            // 
            // labelEgitmenAra
            // 
            labelEgitmenAra.AutoSize = true;
            labelEgitmenAra.Location = new Point(623, 111);
            labelEgitmenAra.Name = "labelEgitmenAra";
            labelEgitmenAra.Size = new Size(109, 25);
            labelEgitmenAra.TabIndex = 25;
            labelEgitmenAra.Text = "Eğitmen Ara";
            labelEgitmenAra.Visible = false;
            // 
            // labelEgitmenListele
            // 
            labelEgitmenListele.AutoSize = true;
            labelEgitmenListele.Location = new Point(632, 732);
            labelEgitmenListele.Name = "labelEgitmenListele";
            labelEgitmenListele.Size = new Size(130, 25);
            labelEgitmenListele.TabIndex = 26;
            labelEgitmenListele.Text = "Eğitmen Listele";
            labelEgitmenListele.Visible = false;
            // 
            // txtEgitmenAra
            // 
            txtEgitmenAra.Location = new Point(775, 110);
            txtEgitmenAra.Name = "txtEgitmenAra";
            txtEgitmenAra.Size = new Size(376, 31);
            txtEgitmenAra.TabIndex = 27;
            txtEgitmenAra.Visible = false;
            txtEgitmenAra.TextChanged += txtEgitmenAra_TextChanged;
            // 
            // Egitmen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1699, 836);
            Controls.Add(txtEgitmenAra);
            Controls.Add(labelEgitmenListele);
            Controls.Add(labelEgitmenAra);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxEgitmenSil);
            Controls.Add(panel1);
            Controls.Add(grpEgitmenEkle);
            Controls.Add(btnGeriDon);
            Name = "Egitmen";
            Text = "Eğitmen İşlemleri";
            Load += Egitmen_Load;
            grpEgitmenEkle.ResumeLayout(false);
            grpEgitmenEkle.PerformLayout();
            panel1.ResumeLayout(false);
            groupBoxEgitmenSil.ResumeLayout(false);
            groupBoxEgitmenSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeriDon;
        private GroupBox grpEgitmenEkle;
        private Button btnEgitmenKaydiOlustur;
        private TextBox txtKullaniciTelefon;
        private Label label1;
        private TextBox txtKullaniciTur;
        private Label label2;
        private TextBox txtKullaniciEmail;
        private Label label3;
        private Label label4;
        private TextBox txtKullaniciSoyAdi;
        private Label label5;
        private TextBox txtKullaniciAdi;
        private Label label6;
        private TextBox txtKullaniciId;
        private Label label7;
        private Panel panel1;
        private Button btnEgitmenleriListele;
        private Button btnEgitmenAra;
        private Button btnEgitmenSil;
        private Button btnEgitmenEkle;
        private TextBox txtTecrubeYili;
        private Label label8;
        private ComboBox cmbDiller;
        private ComboBox cmbEgitmenSil;
        private Label label9;
        private Button btnEgitmenKaydiSil;
        private GroupBox groupBoxEgitmenSil;
        private DataGridView dataGridView1;
        private Label labelEgitmenAra;
        private Label labelEgitmenListele;
        private TextBox txtEgitmenAra;
    }
}