namespace WindowsFormsApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnYeniKullanici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSifre.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxSifre.Location = new System.Drawing.Point(50, 169);
            this.txtBoxSifre.Multiline = true;
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(503, 50);
            this.txtBoxSifre.TabIndex = 1;
            this.txtBoxSifre.Text = "Enter Your Password...";
            this.txtBoxSifre.UseSystemPasswordChar = true;
            this.txtBoxSifre.Enter += new System.EventHandler(this.TxtBoxSifre_Enter);
            this.txtBoxSifre.Leave += new System.EventHandler(this.TxtBoxSifre_Leave);
            // 
            // txtBoxKullaniciAdi
            // 
            this.txtBoxKullaniciAdi.AccessibleDescription = "asda";
            this.txtBoxKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKullaniciAdi.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxKullaniciAdi.Location = new System.Drawing.Point(50, 75);
            this.txtBoxKullaniciAdi.Multiline = true;
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Size = new System.Drawing.Size(503, 51);
            this.txtBoxKullaniciAdi.TabIndex = 2;
            this.txtBoxKullaniciAdi.Text = "Enter Your Username...";
            this.txtBoxKullaniciAdi.Enter += new System.EventHandler(this.TxtBoxKullaniciAdi_Enter);
            this.txtBoxKullaniciAdi.Leave += new System.EventHandler(this.TxtBoxKullaniciAdi_Leave);
            // 
            // BtnGiris
            // 
            this.BtnGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGiris.BackColor = System.Drawing.Color.White;
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.ForeColor = System.Drawing.Color.SlateBlue;
            this.BtnGiris.Location = new System.Drawing.Point(417, 263);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(136, 53);
            this.BtnGiris.TabIndex = 6;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnYeniKullanici
            // 
            this.BtnYeniKullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnYeniKullanici.BackColor = System.Drawing.Color.White;
            this.BtnYeniKullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYeniKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniKullanici.ForeColor = System.Drawing.Color.SlateBlue;
            this.BtnYeniKullanici.Location = new System.Drawing.Point(50, 263);
            this.BtnYeniKullanici.Name = "BtnYeniKullanici";
            this.BtnYeniKullanici.Size = new System.Drawing.Size(136, 53);
            this.BtnYeniKullanici.TabIndex = 7;
            this.BtnYeniKullanici.Text = "Yeni";
            this.BtnYeniKullanici.UseVisualStyleBackColor = false;
            this.BtnYeniKullanici.Click += new System.EventHandler(this.BtnYeniKullanici_Click);
            // 
            // LoginForm
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 354);
            this.Controls.Add(this.BtnYeniKullanici);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.txtBoxKullaniciAdi);
            this.Controls.Add(this.txtBoxSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.Button BtnYeniKullanici;
        private System.Windows.Forms.Button BtnGiris;
    }
}

