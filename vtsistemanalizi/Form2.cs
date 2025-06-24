using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vtsistemanalizi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void KayitlariYenile()
        {
            Form2.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Siteler", Form2.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Form2.Baglanti.Close();
        }

        public static SqlConnection Baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=vtsistemanalizi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public static void BaglantiAc()
        {
            try
            {
                //veritabanı bağlantısını kontrollü olarak aç.
                if (Baglanti.State == ConnectionState.Closed)
                    Baglanti.Open();
            }
            catch (Exception Hata)
            {
                //sistem hata mesajını yakala
                MessageBox.Show(Hata.Message, "Bağlantı Aç Hata Penceresi");

            }
        }

        public void KayitListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * From Siteler";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Siteler");
                dataGridView1.DataSource = ds.Tables["Siteler"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        public void KayitEkle()
        {
            try
            {
                Form2.BaglantiAc();
                string Sorgu = "Insert Into Siteler (Semt,Durum,Oda,Metre,Fiyat,Blok,Daire,AdSoyad,Telefon,EPosta,Ekstra)Values (@Semt,@Durum,@Oda,@Metre,@Fiyat,@Blok,@Daire,@AdSoyad,@Telefon,@EPosta,@Ekstra)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Form2.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Semt", cmbSemt.Text);
                EkleKomut.Parameters.AddWithValue("@Durum", cmbDurum.Text);
                EkleKomut.Parameters.AddWithValue("@Oda", cmbOda.Text);
                EkleKomut.Parameters.AddWithValue("@Metre", txtMetrekare.Text);
                EkleKomut.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                EkleKomut.Parameters.AddWithValue("@Blok", cmbBlok.Text);
                EkleKomut.Parameters.AddWithValue("@Daire", txtDaire.Text);
                EkleKomut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                EkleKomut.Parameters.AddWithValue("@EPosta", txtEPosta.Text);
                EkleKomut.Parameters.AddWithValue("@Ekstra", txtEkstra.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                    
                Form2.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");

            }

        }

        public void KayitSil()
        {
            try
            {
                Form2.BaglantiAc(); // Bağlantı açma fonksiyonun doğruysa bu kalsın

                string sorgu = "DELETE FROM Siteler WHERE AdSoyad = @AdSoyad";
                SqlCommand SilKomut = new SqlCommand(sorgu, Form2.Baglanti);
                SilKomut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);

                int sonuc = SilKomut.ExecuteNonQuery();

                if (sonuc > 0)
                    MessageBox.Show(txtAdSoyad.Text + " kişisine ait kayıt silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Silinecek kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Form2.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");
            }
        }


        public void KayitDegistir()
        {
            try
            {
                Form2.BaglantiAc();

                string Sorgu = "UPDATE Siteler SET Semt=@Semt, Durum=@Durum, Oda=@Oda, Metre=@Metre, Fiyat=@Fiyat, Blok=@Blok, Daire=@Daire, AdSoyad=@AdSoyad, Telefon=@Telefon, EPosta=@EPosta, Ekstra=@Ekstra WHERE AdSoyad=@AdSoyad";
                SqlCommand DegistirKomut = new SqlCommand(Sorgu, Form2.Baglanti);

                // Parametreler
                DegistirKomut.Parameters.AddWithValue("@Semt", cmbSemt.Text);
                DegistirKomut.Parameters.AddWithValue("@Durum", cmbDurum.Text);
                DegistirKomut.Parameters.AddWithValue("@Oda", cmbOda.Text);
                DegistirKomut.Parameters.AddWithValue("@Metre", txtMetrekare.Text);
                DegistirKomut.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                DegistirKomut.Parameters.AddWithValue("@Blok", cmbBlok.Text);
                DegistirKomut.Parameters.AddWithValue("@Daire", txtDaire.Text);
                DegistirKomut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                DegistirKomut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                DegistirKomut.Parameters.AddWithValue("@EPosta", txtEPosta.Text);
                DegistirKomut.Parameters.AddWithValue("@Ekstra", txtEkstra.Text);


                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Güncellenecek kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Form2.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Değiştir Hata Penceresi");
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false;
            cmbSemt.BackColor = Color.White;
            cmbDurum.BackColor = Color.White;
            cmbOda.BackColor = Color.White;
            txtMetrekare.BackColor = Color.White;
            txtFiyat.BackColor = Color.White;
            cmbBlok.BackColor = Color.White;
            txtDaire.BackColor = Color.White;
            txtAdSoyad.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            txtEPosta.BackColor = Color.White;
            txtEkstra.BackColor = Color.White;



            if (cmbSemt.Text == "" || cmbSemt.Text == "SEÇİNİZ")
            {
                cmbSemt.BackColor = Color.Red;
                cmbSemt.Focus();
                bos = true;
            }
            if (cmbDurum.Text == "" || cmbDurum.Text == "SEÇİNİZ")
            {
                cmbDurum.BackColor = Color.Red;
                cmbDurum.Focus();
                bos = true;
            }
            if (cmbOda.Text == "" || cmbOda.Text == "SEÇİNİZ")
            {
                cmbOda.BackColor = Color.Red;
                cmbOda.Focus();
                bos = true;
            }
            if (cmbBlok.Text == "" || cmbBlok.Text == "SEÇ")
            {
                cmbBlok.BackColor = Color.Red;
                cmbBlok.Focus();
                bos = true;
            }
            if (txtMetrekare.Text == "")
            {
                txtMetrekare.BackColor = Color.Red;
                txtMetrekare.Focus();
                bos = true;
            }
            if (txtFiyat.Text == "")
            {
                txtFiyat.BackColor = Color.Red;
                txtFiyat.Focus();
                bos = true;
            }
            if (txtDaire.Text == "")
            {
                txtDaire.BackColor = Color.Red;
                txtDaire.Focus();
                bos = true;
            }
            if (txtAdSoyad.Text == "")
            {
                txtAdSoyad.BackColor = Color.Red;
                txtAdSoyad.Focus();
                bos = true;
            }
            if (txtTelefon.Text == "")
            {
                txtTelefon.BackColor = Color.Red;
                txtTelefon.Focus();
                bos = true;
            }
            if (txtEPosta.Text == "")
            {
                txtEPosta.BackColor = Color.Red;
                txtEPosta.Focus();
                bos = true;
            }
            else
            {
                cmbSemt.BackColor = Color.White;
                cmbDurum.BackColor = Color.White;
                cmbOda.BackColor = Color.White;
                txtMetrekare.BackColor = Color.White;
                txtFiyat.BackColor = Color.White;
                cmbBlok.BackColor = Color.White;
                txtDaire.BackColor = Color.White;
                txtAdSoyad.BackColor = Color.White;
                txtTelefon.BackColor = Color.White;
                txtEPosta.BackColor = Color.White;
                txtEkstra.BackColor = Color.White;
            }

            return bos;

        }

        public void SemtAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From Siteler";
                string SorguSemt = "Select * From Siteler where Semt ='" + cmbSemt.Text + "'";

                if (chkSemt.Checked == true)
                   SorguTum = SorguSemt;

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Baglanti);
                da.Fill(ds, "Siteler");
                dataGridView1.DataSource = ds.Tables["Siteler"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Semt Ara Hata Penceresi");
            }
        }

        public void DurumAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From Siteler";
                string SorguDurum = "Select * From Siteler where Durum ='" + cmbDurum.Text + "'";

                if (chkDurum.Checked == true)
                    SorguTum = SorguDurum;

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Baglanti);
                da.Fill(ds, "Siteler");
                dataGridView1.DataSource = ds.Tables["Siteler"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Durum Ara Hata Penceresi");
            }
        }

        public void OdaAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * From Siteler";
                string SorguOda = "Select * From Siteler where Oda ='" + cmbOda.Text + "'";

                if (chkOda.Checked == true)
                    SorguTum = SorguOda;

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Baglanti);
                da.Fill(ds, "Siteler");
                dataGridView1.DataSource = ds.Tables["Siteler"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Oda Ara Hata Penceresi");
            }
        }

        public void BasaAl()
        {
            cmbSemt.Text = "SEÇİNİZ";
            cmbDurum.Text = "SEÇİNİZ";
            cmbOda.Text = "SEÇİNİZ";
            txtMetrekare.Text = "";
            txtFiyat.Text = "";
            cmbBlok.Text = "SEÇ";
            txtDaire.Text = "";
            txtAdSoyad.Text = "";
            txtTelefon.Text = "";
            txtEPosta.Text = "";
            cmbSemt.BackColor = Color.White;
            cmbDurum.BackColor = Color.White;
            cmbOda.BackColor = Color.White;
            txtMetrekare.BackColor = Color.White;
            txtFiyat.BackColor = Color.White;
            cmbBlok.BackColor = Color.White;
            txtDaire.BackColor = Color.White;
            txtAdSoyad.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            txtEPosta.BackColor = Color.White;
            txtEkstra.BackColor = Color.White;
        }

        private void cmbSemt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemt.Text == "Candarogullari")
            {
                btnCandar.BackColor = Color.Gray;
                btnKuzeykent.BackColor = Color.Chocolate;
                btnCarsi.BackColor = Color.Chocolate;
                btnOlukbasi.BackColor = Color.Chocolate;
            }
            if (cmbSemt.Text == "Kuzeykent")
            {
                btnKuzeykent.BackColor = Color.Gray;
                btnCandar.BackColor = Color.Chocolate;
                btnCarsi.BackColor = Color.Chocolate;
                btnOlukbasi.BackColor = Color.Chocolate;
            }
            if (cmbSemt.Text == "Çarsi")
            {
                btnCarsi.BackColor = Color.Gray;
                btnKuzeykent.BackColor = Color.Chocolate;
                btnCandar.BackColor = Color.Chocolate;
                btnOlukbasi.BackColor = Color.Chocolate;
            }
            if (cmbSemt.Text == "Olukbasi")
            {
                btnOlukbasi.BackColor = Color.Gray;
                btnKuzeykent.BackColor = Color.Chocolate;
                btnCarsi.BackColor = Color.Chocolate;
                btnCandar.BackColor = Color.Chocolate;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            KayitListele();
            BasaAl();
            KayitlariYenile();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (cmbSemt.Text == "" || cmbSemt.Text == "SEÇİNİZ")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin Semt Seçiniz");
            }
            else if (cmbDurum.Text == "" || cmbDurum.Text == "SEÇİNİZ")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin Durum Seçiniz");
            }
            else if (cmbOda.Text == "" || cmbOda.Text == "SEÇİNİZ")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin Oda Seçiniz");
            }
            else if (txtMetrekare.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin Metrekare Değeri Giriniz");
            }
            else if (txtFiyat.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin Fiyat Değeri Giriniz");
            }
            else if (cmbBlok.Text == "" || cmbBlok.Text == "SEÇ")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin Blok Seçiniz");
            }
            else if (txtDaire.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin Daire No Giriniz");
            }
            else if (txtAdSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin Ad Soyad Giriniz");
            }
            else if (txtTelefon.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin Telefon Numarası Giriniz");
            }
            else if (txtEPosta.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Eklemek İçin E-Posta Giriniz");
            }
            else
            {
                KayitEkle();
                KayitlariYenile();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KayitSil();
            KayitlariYenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else KayitDegistir();
                 KayitlariYenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eğer istediğiniz sonuçlar çıkmadıysa Semt/Mahalle kısmının başındaki kutucuğu işaretleyiniz!","BİLGİLENDİRME!");
            SemtAra();
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eğer istediğiniz sonuçlar çıkmadıysa Durum kısmının başındaki kutucuğu işaretleyiniz!","BİLGİLENDİRME!");
            DurumAra();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eğer istediğiniz sonuçlar çıkmadıysa Oda kısmının başındaki kutucuğu işaretleyiniz!","BİLGİLENDİRME!");
            OdaAra();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                cmbSemt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cmbDurum.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbOda.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtMetrekare.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtFiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cmbBlok.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtDaire.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtTelefon.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtEPosta.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtEkstra.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }
        }
    }
    }

