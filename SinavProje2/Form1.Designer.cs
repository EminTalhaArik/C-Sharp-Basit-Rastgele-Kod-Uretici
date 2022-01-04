
namespace SinavProje2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rButonSayi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRakamSayisi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHarfSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rButtonHarf = new System.Windows.Forms.RadioButton();
            this.rButtonHarfSayi = new System.Windows.Forms.RadioButton();
            this.lblKod = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rButtonHarfSayi);
            this.groupBox1.Controls.Add(this.rButtonHarf);
            this.groupBox1.Controls.Add(this.txtHarfSayisi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtRakamSayisi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rButonSayi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rButonSayi
            // 
            this.rButonSayi.AutoSize = true;
            this.rButonSayi.Location = new System.Drawing.Point(6, 44);
            this.rButonSayi.Name = "rButonSayi";
            this.rButonSayi.Size = new System.Drawing.Size(45, 17);
            this.rButonSayi.TabIndex = 0;
            this.rButonSayi.TabStop = true;
            this.rButonSayi.Text = "Sayı";
            this.rButonSayi.UseVisualStyleBackColor = true;
            this.rButonSayi.CheckedChanged += new System.EventHandler(this.rButonSayi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rakam sayısı : ";
            // 
            // txtRakamSayisi
            // 
            this.txtRakamSayisi.Enabled = false;
            this.txtRakamSayisi.Location = new System.Drawing.Point(163, 102);
            this.txtRakamSayisi.Name = "txtRakamSayisi";
            this.txtRakamSayisi.Size = new System.Drawing.Size(59, 20);
            this.txtRakamSayisi.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kod Üret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHarfSayisi
            // 
            this.txtHarfSayisi.Enabled = false;
            this.txtHarfSayisi.Location = new System.Drawing.Point(163, 76);
            this.txtHarfSayisi.Name = "txtHarfSayisi";
            this.txtHarfSayisi.Size = new System.Drawing.Size(59, 20);
            this.txtHarfSayisi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harf Sayısı : ";
            // 
            // rButtonHarf
            // 
            this.rButtonHarf.AutoSize = true;
            this.rButtonHarf.Location = new System.Drawing.Point(128, 44);
            this.rButtonHarf.Name = "rButtonHarf";
            this.rButtonHarf.Size = new System.Drawing.Size(45, 17);
            this.rButtonHarf.TabIndex = 6;
            this.rButtonHarf.TabStop = true;
            this.rButtonHarf.Text = "Harf";
            this.rButtonHarf.UseVisualStyleBackColor = true;
            this.rButtonHarf.CheckedChanged += new System.EventHandler(this.rButtonHarf_CheckedChanged);
            // 
            // rButtonHarfSayi
            // 
            this.rButtonHarfSayi.AutoSize = true;
            this.rButtonHarfSayi.Location = new System.Drawing.Point(248, 44);
            this.rButtonHarfSayi.Name = "rButtonHarfSayi";
            this.rButtonHarfSayi.Size = new System.Drawing.Size(68, 17);
            this.rButtonHarfSayi.TabIndex = 7;
            this.rButtonHarfSayi.TabStop = true;
            this.rButtonHarfSayi.Text = "Harf-Sayi";
            this.rButtonHarfSayi.UseVisualStyleBackColor = true;
            this.rButtonHarfSayi.CheckedChanged += new System.EventHandler(this.rButtonHarfSayi_CheckedChanged);
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.Location = new System.Drawing.Point(106, 243);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(133, 24);
            this.lblKod.TabIndex = 8;
            this.lblKod.Text = "Rakam sayısı : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 308);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Rastgele Kod Üretici";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rButtonHarfSayi;
        private System.Windows.Forms.RadioButton rButtonHarf;
        private System.Windows.Forms.TextBox txtHarfSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRakamSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rButonSayi;
        private System.Windows.Forms.Label lblKod;
    }
}

