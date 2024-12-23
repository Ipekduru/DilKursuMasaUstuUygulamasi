namespace RolandGarross
{
    partial class Kurlar
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
            btnEgitmenleriListele = new Button();
            dataGridView1 = new DataGridView();
            btnKursOluştur = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtKursAdi = new TextBox();
            txtKurId = new TextBox();
            txtDil = new TextBox();
            txtEgitmenId = new TextBox();
            comboBoxSeviye = new ComboBox();
            groupBoxKursOlustur = new GroupBox();
            btnOgrenciKurKaydiOlustur = new Button();
            dataGridView3 = new DataGridView();
            txtTamamlanmaDurumu = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtKursId = new TextBox();
            txtOgrenciId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            btnKurslariListele = new Button();
            button1 = new Button();
            btnKurOlusturAna = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxKursOlustur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(1714, 789);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(167, 45);
            btnGeriDon.TabIndex = 0;
            btnGeriDon.Text = "Geri Don";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // btnEgitmenleriListele
            // 
            btnEgitmenleriListele.Location = new Point(831, 58);
            btnEgitmenleriListele.Name = "btnEgitmenleriListele";
            btnEgitmenleriListele.Size = new Size(209, 48);
            btnEgitmenleriListele.TabIndex = 2;
            btnEgitmenleriListele.Text = "Eğitmenleri Listele";
            btnEgitmenleriListele.UseVisualStyleBackColor = true;
            btnEgitmenleriListele.Visible = false;
            btnEgitmenleriListele.Click += btnEgitmenleriListele_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(781, 405);
            dataGridView1.TabIndex = 3;
            dataGridView1.Visible = false;
            dataGridView1.CellClick += DataGridClick;
            // 
            // btnKursOluştur
            // 
            btnKursOluştur.Location = new Point(1139, 290);
            btnKursOluştur.Name = "btnKursOluştur";
            btnKursOluştur.Size = new Size(139, 50);
            btnKursOluştur.TabIndex = 4;
            btnKursOluştur.Text = "Kurs Oluştur";
            btnKursOluştur.UseVisualStyleBackColor = true;
            btnKursOluştur.Visible = false;
            btnKursOluştur.Click += btnKursOluştur_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1139, 61);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 5;
            label1.Text = "Kurs Adı :";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1139, 101);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 6;
            label2.Text = "Kurs Id:";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1139, 143);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 7;
            label3.Text = "Dil :";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1139, 182);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 8;
            label4.Text = "Eğitmen Id :";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1139, 236);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 9;
            label5.Text = "Seviye :";
            label5.Visible = false;
            // 
            // txtKursAdi
            // 
            txtKursAdi.Location = new Point(1261, 58);
            txtKursAdi.Name = "txtKursAdi";
            txtKursAdi.Size = new Size(251, 31);
            txtKursAdi.TabIndex = 10;
            txtKursAdi.Visible = false;
            // 
            // txtKurId
            // 
            txtKurId.Location = new Point(1261, 98);
            txtKurId.Name = "txtKurId";
            txtKurId.Size = new Size(251, 31);
            txtKurId.TabIndex = 11;
            txtKurId.Visible = false;
            // 
            // txtDil
            // 
            txtDil.Location = new Point(1261, 137);
            txtDil.Name = "txtDil";
            txtDil.Size = new Size(251, 31);
            txtDil.TabIndex = 12;
            txtDil.Visible = false;
            // 
            // txtEgitmenId
            // 
            txtEgitmenId.Location = new Point(1261, 182);
            txtEgitmenId.Name = "txtEgitmenId";
            txtEgitmenId.Size = new Size(251, 31);
            txtEgitmenId.TabIndex = 13;
            txtEgitmenId.Visible = false;
            // 
            // comboBoxSeviye
            // 
            comboBoxSeviye.FormattingEnabled = true;
            comboBoxSeviye.Location = new Point(1261, 233);
            comboBoxSeviye.Name = "comboBoxSeviye";
            comboBoxSeviye.Size = new Size(251, 33);
            comboBoxSeviye.TabIndex = 14;
            comboBoxSeviye.Visible = false;
            // 
            // groupBoxKursOlustur
            // 
            groupBoxKursOlustur.Controls.Add(btnOgrenciKurKaydiOlustur);
            groupBoxKursOlustur.Controls.Add(dataGridView3);
            groupBoxKursOlustur.Controls.Add(txtTamamlanmaDurumu);
            groupBoxKursOlustur.Controls.Add(dateTimePicker1);
            groupBoxKursOlustur.Controls.Add(txtKursId);
            groupBoxKursOlustur.Controls.Add(txtOgrenciId);
            groupBoxKursOlustur.Controls.Add(label9);
            groupBoxKursOlustur.Controls.Add(label8);
            groupBoxKursOlustur.Controls.Add(label7);
            groupBoxKursOlustur.Controls.Add(label6);
            groupBoxKursOlustur.Controls.Add(dataGridView2);
            groupBoxKursOlustur.Controls.Add(label2);
            groupBoxKursOlustur.Controls.Add(comboBoxSeviye);
            groupBoxKursOlustur.Controls.Add(btnEgitmenleriListele);
            groupBoxKursOlustur.Controls.Add(dataGridView1);
            groupBoxKursOlustur.Controls.Add(btnKursOluştur);
            groupBoxKursOlustur.Controls.Add(txtEgitmenId);
            groupBoxKursOlustur.Controls.Add(label1);
            groupBoxKursOlustur.Controls.Add(txtDil);
            groupBoxKursOlustur.Controls.Add(label3);
            groupBoxKursOlustur.Controls.Add(txtKurId);
            groupBoxKursOlustur.Controls.Add(label4);
            groupBoxKursOlustur.Controls.Add(txtKursAdi);
            groupBoxKursOlustur.Controls.Add(label5);
            groupBoxKursOlustur.Location = new Point(25, 21);
            groupBoxKursOlustur.Name = "groupBoxKursOlustur";
            groupBoxKursOlustur.Size = new Size(1582, 849);
            groupBoxKursOlustur.TabIndex = 15;
            groupBoxKursOlustur.TabStop = false;
            groupBoxKursOlustur.Text = "Kurs Olustur";
            groupBoxKursOlustur.Visible = false;
            // 
            // btnOgrenciKurKaydiOlustur
            // 
            btnOgrenciKurKaydiOlustur.Location = new Point(986, 669);
            btnOgrenciKurKaydiOlustur.Name = "btnOgrenciKurKaydiOlustur";
            btnOgrenciKurKaydiOlustur.Size = new Size(260, 34);
            btnOgrenciKurKaydiOlustur.TabIndex = 25;
            btnOgrenciKurKaydiOlustur.Text = "Öğrenciyi Kura Ekle";
            btnOgrenciKurKaydiOlustur.UseVisualStyleBackColor = true;
            btnOgrenciKurKaydiOlustur.Visible = false;
            btnOgrenciKurKaydiOlustur.Click += btnOgrenciKurKaydiOlustur_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(31, 81);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.Size = new Size(781, 405);
            dataGridView3.TabIndex = 24;
            dataGridView3.Visible = false;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // txtTamamlanmaDurumu
            // 
            txtTamamlanmaDurumu.Location = new Point(1161, 621);
            txtTamamlanmaDurumu.Name = "txtTamamlanmaDurumu";
            txtTamamlanmaDurumu.Size = new Size(247, 31);
            txtTamamlanmaDurumu.TabIndex = 23;
            txtTamamlanmaDurumu.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1096, 581);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.Visible = false;
            // 
            // txtKursId
            // 
            txtKursId.Location = new Point(1096, 542);
            txtKursId.Name = "txtKursId";
            txtKursId.Size = new Size(247, 31);
            txtKursId.TabIndex = 21;
            txtKursId.Visible = false;
            // 
            // txtOgrenciId
            // 
            txtOgrenciId.Location = new Point(1096, 500);
            txtOgrenciId.Name = "txtOgrenciId";
            txtOgrenciId.Size = new Size(247, 31);
            txtOgrenciId.TabIndex = 20;
            txtOgrenciId.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(964, 621);
            label9.Name = "label9";
            label9.Size = new Size(191, 25);
            label9.TabIndex = 19;
            label9.Text = "Tamamlanma Durumu:";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(964, 542);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 18;
            label8.Text = "Kurs Id :";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(964, 581);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 17;
            label7.Text = "Kayıt Tarihi :";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(964, 503);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 16;
            label6.Text = "Öğrenci Id :";
            label6.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(31, 444);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(781, 369);
            dataGridView2.TabIndex = 15;
            dataGridView2.Visible = false;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // btnKurslariListele
            // 
            btnKurslariListele.Location = new Point(1623, 102);
            btnKurslariListele.Name = "btnKurslariListele";
            btnKurslariListele.Size = new Size(291, 78);
            btnKurslariListele.TabIndex = 16;
            btnKurslariListele.Text = "Kursları Listele";
            btnKurslariListele.UseVisualStyleBackColor = true;
            btnKurslariListele.Click += btnKurslariListele_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1623, 187);
            button1.Name = "button1";
            button1.Size = new Size(291, 66);
            button1.TabIndex = 17;
            button1.Text = "Kura Öğrenci Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnKurOlusturAna
            // 
            btnKurOlusturAna.Location = new Point(1623, 269);
            btnKurOlusturAna.Name = "btnKurOlusturAna";
            btnKurOlusturAna.Size = new Size(291, 75);
            btnKurOlusturAna.TabIndex = 18;
            btnKurOlusturAna.Text = "Kur Olustur";
            btnKurOlusturAna.UseVisualStyleBackColor = true;
            btnKurOlusturAna.Click += btnKurOlusturAna_Click;
            // 
            // Kurlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1916, 911);
            Controls.Add(btnKurOlusturAna);
            Controls.Add(button1);
            Controls.Add(btnKurslariListele);
            Controls.Add(groupBoxKursOlustur);
            Controls.Add(btnGeriDon);
            Name = "Kurlar";
            Text = "DersProgrami";
            Load += Kurlar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxKursOlustur.ResumeLayout(false);
            groupBoxKursOlustur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGeriDon;
        private Button btnEgitmenleriListele;
        private DataGridView dataGridView1;
        private Button btnKursOluştur;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtKursAdi;
        private TextBox txtKurId;
        private TextBox txtDil;
        private TextBox txtEgitmenId;
        private ComboBox comboBoxSeviye;
        private GroupBox groupBoxKursOlustur;
        private Button btnKurslariListele;
        private TextBox txtOgrenciId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridView dataGridView2;
        private TextBox txtTamamlanmaDurumu;
        private DateTimePicker dateTimePicker1;
        private TextBox txtKursId;
        private Button button1;
        private DataGridView dataGridView3;
        private Button btnOgrenciKurKaydiOlustur;
        private Button btnKurOlusturAna;
    }
}