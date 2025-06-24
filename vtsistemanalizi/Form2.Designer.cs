
namespace vtsistemanalizi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSemt = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.cmbOda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMetrekare = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBlok = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDaire = new System.Windows.Forms.TextBox();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCandar = new System.Windows.Forms.Button();
            this.btnKuzeykent = new System.Windows.Forms.Button();
            this.btnOlukbasi = new System.Windows.Forms.Button();
            this.btnCarsi = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkSemt = new System.Windows.Forms.CheckBox();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.chkOda = new System.Windows.Forms.CheckBox();
            this.btnDurum = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAYRİMENKUL BİLGİLERİ";
            // 
            // cmbSemt
            // 
            this.cmbSemt.FormattingEnabled = true;
            this.cmbSemt.Items.AddRange(new object[] {
            "Candarogullari",
            "Kuzeykent",
            "Çarsi",
            "Olukbasi"});
            this.cmbSemt.Location = new System.Drawing.Point(206, 130);
            this.cmbSemt.Name = "cmbSemt";
            this.cmbSemt.Size = new System.Drawing.Size(154, 33);
            this.cmbSemt.TabIndex = 2;
            this.cmbSemt.Text = "SEÇİNİZ";
            this.cmbSemt.SelectedIndexChanged += new System.EventHandler(this.cmbSemt_SelectedIndexChanged);
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.cmbDurum.Location = new System.Drawing.Point(206, 189);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(154, 33);
            this.cmbDurum.TabIndex = 4;
            this.cmbDurum.Text = "SEÇİNİZ";
            // 
            // cmbOda
            // 
            this.cmbOda.FormattingEnabled = true;
            this.cmbOda.Items.AddRange(new object[] {
            "1+0",
            "1+1",
            "2+1",
            "3+1",
            "4+1"});
            this.cmbOda.Location = new System.Drawing.Point(206, 255);
            this.cmbOda.Name = "cmbOda";
            this.cmbOda.Size = new System.Drawing.Size(154, 33);
            this.cmbOda.TabIndex = 6;
            this.cmbOda.Text = "SEÇİNİZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "METREKARE:";
            // 
            // txtMetrekare
            // 
            this.txtMetrekare.Location = new System.Drawing.Point(206, 327);
            this.txtMetrekare.Name = "txtMetrekare";
            this.txtMetrekare.Size = new System.Drawing.Size(154, 30);
            this.txtMetrekare.TabIndex = 8;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(206, 383);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(154, 30);
            this.txtFiyat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "FİYAT:";
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(811, 318);
            this.txtEkstra.Multiline = true;
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(154, 156);
            this.txtEkstra.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(619, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "EKSTRA BİLGİ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(665, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 39);
            this.label8.TabIndex = 13;
            this.label8.Text = "İLETİŞİM BİLGİLERİ";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(811, 130);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(154, 30);
            this.txtAdSoyad.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(619, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "AD SOYAD:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(811, 189);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(154, 30);
            this.txtTelefon.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(619, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "TELEFON:";
            // 
            // cmbBlok
            // 
            this.cmbBlok.FormattingEnabled = true;
            this.cmbBlok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbBlok.Location = new System.Drawing.Point(104, 444);
            this.cmbBlok.Name = "cmbBlok";
            this.cmbBlok.Size = new System.Drawing.Size(72, 33);
            this.cmbBlok.TabIndex = 19;
            this.cmbBlok.Text = "SEÇ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "BLOK:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(201, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "DAİRE:";
            // 
            // txtDaire
            // 
            this.txtDaire.Location = new System.Drawing.Point(290, 444);
            this.txtDaire.Name = "txtDaire";
            this.txtDaire.Size = new System.Drawing.Size(70, 30);
            this.txtDaire.TabIndex = 21;
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(811, 255);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(154, 30);
            this.txtEPosta.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(619, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "E-POSTA:";
            // 
            // btnCandar
            // 
            this.btnCandar.BackColor = System.Drawing.Color.Chocolate;
            this.btnCandar.Location = new System.Drawing.Point(1188, 130);
            this.btnCandar.Name = "btnCandar";
            this.btnCandar.Size = new System.Drawing.Size(167, 68);
            this.btnCandar.TabIndex = 24;
            this.btnCandar.Text = "Candaroğulları";
            this.btnCandar.UseVisualStyleBackColor = false;
            // 
            // btnKuzeykent
            // 
            this.btnKuzeykent.BackColor = System.Drawing.Color.Chocolate;
            this.btnKuzeykent.Location = new System.Drawing.Point(1024, 204);
            this.btnKuzeykent.Name = "btnKuzeykent";
            this.btnKuzeykent.Size = new System.Drawing.Size(167, 68);
            this.btnKuzeykent.TabIndex = 24;
            this.btnKuzeykent.Text = "Kuzeykent";
            this.btnKuzeykent.UseVisualStyleBackColor = false;
            // 
            // btnOlukbasi
            // 
            this.btnOlukbasi.BackColor = System.Drawing.Color.Chocolate;
            this.btnOlukbasi.Location = new System.Drawing.Point(1352, 204);
            this.btnOlukbasi.Name = "btnOlukbasi";
            this.btnOlukbasi.Size = new System.Drawing.Size(167, 68);
            this.btnOlukbasi.TabIndex = 24;
            this.btnOlukbasi.Text = "Olukbaşı";
            this.btnOlukbasi.UseVisualStyleBackColor = false;
            // 
            // btnCarsi
            // 
            this.btnCarsi.BackColor = System.Drawing.Color.Chocolate;
            this.btnCarsi.Location = new System.Drawing.Point(1188, 278);
            this.btnCarsi.Name = "btnCarsi";
            this.btnCarsi.Size = new System.Drawing.Size(167, 68);
            this.btnCarsi.TabIndex = 24;
            this.btnCarsi.Text = "Çarşı";
            this.btnCarsi.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.Info;
            this.label14.Location = new System.Drawing.Point(1197, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "FATİH EMLAK";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 534);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1501, 157);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(226, 485);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(178, 43);
            this.btnYeni.TabIndex = 27;
            this.btnYeni.Text = "YENİ KAYIT";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(421, 485);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(178, 43);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "KAYIT SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(624, 485);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(195, 43);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "KAYIT GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(31, 485);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(178, 43);
            this.btnGoruntule.TabIndex = 27;
            this.btnGoruntule.Text = "KAYIT GÖR";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "SEMTE GÖRE ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkSemt
            // 
            this.chkSemt.AutoSize = true;
            this.chkSemt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSemt.Location = new System.Drawing.Point(12, 134);
            this.chkSemt.Name = "chkSemt";
            this.chkSemt.Size = new System.Drawing.Size(180, 24);
            this.chkSemt.TabIndex = 29;
            this.chkSemt.Text = "SEMT/MAHALLE:";
            this.chkSemt.UseVisualStyleBackColor = true;
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDurum.Location = new System.Drawing.Point(12, 195);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(118, 29);
            this.chkDurum.TabIndex = 29;
            this.chkDurum.Text = "DURUM:";
            this.chkDurum.UseVisualStyleBackColor = true;
            // 
            // chkOda
            // 
            this.chkOda.AutoSize = true;
            this.chkOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOda.Location = new System.Drawing.Point(12, 261);
            this.chkOda.Name = "chkOda";
            this.chkOda.Size = new System.Drawing.Size(88, 29);
            this.chkOda.TabIndex = 29;
            this.chkOda.Text = "ODA:";
            this.chkOda.UseVisualStyleBackColor = true;
            // 
            // btnDurum
            // 
            this.btnDurum.Location = new System.Drawing.Point(1057, 485);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(219, 43);
            this.btnDurum.TabIndex = 30;
            this.btnDurum.Text = "DURUMA GÖRE ARA";
            this.btnDurum.UseVisualStyleBackColor = true;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1282, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 43);
            this.button2.TabIndex = 31;
            this.button2.Text = "ODAYA GÖRE ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1525, 703);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDurum);
            this.Controls.Add(this.chkOda);
            this.Controls.Add(this.chkDurum);
            this.Controls.Add(this.chkSemt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCarsi);
            this.Controls.Add(this.btnOlukbasi);
            this.Controls.Add(this.btnKuzeykent);
            this.Controls.Add(this.btnCandar);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDaire);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbBlok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMetrekare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOda);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.cmbSemt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAYRIMENKUL BİLGİ EKRANI";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSemt;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbOda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMetrekare;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBlok;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDaire;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCandar;
        private System.Windows.Forms.Button btnKuzeykent;
        private System.Windows.Forms.Button btnOlukbasi;
        private System.Windows.Forms.Button btnCarsi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkSemt;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.CheckBox chkOda;
        private System.Windows.Forms.Button btnDurum;
        private System.Windows.Forms.Button button2;
    }
}