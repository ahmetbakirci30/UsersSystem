using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {

            InitializeComponent();

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {

            string kullanıcıAdı = txtBoxKullaniciAdi.Text;

            string şifre = txtBoxSifre.Text;

            if (string.IsNullOrEmpty(kullanıcıAdı) || string.IsNullOrEmpty(şifre) || kullanıcıAdı.Equals("Enter Your Username...") || şifre.Equals("Enter Your Password..."))
            {

                MessageBox.Show("Kullanıcı adı veya şifresi boş girilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }

            List<User> users = User.KullaniciBilgileriOku();

            foreach (User user in users)
            {

                if (user.kullaniciAdi.Equals(txtBoxKullaniciAdi.Text) && user.sifre.Equals(txtBoxSifre.Text))
                {

                    Hide();

                    WelcomeForm welcome = new WelcomeForm();

                    welcome.Show();

                    return;

                }

            }

            MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnYeniKullanici_Click(object sender, EventArgs e)
        {

            NewUserAddForm user = new NewUserAddForm();

            user.ShowDialog();

        }

        private void TxtBoxKullaniciAdi_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxKullaniciAdi.Text))
            {

                txtBoxKullaniciAdi.ForeColor = Color.Silver;

                txtBoxKullaniciAdi.Text = "Enter Your Username...";

            }

        }

        private void TxtBoxKullaniciAdi_Enter(object sender, EventArgs e)
        {

            if (txtBoxKullaniciAdi.Text.Equals("Enter Your Username..."))
            {

                txtBoxKullaniciAdi.Clear();

                txtBoxKullaniciAdi.ForeColor = Color.Black;

            }

        }

        private void TxtBoxSifre_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBoxSifre.Text))
            {

                txtBoxSifre.ForeColor = Color.Silver;

                txtBoxSifre.Text = "Enter Your Password...";

            }

        }

        private void TxtBoxSifre_Enter(object sender, EventArgs e)
        {

            if (txtBoxSifre.Text.Equals("Enter Your Password..."))
            {

                txtBoxSifre.Clear();

                txtBoxSifre.ForeColor = Color.Black;

            }

        }

    }

}