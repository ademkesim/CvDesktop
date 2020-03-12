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
            this.btnIlanEkle = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblMerhaba = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.dataBasvurular = new System.Windows.Forms.DataGridView();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamBasvuruSayisi = new System.Windows.Forms.Label();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.cmbDepartmanSec = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBasvurular)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmbDepartmanSec);
            this.panel1.Controls.Add(this.btnIlanEkle);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblMerhaba);
            this.panel1.Controls.Add(this.picProfile);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 239);
            this.panel1.TabIndex = 0;
            // 
            // btnIlanEkle
            // 
            this.btnIlanEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(101)))), ((int)(((byte)(132)))));
            this.btnIlanEkle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIlanEkle.ForeColor = System.Drawing.Color.White;
            this.btnIlanEkle.Location = new System.Drawing.Point(201, 76);
            this.btnIlanEkle.Name = "btnIlanEkle";
            this.btnIlanEkle.Size = new System.Drawing.Size(183, 44);
            this.btnIlanEkle.TabIndex = 8;
            this.btnIlanEkle.Text = "İş İlanı Ekle";
            this.btnIlanEkle.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(410, 15);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(478, 205);
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
            this.picProfile.Location = new System.Drawing.Point(18, 34);
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
            this.dataBasvurular.Name = "dataBasvurular";
            this.dataBasvurular.RowHeadersWidth = 51;
            this.dataBasvurular.RowTemplate.Height = 24;
            this.dataBasvurular.Size = new System.Drawing.Size(902, 296);
            this.dataBasvurular.TabIndex = 1;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(12, 257);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(221, 36);
            this.cmbDepartman.TabIndex = 2;
            this.cmbDepartman.Text = "Tümü";
            this.cmbDepartman.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(623, 260);
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
            this.lblToplamBasvuruSayisi.Size = new System.Drawing.Size(49, 29);
            this.lblToplamBasvuruSayisi.TabIndex = 4;
            this.lblToplamBasvuruSayisi.Text = "100";
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(239, 257);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(221, 36);
            this.cmbUnvan.TabIndex = 5;
            this.cmbUnvan.Text = "Tümü";
            // 
            // cmbDepartmanSec
            // 
            this.cmbDepartmanSec.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmanSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbDepartmanSec.FormattingEnabled = true;
            this.cmbDepartmanSec.Location = new System.Drawing.Point(201, 34);
            this.cmbDepartmanSec.Name = "cmbDepartmanSec";
            this.cmbDepartmanSec.Size = new System.Drawing.Size(183, 36);
            this.cmbDepartmanSec.TabIndex = 9;
            this.cmbDepartmanSec.Text = "Departman Seç";
            // 
            // formYoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(926, 617);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.lblToplamBasvuruSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.dataBasvurular);
            this.Controls.Add(this.panel1);
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
    }
}