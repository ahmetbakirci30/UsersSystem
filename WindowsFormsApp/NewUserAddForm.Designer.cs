namespace WindowsFormsApp
{
    partial class NewUserAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserAddForm));
            this.txtBoxAd = new System.Windows.Forms.TextBox();
            this.txtBoxSoyad = new System.Windows.Forms.TextBox();
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.txtBoxPosta = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxAd
            // 
            resources.ApplyResources(this.txtBoxAd, "txtBoxAd");
            this.txtBoxAd.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxAd.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxAd.Name = "txtBoxAd";
            this.txtBoxAd.Enter += new System.EventHandler(this.TxtBoxAd_Enter);
            this.txtBoxAd.Leave += new System.EventHandler(this.TxtBoxAd_Leave);
            // 
            // txtBoxSoyad
            // 
            resources.ApplyResources(this.txtBoxSoyad, "txtBoxSoyad");
            this.txtBoxSoyad.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxSoyad.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxSoyad.Name = "txtBoxSoyad";
            this.txtBoxSoyad.Enter += new System.EventHandler(this.TxtBoxSoyad_Enter);
            this.txtBoxSoyad.Leave += new System.EventHandler(this.TxtBoxSoyad_Leave);
            // 
            // txtBoxKullaniciAdi
            // 
            resources.ApplyResources(this.txtBoxKullaniciAdi, "txtBoxKullaniciAdi");
            this.txtBoxKullaniciAdi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxKullaniciAdi.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Enter += new System.EventHandler(this.TxtBoxKullaniciAdi_Enter);
            this.txtBoxKullaniciAdi.Leave += new System.EventHandler(this.TxtBoxKullaniciAdi_Leave);
            // 
            // txtBoxSifre
            // 
            resources.ApplyResources(this.txtBoxSifre, "txtBoxSifre");
            this.txtBoxSifre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxSifre.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Enter += new System.EventHandler(this.TxtBoxSifre_Enter);
            this.txtBoxSifre.Leave += new System.EventHandler(this.TxtBoxSifre_Leave);
            // 
            // txtBoxPosta
            // 
            resources.ApplyResources(this.txtBoxPosta, "txtBoxPosta");
            this.txtBoxPosta.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxPosta.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPosta.Name = "txtBoxPosta";
            this.txtBoxPosta.Enter += new System.EventHandler(this.TxtBoxPosta_Enter);
            this.txtBoxPosta.Leave += new System.EventHandler(this.TxtBoxPosta_Leave);
            // 
            // BtnSave
            // 
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.ForeColor = System.Drawing.Color.Blue;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            resources.ApplyResources(this.BtnClose, "BtnClose");
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.ForeColor = System.Drawing.Color.Blue;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // NewUserAddForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtBoxPosta);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.txtBoxKullaniciAdi);
            this.Controls.Add(this.txtBoxSoyad);
            this.Controls.Add(this.txtBoxAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserAddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.NewUserAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxAd;
        private System.Windows.Forms.TextBox txtBoxSoyad;
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.TextBox txtBoxPosta;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
    }
}