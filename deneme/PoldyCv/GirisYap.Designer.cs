namespace PoldyCv
{
    partial class GirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSifreGoster = new System.Windows.Forms.Button();
            this.BtnGirsYap = new System.Windows.Forms.Button();
            this.LnkSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.PicProfilResim = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProfilResim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.BtnSifreGoster);
            this.panel1.Controls.Add(this.BtnGirsYap);
            this.panel1.Controls.Add(this.LnkSifremiUnuttum);
            this.panel1.Controls.Add(this.txtParola);
            this.panel1.Controls.Add(this.TxtKullaniciAdi);
            this.panel1.Controls.Add(this.PicProfilResim);
            this.panel1.Location = new System.Drawing.Point(196, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 374);
            this.panel1.TabIndex = 0;
            // 
            // BtnSifreGoster
            // 
            this.BtnSifreGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSifreGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSifreGoster.Location = new System.Drawing.Point(269, 214);
            this.BtnSifreGoster.Name = "BtnSifreGoster";
            this.BtnSifreGoster.Size = new System.Drawing.Size(36, 27);
            this.BtnSifreGoster.TabIndex = 7;
            this.BtnSifreGoster.Text = "x";
            this.BtnSifreGoster.UseVisualStyleBackColor = false;
            this.BtnSifreGoster.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnGirsYap
            // 
            this.BtnGirsYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(214)))));
            this.BtnGirsYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirsYap.ForeColor = System.Drawing.Color.White;
            this.BtnGirsYap.Location = new System.Drawing.Point(163, 270);
            this.BtnGirsYap.Name = "BtnGirsYap";
            this.BtnGirsYap.Size = new System.Drawing.Size(102, 36);
            this.BtnGirsYap.TabIndex = 6;
            this.BtnGirsYap.Text = "Giriş";
            this.BtnGirsYap.UseVisualStyleBackColor = false;
            // 
            // LnkSifremiUnuttum
            // 
            this.LnkSifremiUnuttum.AutoSize = true;
            this.LnkSifremiUnuttum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkSifremiUnuttum.Location = new System.Drawing.Point(58, 248);
            this.LnkSifremiUnuttum.Name = "LnkSifremiUnuttum";
            this.LnkSifremiUnuttum.Size = new System.Drawing.Size(116, 19);
            this.LnkSifremiUnuttum.TabIndex = 5;
            this.LnkSifremiUnuttum.TabStop = true;
            this.LnkSifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Location = new System.Drawing.Point(58, 214);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(207, 27);
            this.txtParola.TabIndex = 4;
            this.txtParola.Text = "Parola";
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(58, 182);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(207, 27);
            this.TxtKullaniciAdi.TabIndex = 3;
            this.TxtKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // PicProfilResim
            // 
            this.PicProfilResim.Image = ((System.Drawing.Image)(resources.GetObject("PicProfilResim.Image")));
            this.PicProfilResim.Location = new System.Drawing.Point(58, 13);
            this.PicProfilResim.Name = "PicProfilResim";
            this.PicProfilResim.Size = new System.Drawing.Size(252, 163);
            this.PicProfilResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicProfilResim.TabIndex = 2;
            this.PicProfilResim.TabStop = false;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(214)))));
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(58, 270);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(102, 36);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            // 
            // GirisYap
            // 
            this.AcceptButton = this.BtnGirsYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(729, 493);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GirisYap";
            this.Text = "GirisYap";
            this.Load += new System.EventHandler(this.GirisYap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProfilResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSifreGoster;
        private System.Windows.Forms.Button BtnGirsYap;
        private System.Windows.Forms.LinkLabel LnkSifremiUnuttum;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.PictureBox PicProfilResim;
        private System.Windows.Forms.Button btnGeri;
    }
}