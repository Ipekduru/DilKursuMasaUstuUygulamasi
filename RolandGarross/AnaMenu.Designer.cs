namespace RolandGarross
{
    partial class AnaMenu
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
            panel1 = new Panel();
            btnOgrenciIslemleri = new Button();
            btnEgitmenİslemleri = new Button();
            programIslemleri = new Button();
            btnDersProgrami = new Button();
            btnCikisYap = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, -20);
            panel1.Name = "panel1";
            panel1.Size = new Size(1511, 77);
            panel1.TabIndex = 0;
            // 
            // btnOgrenciIslemleri
            // 
            btnOgrenciIslemleri.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnOgrenciIslemleri.Location = new Point(63, 111);
            btnOgrenciIslemleri.Name = "btnOgrenciIslemleri";
            btnOgrenciIslemleri.Size = new Size(272, 86);
            btnOgrenciIslemleri.TabIndex = 1;
            btnOgrenciIslemleri.Text = "Öğrenci İşlemleri";
            btnOgrenciIslemleri.UseVisualStyleBackColor = true;
            btnOgrenciIslemleri.Click += btnOgrenciIslemleri_Click;
            // 
            // btnEgitmenİslemleri
            // 
            btnEgitmenİslemleri.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEgitmenİslemleri.Location = new Point(487, 111);
            btnEgitmenİslemleri.Name = "btnEgitmenİslemleri";
            btnEgitmenİslemleri.Size = new Size(271, 86);
            btnEgitmenİslemleri.TabIndex = 2;
            btnEgitmenİslemleri.Text = "Eğitmen İşlemleri";
            btnEgitmenİslemleri.UseVisualStyleBackColor = true;
            btnEgitmenİslemleri.Click += btnEgitmenİslemleri_Click;
            // 
            // programIslemleri
            // 
            programIslemleri.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            programIslemleri.Location = new Point(880, 111);
            programIslemleri.Name = "programIslemleri";
            programIslemleri.Size = new Size(271, 86);
            programIslemleri.TabIndex = 3;
            programIslemleri.Text = "Program İşlemleri";
            programIslemleri.UseVisualStyleBackColor = true;
            programIslemleri.Click += programIslemleri_Click;
            // 
            // btnDersProgrami
            // 
            btnDersProgrami.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDersProgrami.Location = new Point(63, 275);
            btnDersProgrami.Name = "btnDersProgrami";
            btnDersProgrami.Size = new Size(271, 86);
            btnDersProgrami.TabIndex = 4;
            btnDersProgrami.Text = "Ders Programı";
            btnDersProgrami.UseVisualStyleBackColor = true;
            btnDersProgrami.Click += button2_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikisYap.Location = new Point(903, 653);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(230, 80);
            btnCikisYap.TabIndex = 6;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = true;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1192, 793);
            Controls.Add(btnCikisYap);
            Controls.Add(btnDersProgrami);
            Controls.Add(programIslemleri);
            Controls.Add(btnEgitmenİslemleri);
            Controls.Add(btnOgrenciIslemleri);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "AnaMenu";
            Text = "AnaMenu";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOgrenciIslemleri;
        private Button btnEgitmenİslemleri;
        private Button programIslemleri;
        private Button btnDersProgrami;
        private Button btnCikisYap;
    }
}