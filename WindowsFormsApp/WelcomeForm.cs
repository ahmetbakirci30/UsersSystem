using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace WindowsFormsApp
{

    public partial class WelcomeForm : Form
    {

        public WelcomeForm()
        {

            InitializeComponent();

        }

        void Oynat(string path)
        {

            SoundPlayer sp = new SoundPlayer
            {

                SoundLocation = @path

            };

            sp.Play();

        }

        void SiteAc(string ad)
        {

            Process.Start(ad);

        }

        private void Btn_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            SiteAc(button.Text);

        }

        private void BtnUsersInformationsShow_Click(object sender, EventArgs e)
        {

            UsersInformationsForm form = new UsersInformationsForm();

            form.Show();

        }

        private void Time_Tick(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToString();

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

            Oynat("Sound.wav");

        }

    }

}