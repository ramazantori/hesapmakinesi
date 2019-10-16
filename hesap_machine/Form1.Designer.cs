namespace hesap_machine
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
            this.lbl_sayi1 = new System.Windows.Forms.Label();
            this.lbl_sayi2 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.text_sayi1 = new System.Windows.Forms.TextBox();
            this.text_sayi2 = new System.Windows.Forms.TextBox();
            this.text_sonuc = new System.Windows.Forms.TextBox();
            this.bttn_böl = new System.Windows.Forms.Button();
            this.bttn_carpi = new System.Windows.Forms.Button();
            this.bttn_eksi = new System.Windows.Forms.Button();
            this.bttn_arti = new System.Windows.Forms.Button();
            this.bttn_temizle = new System.Windows.Forms.Button();
            this.bttn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_sayi1
            // 
            this.lbl_sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayi1.ForeColor = System.Drawing.Color.Black;
            this.lbl_sayi1.Location = new System.Drawing.Point(12, 23);
            this.lbl_sayi1.Name = "lbl_sayi1";
            this.lbl_sayi1.Size = new System.Drawing.Size(75, 38);
            this.lbl_sayi1.TabIndex = 0;
            this.lbl_sayi1.Text = "Sayi 1=";
            this.lbl_sayi1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_sayi2
            // 
            this.lbl_sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sayi2.ForeColor = System.Drawing.Color.Black;
            this.lbl_sayi2.Location = new System.Drawing.Point(12, 64);
            this.lbl_sayi2.Name = "lbl_sayi2";
            this.lbl_sayi2.Size = new System.Drawing.Size(75, 38);
            this.lbl_sayi2.TabIndex = 0;
            this.lbl_sayi2.Text = "Sayi 2=";
            this.lbl_sayi2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.ForeColor = System.Drawing.Color.Black;
            this.lbl_sonuc.Location = new System.Drawing.Point(12, 117);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(75, 38);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = "Sonuç=";
            this.lbl_sonuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_sayi1
            // 
            this.text_sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_sayi1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_sayi1.Location = new System.Drawing.Point(93, 23);
            this.text_sayi1.Multiline = true;
            this.text_sayi1.Name = "text_sayi1";
            this.text_sayi1.Size = new System.Drawing.Size(100, 38);
            this.text_sayi1.TabIndex = 0;
            this.text_sayi1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_sayi2
            // 
            this.text_sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_sayi2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_sayi2.Location = new System.Drawing.Point(93, 64);
            this.text_sayi2.Multiline = true;
            this.text_sayi2.Name = "text_sayi2";
            this.text_sayi2.Size = new System.Drawing.Size(100, 38);
            this.text_sayi2.TabIndex = 2;
            this.text_sayi2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_sonuc
            // 
            this.text_sonuc.BackColor = System.Drawing.Color.White;
            this.text_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_sonuc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_sonuc.Location = new System.Drawing.Point(93, 117);
            this.text_sonuc.Multiline = true;
            this.text_sonuc.Name = "text_sonuc";
            this.text_sonuc.ReadOnly = true;
            this.text_sonuc.Size = new System.Drawing.Size(100, 38);
            this.text_sonuc.TabIndex = 9;
            this.text_sonuc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bttn_böl
            // 
            this.bttn_böl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_böl.Location = new System.Drawing.Point(211, 168);
            this.bttn_böl.Name = "bttn_böl";
            this.bttn_böl.Size = new System.Drawing.Size(59, 52);
            this.bttn_böl.TabIndex = 6;
            this.bttn_böl.Text = "/";
            this.bttn_böl.UseVisualStyleBackColor = true;
            this.bttn_böl.Click += new System.EventHandler(this.bttn_böl_Click);
            // 
            // bttn_carpi
            // 
            this.bttn_carpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_carpi.Location = new System.Drawing.Point(146, 168);
            this.bttn_carpi.Name = "bttn_carpi";
            this.bttn_carpi.Size = new System.Drawing.Size(59, 52);
            this.bttn_carpi.TabIndex = 5;
            this.bttn_carpi.Text = "*";
            this.bttn_carpi.UseVisualStyleBackColor = true;
            this.bttn_carpi.Click += new System.EventHandler(this.bttn_carpi_Click);
            // 
            // bttn_eksi
            // 
            this.bttn_eksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_eksi.Location = new System.Drawing.Point(81, 168);
            this.bttn_eksi.Name = "bttn_eksi";
            this.bttn_eksi.Size = new System.Drawing.Size(59, 52);
            this.bttn_eksi.TabIndex = 4;
            this.bttn_eksi.Text = "-";
            this.bttn_eksi.UseVisualStyleBackColor = true;
            this.bttn_eksi.Click += new System.EventHandler(this.bttn_eksi_Click);
            // 
            // bttn_arti
            // 
            this.bttn_arti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_arti.Location = new System.Drawing.Point(16, 168);
            this.bttn_arti.Name = "bttn_arti";
            this.bttn_arti.Size = new System.Drawing.Size(59, 52);
            this.bttn_arti.TabIndex = 3;
            this.bttn_arti.Text = "+";
            this.bttn_arti.UseVisualStyleBackColor = true;
            this.bttn_arti.Click += new System.EventHandler(this.bttn_arti_Click);
            // 
            // bttn_temizle
            // 
            this.bttn_temizle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bttn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_temizle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttn_temizle.Location = new System.Drawing.Point(211, 93);
            this.bttn_temizle.Name = "bttn_temizle";
            this.bttn_temizle.Size = new System.Drawing.Size(59, 52);
            this.bttn_temizle.TabIndex = 7;
            this.bttn_temizle.Text = "C";
            this.bttn_temizle.UseVisualStyleBackColor = false;
            this.bttn_temizle.Click += new System.EventHandler(this.bttn_temizle_Click);
            // 
            // bttn_cikis
            // 
            this.bttn_cikis.BackColor = System.Drawing.Color.Red;
            this.bttn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_cikis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttn_cikis.Location = new System.Drawing.Point(211, 23);
            this.bttn_cikis.Name = "bttn_cikis";
            this.bttn_cikis.Size = new System.Drawing.Size(59, 52);
            this.bttn_cikis.TabIndex = 8;
            this.bttn_cikis.Text = "X";
            this.bttn_cikis.UseVisualStyleBackColor = false;
            this.bttn_cikis.Click += new System.EventHandler(this.bttn_cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 237);
            this.Controls.Add(this.bttn_arti);
            this.Controls.Add(this.bttn_eksi);
            this.Controls.Add(this.bttn_carpi);
            this.Controls.Add(this.bttn_cikis);
            this.Controls.Add(this.bttn_temizle);
            this.Controls.Add(this.bttn_böl);
            this.Controls.Add(this.text_sonuc);
            this.Controls.Add(this.text_sayi2);
            this.Controls.Add(this.text_sayi1);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_sayi2);
            this.Controls.Add(this.lbl_sayi1);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sayi1;
        private System.Windows.Forms.Label lbl_sayi2;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.TextBox text_sayi1;
        private System.Windows.Forms.TextBox text_sayi2;
        private System.Windows.Forms.TextBox text_sonuc;
        private System.Windows.Forms.Button bttn_böl;
        private System.Windows.Forms.Button bttn_carpi;
        private System.Windows.Forms.Button bttn_eksi;
        private System.Windows.Forms.Button bttn_arti;
        private System.Windows.Forms.Button bttn_temizle;
        private System.Windows.Forms.Button bttn_cikis;
    }
}

