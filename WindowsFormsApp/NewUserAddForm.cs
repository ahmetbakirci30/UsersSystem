using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{

    public partial class NewUserAddForm : Form
    {

        public NewUserAddForm()
        {

            InitializeComponent();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxKullaniciAdi.Text) || string.IsNullOrEmpty(txtBoxSifre.Text)

            || txtBoxKullaniciAdi.Text.Equals("Username...") || txtBoxSifre.Text.Equals("Password..."))

                MessageBox.Show("Kullanıcı adı veya şifresi boş girilemez!");

            else
            {
                string ad = txtBoxAd.Text;

                string soyad = txtBoxSoyad.Text;

                string kullaniciAdi = txtBoxKullaniciAdi.Text;

                string sifre = txtBoxSifre.Text;

                string e_posta = txtBoxPosta.Text;

                User us = new User(ad, soyad, e_posta, kullaniciAdi, sifre);

                User.KullaniciEkle(us);

                MessageBox.Show("Bilgileriniz başarıyla kaydedildi!! \nGiriş ekranından giriş yapabilirsiniz");

                Close();

            }

        }
        void TxtBoxs()
        {

            txtBoxAd.Text = "First Name...";

            txtBoxSoyad.Text = "Last Name...";

            txtBoxKullaniciAdi.Text = "Username...";

            txtBoxSifre.Text = "Password...";

            txtBoxPosta.Text = "Email...";

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void TxtBoxAd_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxAd.Text))
            {

                txtBoxAd.ForeColor = Color.Silver;

                txtBoxAd.Text = "First Name...";

            }

        }

        private void TxtBoxSoyad_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxSoyad.Text))
            {

                txtBoxSoyad.ForeColor = Color.Silver;

                txtBoxSoyad.Text = "Last Name...";

            }

        }

        private void TxtBoxKullaniciAdi_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxKullaniciAdi.Text))
            {

                txtBoxKullaniciAdi.ForeColor = Color.Silver;

                txtBoxKullaniciAdi.Text = "Username...";

            }

        }

        private void TxtBoxSifre_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxSifre.Text))
            {

                txtBoxSifre.ForeColor = Color.Silver;

                txtBoxSifre.Text = "Password...";

            }

        }

        private void TxtBoxPosta_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxPosta.Text))
            {

                txtBoxPosta.ForeColor = Color.Silver;

                txtBoxPosta.Text = "Email...";

            }

        }

        private void TxtBoxAd_Enter(object sender, EventArgs e)
        {

            if(txtBoxAd.Text.Equals("First Name..."))
            {

                txtBoxAd.Text = string.Empty;

                txtBoxAd.ForeColor = Color.Black;

            }

        }

        private void TxtBoxSoyad_Enter(object sender, EventArgs e)
        {

            if (txtBoxSoyad.Text.Equals("Last Name..."))
            {

                txtBoxSoyad.Text = string.Empty;

                txtBoxSoyad.ForeColor = Color.Black;

            }

        }

        private void TxtBoxKullaniciAdi_Enter(object sender, EventArgs e)
        {

            if (txtBoxKullaniciAdi.Text.Equals("Username..."))
            {

                txtBoxKullaniciAdi.Text = string.Empty;

                txtBoxKullaniciAdi.ForeColor = Color.Black;

            }

        }

        private void TxtBoxSifre_Enter(object sender, EventArgs e)
        {

            if (txtBoxSifre.Text.Equals("Password..."))
            {

                txtBoxSifre.Text = string.Empty;

                txtBoxSifre.ForeColor = Color.Black;

            }

        }

        private void TxtBoxPosta_Enter(object sender, EventArgs e)
        {

            if (txtBoxPosta.Text.Equals("Email..."))
            {

                txtBoxPosta.Text = string.Empty;

                txtBoxPosta.ForeColor = Color.Black;

            }

        }

        private void NewUserAddForm_Load(object sender, EventArgs e)
        {

            TxtBoxs();

        }
    }

}