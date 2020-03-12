namespace PoldyCv
{
    partial class formKaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKaydol));
            this.lblEslesmiyor = new System.Windows.Forms.Label();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.txtSifreOnay = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.profilResmi = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.profilResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEslesmiyor
            // 
            this.lblEslesmiyor.AutoSize = true;
            this.lblEslesmiyor.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEslesmiyor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lblEslesmiyor.Location = new System.Drawing.Point(165, 493);
            this.lblEslesmiyor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEslesmiyor.Name = "lblEslesmiyor";
            this.lblEslesmiyor.Size = new System.Drawing.Size(170, 24);
            this.lblEslesmiyor.TabIndex = 8;
            this.lblEslesmiyor.Text = "Şifreler eşleşmiyor!";
            this.lblEslesmiyor.Visible = false;
            // 
            // btnKaydol
            // 
            this.btnKaydol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(214)))));
            this.btnKaydol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydol.ForeColor = System.Drawing.Color.White;
            this.btnKaydol.Location = new System.Drawing.Point(169, 530);
            this.btnKaydol.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(319, 43);
            this.btnKaydol.TabIndex = 7;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = false;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // txtSifreOnay
            // 
            this.txtSifreOnay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifreOnay.ForeColor = System.Drawing.Color.Gray;
            this.txtSifreOnay.Location = new System.Drawing.Point(169, 457);
            this.txtSifreOnay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifreOnay.Name = "txtSifreOnay";
            this.txtSifreOnay.Size = new System.Drawing.Size(315, 32);
            this.txtSifreOnay.TabIndex = 6;
            this.txtSifreOnay.Text = "Şifre Onayla";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.ForeColor = System.Drawing.Color.Gray;
            this.txtSifre.Location = new System.Drawing.Point(169, 417);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(315, 32);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.Text = "Şifre";
            // 
            // txtPosta
            // 
            this.txtPosta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosta.ForeColor = System.Drawing.Color.Gray;
            this.txtPosta.Location = new System.Drawing.Point(169, 376);
            this.txtPosta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(315, 32);
            this.txtPosta.TabIndex = 4;
            this.txtPosta.Text = "E-Posta";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.ForeColor = System.Drawing.Color.Gray;
            this.txtSoyad.Location = new System.Drawing.Point(169, 335);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(315, 32);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.ForeColor = System.Drawing.Color.Gray;
            this.txtAd.Location = new System.Drawing.Point(169, 295);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(315, 32);
            this.txtAd.TabIndex = 2;
            this.txtAd.Text = "Ad";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(169, 254);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(315, 32);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // profilResmi
            // 
            this.profilResmi.Image = ((System.Drawing.Image)(resources.GetObject("profilResmi.Image")));
            this.profilResmi.Location = new System.Drawing.Point(250, 76);
            this.profilResmi.Margin = new System.Windows.Forms.Padding(4);
            this.profilResmi.Name = "profilResmi";
            this.profilResmi.Size = new System.Drawing.Size(159, 150);
            this.profilResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilResmi.TabIndex = 0;
            this.profilResmi.TabStop = false;
            this.profilResmi.Click += new System.EventHandler(this.profilResmi_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // formKaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(631, 634);
            this.Controls.Add(this.lblEslesmiyor);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.profilResmi);
            this.Controls.Add(this.txtSifreOnay);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtPosta);
            this.Controls.Add(this.txtSoyad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formKaydol";
            this.Text = "Kaydol";
            ((System.ComponentModel.ISupportInitialize)(this.profilResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.PictureBox profilResmi;
        private System.Windows.Forms.TextBox txtSifreOnay;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Label lblEslesmiyor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}