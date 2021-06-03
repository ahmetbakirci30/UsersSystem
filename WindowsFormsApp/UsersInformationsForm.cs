using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{

    public partial class UsersInformationsForm : Form
    {

        public UsersInformationsForm()
        {

            InitializeComponent();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void UsersInformationsForm_Load(object sender, EventArgs e)
        {

            List<User> users = User.KullaniciBilgileriOku();

            lstViewUsersInformations.Columns.Add("Ad", 129);

            lstViewUsersInformations.Columns.Add("Soyad", 130);

            lstViewUsersInformations.Columns.Add("E-posta", 220);

            lstViewUsersInformations.Columns.Add("Kullanıcı Adı", 150);

            lstViewUsersInformations.Columns.Add("Şifre", 150);

            foreach (User user in users)
            {

                string[] dizi = { user.ad, user.soyad, user.e_posta, user.kullaniciAdi, user.sifre };

                ListViewItem list = new ListViewItem(dizi);

                lstViewUsersInformations.Items.Add(list);

            }

        }

    }

}