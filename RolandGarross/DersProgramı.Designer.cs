namespace RolandGarross
{
    partial class DersProgramı
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
            btnProgramKaydiOlustur = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            txtProgramId = new TextBox();
            label2 = new Label();
            txtKurId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtSaatAraligi = new TextBox();
            dataGridView2 = new DataGridView();
            btnOgrenciProgramOlustur = new Button();
            btnOgrenciyiProgramaDahilEt = new Button();
            grpProgramOlustur = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            grpProgramOlustur.SuspendLayout();
            SuspendLayout();
            // 
            // btnProgramKaydiOlustur
            // 
            btnProgramKaydiOlustur.Location = new Point(18, 252);
            btnProgramKaydiOlustur.Name = "btnProgramKaydiOlustur";
            btnProgramKaydiOlustur.Size = new Size(273, 49);
            btnProgramKaydiOlustur.TabIndex = 0;
            btnProgramKaydiOlustur.Text = "Program Kaydı Oluştur";
            btnProgramKaydiOlustur.UseVisualStyleBackColor = true;
            btnProgramKaydiOlustur.Click += btnProgramKaydiOlustur_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(790, 390);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridViewKurslar_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(1595, 49);
            button1.Name = "button1";
            button1.Size = new Size(275, 78);
            button1.TabIndex = 2;
            button1.Text = "Program Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 44);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 3;
            label1.Text = "Program Id: ";
            // 
            // txtProgramId
            // 
            txtProgramId.Location = new Point(174, 41);
            txtProgramId.Name = "txtProgramId";
            txtProgramId.Size = new Size(208, 31);
            txtProgramId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 92);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 5;
            label2.Text = "Kur Id: ";
            // 
            // txtKurId
            // 
            txtKurId.Location = new Point(174, 92);
            txtKurId.Name = "txtKurId";
            txtKurId.Size = new Size(208, 31);
            txtKurId.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 201);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 7;
            label3.Text = "Saat Aralığı ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 158);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 8;
            label4.Text = "Gun: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(174, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtSaatAraligi
            // 
            txtSaatAraligi.Location = new Point(174, 201);
            txtSaatAraligi.Name = "txtSaatAraligi";
            txtSaatAraligi.Size = new Size(208, 31);
            txtSaatAraligi.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(30, 451);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(790, 390);
            dataGridView2.TabIndex = 11;
            // 
            // btnOgrenciProgramOlustur
            // 
            btnOgrenciProgramOlustur.Location = new Point(1595, 150);
            btnOgrenciProgramOlustur.Name = "btnOgrenciProgramOlustur";
            btnOgrenciProgramOlustur.Size = new Size(275, 78);
            btnOgrenciProgramOlustur.TabIndex = 12;
            btnOgrenciProgramOlustur.Text = "Öğrenci Program  Oluştur";
            btnOgrenciProgramOlustur.UseVisualStyleBackColor = true;
            btnOgrenciProgramOlustur.Click += btnOgrenciProgramOlustur_Click;
            // 
            // btnOgrenciyiProgramaDahilEt
            // 
            btnOgrenciyiProgramaDahilEt.Location = new Point(865, 744);
            btnOgrenciyiProgramaDahilEt.Name = "btnOgrenciyiProgramaDahilEt";
            btnOgrenciyiProgramaDahilEt.Size = new Size(281, 75);
            btnOgrenciyiProgramaDahilEt.TabIndex = 13;
            btnOgrenciyiProgramaDahilEt.Text = "Ogrenciyi Programa Dahil Et";
            btnOgrenciyiProgramaDahilEt.UseVisualStyleBackColor = true;
            btnOgrenciyiProgramaDahilEt.Visible = false;
            btnOgrenciyiProgramaDahilEt.Click += btnOgrenciyiProgramaDahilEt_Click;
            // 
            // grpProgramOlustur
            // 
            grpProgramOlustur.Controls.Add(dateTimePicker1);
            grpProgramOlustur.Controls.Add(btnProgramKaydiOlustur);
            grpProgramOlustur.Controls.Add(label1);
            grpProgramOlustur.Controls.Add(txtProgramId);
            grpProgramOlustur.Controls.Add(txtSaatAraligi);
            grpProgramOlustur.Controls.Add(label2);
            grpProgramOlustur.Controls.Add(txtKurId);
            grpProgramOlustur.Controls.Add(label4);
            grpProgramOlustur.Controls.Add(label3);
            grpProgramOlustur.Location = new Point(865, 58);
            grpProgramOlustur.Name = "grpProgramOlustur";
            grpProgramOlustur.Size = new Size(627, 340);
            grpProgramOlustur.TabIndex = 14;
            grpProgramOlustur.TabStop = false;
            grpProgramOlustur.Text = "Program Oluştur";
            grpProgramOlustur.Visible = false;
            // 
            // DersProgramı
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1910, 967);
            Controls.Add(grpProgramOlustur);
            Controls.Add(btnOgrenciyiProgramaDahilEt);
            Controls.Add(btnOgrenciProgramOlustur);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "DersProgramı";
            Text = "DersProgramı";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            grpProgramOlustur.ResumeLayout(false);
            grpProgramOlustur.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProgramKaydiOlustur;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox txtProgramId;
        private Label label2;
        private TextBox txtKurId;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSaatAraligi;
        private DataGridView dataGridView2;
        private Button btnOgrenciProgramOlustur;
        private Button btnOgrenciyiProgramaDahilEt;
        private GroupBox grpProgramOlustur;
    }
}