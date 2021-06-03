namespace WindowsFormsApp
{
    partial class WelcomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.BtnFacebook = new System.Windows.Forms.Button();
            this.BtnTwitter = new System.Windows.Forms.Button();
            this.BtnWhatsapp = new System.Windows.Forms.Button();
            this.BtnInstagram = new System.Windows.Forms.Button();
            this.BtnGoogle = new System.Windows.Forms.Button();
            this.BtnUnivercity = new System.Windows.Forms.Button();
            this.BtnN11 = new System.Windows.Forms.Button();
            this.BtnDevlet = new System.Windows.Forms.Button();
            this.BtnUsersInformationsShow = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFacebook
            // 
            this.BtnFacebook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFacebook.BackColor = System.Drawing.Color.White;
            this.BtnFacebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFacebook.BackgroundImage")));
            this.BtnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.0001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFacebook.Location = new System.Drawing.Point(12, 19);
            this.BtnFacebook.Name = "BtnFacebook";
            this.BtnFacebook.Size = new System.Drawing.Size(239, 160);
            this.BtnFacebook.TabIndex = 0;
            this.BtnFacebook.Text = "www.facebook.com";
            this.BtnFacebook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFacebook.UseVisualStyleBackColor = false;
            this.BtnFacebook.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnTwitter
            // 
            this.BtnTwitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTwitter.BackColor = System.Drawing.Color.White;
            this.BtnTwitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTwitter.BackgroundImage")));
            this.BtnTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.0001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTwitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnTwitter.Location = new System.Drawing.Point(747, 19);
            this.BtnTwitter.Name = "BtnTwitter";
            this.BtnTwitter.Size = new System.Drawing.Size(239, 160);
            this.BtnTwitter.TabIndex = 2;
            this.BtnTwitter.Text = "www.twitter.com";
            this.BtnTwitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTwitter.UseVisualStyleBackColor = false;
            this.BtnTwitter.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnWhatsapp
            // 
            this.BtnWhatsapp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnWhatsapp.BackColor = System.Drawing.Color.White;
            this.BtnWhatsapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnWhatsapp.BackgroundImage")));
            this.BtnWhatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.0001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnWhatsapp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnWhatsapp.Location = new System.Drawing.Point(502, 19);
            this.BtnWhatsapp.Name = "BtnWhatsapp";
            this.BtnWhatsapp.Size = new System.Drawing.Size(239, 160);
            this.BtnWhatsapp.TabIndex = 3;
            this.BtnWhatsapp.Text = "https://web.whatsapp.com/";
            this.BtnWhatsapp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnWhatsapp.UseVisualStyleBackColor = false;
            this.BtnWhatsapp.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnInstagram
            // 
            this.BtnInstagram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInstagram.BackColor = System.Drawing.Color.White;
            this.BtnInstagram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInstagram.BackgroundImage")));
            this.BtnInstagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.0001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnInstagram.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnInstagram.Location = new System.Drawing.Point(257, 19);
            this.BtnInstagram.Name = "BtnInstagram";
            this.BtnInstagram.Size = new System.Drawing.Size(239, 160);
            this.BtnInstagram.TabIndex = 4;
            this.BtnInstagram.Text = "www.instagram.com";
            this.BtnInstagram.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInstagram.UseVisualStyleBackColor = false;
            this.BtnInstagram.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnGoogle
            // 
            this.BtnGoogle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGoogle.BackColor = System.Drawing.Color.White;
            this.BtnGoogle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGoogle.BackgroundImage")));
            this.BtnGoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.0001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGoogle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnGoogle.Location = new System.Drawing.Point(13, 185);
            this.BtnGoogle.Name = "BtnGoogle";
            this.BtnGoogle.Size = new System.Drawing.Size(239, 160);
            this.BtnGoogle.TabIndex = 5;
            this.BtnGoogle.Text = "www.google.com";
            this.BtnGoogle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGoogle.UseVisualStyleBackColor = false;
            this.BtnGoogle.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnUnivercity
            // 
            this.BtnUnivercity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUnivercity.BackColor = System.Drawing.Color.White;
            this.BtnUnivercity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUnivercity.BackgroundImage")));
            this.BtnUnivercity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUnivercity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUnivercity.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.0001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUnivercity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUnivercity.Location = new System.Drawing.Point(257, 185);
            this.BtnUnivercity.Name = "BtnUnivercity";
            this.BtnUnivercity.Size = new System.Drawing.Size(239, 160);
            this.BtnUnivercity.TabIndex = 6;
            this.BtnUnivercity.Text = "https://obis1.selcuk.edu.tr/";
            this.BtnUnivercity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUnivercity.UseVisualStyleBackColor = false;
            this.BtnUnivercity.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnN11
            // 
            this.BtnN11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnN11.BackColor = System.Drawing.Color.White;
            this.BtnN11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnN11.BackgroundImage")));
            this.BtnN11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnN11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnN11.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.0001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnN11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnN11.Location = new System.Drawing.Point(747, 185);
            this.BtnN11.Name = "BtnN11";
            this.BtnN11.Size = new System.Drawing.Size(239, 160);
            this.BtnN11.TabIndex = 7;
            this.BtnN11.Text = "www.n11.com";
            this.BtnN11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnN11.UseVisualStyleBackColor = false;
            this.BtnN11.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnDevlet
            // 
            this.BtnDevlet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDevlet.BackColor = System.Drawing.Color.White;
            this.BtnDevlet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDevlet.BackgroundImage")));
            this.BtnDevlet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDevlet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDevlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.0001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDevlet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDevlet.Location = new System.Drawing.Point(502, 185);
            this.BtnDevlet.Name = "BtnDevlet";
            this.BtnDevlet.Size = new System.Drawing.Size(239, 160);
            this.BtnDevlet.TabIndex = 8;
            this.BtnDevlet.Text = "https://giris.turkiye.gov.tr/Giris/";
            this.BtnDevlet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDevlet.UseVisualStyleBackColor = false;
            this.BtnDevlet.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnUsersInformationsShow
            // 
            this.BtnUsersInformationsShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUsersInformationsShow.BackColor = System.Drawing.Color.White;
            this.BtnUsersInformationsShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsersInformationsShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.BtnUsersInformationsShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnUsersInformationsShow.Location = new System.Drawing.Point(12, 365);
            this.BtnUsersInformationsShow.Name = "BtnUsersInformationsShow";
            this.BtnUsersInformationsShow.Size = new System.Drawing.Size(972, 69);
            this.BtnUsersInformationsShow.TabIndex = 9;
            this.BtnUsersInformationsShow.Text = "Kayıtlı Kullanıcıları Göster";
            this.BtnUsersInformationsShow.UseVisualStyleBackColor = false;
            this.BtnUsersInformationsShow.Click += new System.EventHandler(this.BtnUsersInformationsShow_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTime.Location = new System.Drawing.Point(366, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 29);
            this.lblTime.TabIndex = 10;
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.BtnFacebook);
            this.panel1.Controls.Add(this.BtnInstagram);
            this.panel1.Controls.Add(this.BtnUsersInformationsShow);
            this.panel1.Controls.Add(this.BtnWhatsapp);
            this.panel1.Controls.Add(this.BtnN11);
            this.panel1.Controls.Add(this.BtnDevlet);
            this.panel1.Controls.Add(this.BtnTwitter);
            this.panel1.Controls.Add(this.BtnGoogle);
            this.panel1.Controls.Add(this.BtnUnivercity);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 452);
            this.panel1.TabIndex = 11;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFacebook;
        private System.Windows.Forms.Button BtnTwitter;
        private System.Windows.Forms.Button BtnWhatsapp;
        private System.Windows.Forms.Button BtnInstagram;
        private System.Windows.Forms.Button BtnGoogle;
        private System.Windows.Forms.Button BtnUnivercity;
        private System.Windows.Forms.Button BtnN11;
        private System.Windows.Forms.Button BtnDevlet;
        private System.Windows.Forms.Button BtnUsersInformationsShow;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Panel panel1;
    }
}