namespace RolandGarross
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtKullaniciSifresi = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(251, 212);
            label1.Name = "label1";
            label1.Size = new Size(208, 32);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı      :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(251, 283);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Şifresi :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAdi.Location = new Point(547, 208);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(347, 39);
            txtKullaniciAdi.TabIndex = 2;
            txtKullaniciAdi.TextChanged += txtKullaniciAdi_TextChanged;
            // 
            // txtKullaniciSifresi
            // 
            txtKullaniciSifresi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciSifresi.Location = new Point(547, 280);
            txtKullaniciSifresi.Name = "txtKullaniciSifresi";
            txtKullaniciSifresi.PasswordChar = '*';
            txtKullaniciSifresi.Size = new Size(347, 39);
            txtKullaniciSifresi.TabIndex = 3;
            txtKullaniciSifresi.TextChanged += textBox1_TextChanged;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(461, 380);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(160, 58);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 772);
            Controls.Add(btnGirisYap);
            Controls.Add(txtKullaniciSifresi);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtKullaniciSifresi;
        private Button btnGirisYap;
    }
}
