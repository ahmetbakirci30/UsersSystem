using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApp
{

    class User
    {

        public string ad, soyad, e_posta, kullaniciAdi, sifre;

        public User(string ad, string soyad, string e_posta, string kullaniciAdi, string sifre)
        {

            this.ad = ad;

            this.soyad = soyad;

            this.e_posta = e_posta;

            this.kullaniciAdi = kullaniciAdi;

            this.sifre = sifre;

        }

        static readonly string path = "Kullanıcı Bilgileri.txt";

        public static void KullaniciEkle(List<User> userList)
        {

            StreamWriter sw = new StreamWriter(path, true);

            foreach (User user in userList)
            {

                string[] kullanicilar = { user.ad, user.soyad, user.e_posta, user.kullaniciAdi, user.sifre };

                sw.WriteLine(string.Join(";", kullanicilar));

            }

            sw.Close();

        }
        public static void KullaniciEkle(User user)
        {

            StreamWriter sw = new StreamWriter(path, true);

            string[] kullanicilar = { user.ad, user.soyad, user.e_posta, user.kullaniciAdi, user.sifre };

            sw.WriteLine(string.Join(";", kullanicilar));

            sw.Close();

        }

        public static List<User> KullaniciBilgileriOku()
        {
            List<User> Users = new List<User>();

            if (File.Exists(path))
            {

                StreamReader sr = new StreamReader(path);

                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();

                    string[] values = line.Split(';');

                    User user = new User(values[0], values[1], values[2], values[3], values[4]);

                    Users.Add(user);

                }

                sr.Close();

            }

            return Users;

        }

    }

}