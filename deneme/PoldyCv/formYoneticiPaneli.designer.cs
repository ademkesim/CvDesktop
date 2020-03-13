namespace PoldyCv
{
    partial class formYoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formYoneticiPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKacKisi = new System.Windows.Forms.TextBox();
            this.cmbDepartmanSec = new System.Windows.Forms.ComboBox();
            this.btnIlanEkle = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblMerhaba = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.dataBasvurular = new System.Windows.Forms.DataGridView();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamBasvuruSayisi = new System.Windows.Forms.Label();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBasvurular)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKacKisi);
            this.panel1.Controls.Add(this.cmbDepartmanSec);
            this.panel1.Controls.Add(this.btnIlanEkle);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblMerhaba);
            this.panel1.Controls.Add(this.picProfile);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 239);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(404, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 11;
            // 
            // txtKacKisi
            // 
            this.txtKacKisi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKacKisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKacKisi.Location = new System.Drawing.Point(201, 74);
            this.txtKacKisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKacKisi.Name = "txtKacKisi";
            this.txtKacKisi.Size = new System.Drawing.Size(183, 32);
            this.txtKacKisi.TabIndex = 10;
            this.txtKacKisi.Text = "Kaç Kişilik";
            this.txtKacKisi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbDepartmanSec
            // 
            this.cmbDepartmanSec.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmanSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbDepartmanSec.FormattingEnabled = true;
            this.cmbDepartmanSec.Location = new System.Drawing.Point(201, 34);
            this.cmbDepartmanSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartmanSec.Name = "cmbDepartmanSec";
            this.cmbDepartmanSec.Size = new System.Drawing.Size(183, 32);
            this.cmbDepartmanSec.TabIndex = 9;
            this.cmbDepartmanSec.Text = "Departman Seç";
            this.cmbDepartmanSec.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanSec_SelectedIndexChanged);
            // 
            // btnIlanEkle
            // 
            this.btnIlanEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnIlanEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIlanEkle.ForeColor = System.Drawing.Color.White;
            this.btnIlanEkle.Location = new System.Drawing.Point(201, 112);
            this.btnIlanEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIlanEkle.Name = "btnIlanEkle";
            this.btnIlanEkle.Size = new System.Drawing.Size(183, 44);
            this.btnIlanEkle.TabIndex = 8;
            this.btnIlanEkle.Text = "İş İlanı Ekle";
            this.btnIlanEkle.UseVisualStyleBackColor = false;
            this.btnIlanEkle.Click += new System.EventHandler(this.btnIlanEkle_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(485, 15);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(403, 206);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // lblMerhaba
            // 
            this.lblMerhaba.AutoSize = true;
            this.lblMerhaba.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerhaba.Location = new System.Drawing.Point(13, 169);
            this.lblMerhaba.Name = "lblMerhaba";
            this.lblMerhaba.Size = new System.Drawing.Size(156, 29);
            this.lblMerhaba.TabIndex = 1;
            this.lblMerhaba.Text = "Merhaba Tarık";
            // 
            // picProfile
            // 
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.Location = new System.Drawing.Point(19, 34);
            this.picProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(147, 119);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            // 
            // dataBasvurular
            // 
            this.dataBasvurular.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.dataBasvurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBasvurular.Location = new System.Drawing.Point(12, 299);
            this.dataBasvurular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataBasvurular.Name = "dataBasvurular";
            this.dataBasvurular.RowHeadersWidth = 51;
            this.dataBasvurular.RowTemplate.Height = 24;
            this.dataBasvurular.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataBasvurular.Size = new System.Drawing.Size(602, 295);
            this.dataBasvurular.TabIndex = 1;
            this.dataBasvurular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBasvurular_CellContentClick);
            this.dataBasvurular.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBasvurular_CellContentClick);
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Bt",
            "Üretim",
            "Satın Alma ",
            "Muhasebe"});
            this.cmbDepartman.Location = new System.Drawing.Point(12, 257);
            this.cmbDepartman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(221, 36);
            this.cmbDepartman.TabIndex = 2;
            this.cmbDepartman.Text = "Departman ID";
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Toplam Başvuru Sayısı:";
            // 
            // lblToplamBasvuruSayisi
            // 
            this.lblToplamBasvuruSayisi.AutoSize = true;
            this.lblToplamBasvuruSayisi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamBasvuruSayisi.Location = new System.Drawing.Point(865, 260);
            this.lblToplamBasvuruSayisi.Name = "lblToplamBasvuruSayisi";
            this.lblToplamBasvuruSayisi.Size = new System.Drawing.Size(0, 29);
            this.lblToplamBasvuruSayisi.TabIndex = 4;
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Items.AddRange(new object[] {
            "İnsan Uzmanı",
            "Bt Uzmanı",
            "Personel",
            "Bilgisayar Mühendisi"});
            this.cmbUnvan.Location = new System.Drawing.Point(239, 257);
            this.cmbUnvan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(221, 36);
            this.cmbUnvan.TabIndex = 5;
            this.cmbUnvan.Text = "Ünvan Seç";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(694, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 106);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cv Pdf İndir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // formYoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(925, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.lblToplamBasvuruSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.dataBasvurular);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "formYoneticiPaneli";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.formYoneticiPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBasvurular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataBasvurular;
        private System.Windows.Forms.Label lblMerhaba;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplamBasvuruSayisi;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnIlanEkle;
        private System.Windows.Forms.ComboBox cmbDepartmanSec;
        private System.Windows.Forms.TextBox txtKacKisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}