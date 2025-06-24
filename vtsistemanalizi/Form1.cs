using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtsistemanalizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "Fatih" && txtSifre.Text == "1234")
            {
                this.Hide();
                Form2 EmlakKayit = new Form2();
                EmlakKayit.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Hatalı Tekrar Deneyiniz!","UYARI!!!");
            }
        }
    }
}
