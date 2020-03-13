using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PoldyCv
{
    public partial class formKaydol : Form
    {
        public formKaydol()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        public string resimpath;
     
        public void resimdata()
        {

            openFileDialog1.Title = "Resim";
            openFileDialog1.Filter = "Jpeg Dosyası(*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                profilResmi.Image = Image.FromFile(openFileDialog1.FileName);
                resimpath = openFileDialog1.FileName.ToString();
            }
            //FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            //byte[] resim = br.ReadBytes((int)fs.Length);
            //br.Close();
            //SqlCommand komut2 = new SqlCommand("insert into Cv_Kisiler (KisiResim) values(@resim)", bgl.baglanti());
            //komut2.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
            //try
            //{
            //    komut2.ExecuteNonQuery();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
            //finally
            //{
            //    bgl.baglanti().Close();
            //}

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreOnay.Text)
            {
                MessageBox.Show("Lütfen Şifrenizi Doğru Giriniz");

            }
            else
            {
                FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] resim = br.ReadBytes((int)fs.Length);
                br.Close();
                SqlCommand komut = new SqlCommand("insert into Cv_Kisiler (KisiAd,KisiSoyad,KisiMail,KisiSifre,KisiResim) values(@p2,@p3,@p4,@p5,@p6)   ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p4", txtPosta.Text);
                komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                komut.Parameters.Add("@p6", SqlDbType.Image, resim.Length).Value = resim;
               
               
                try
                {
                    komut.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    bgl.baglanti().Close();
                }
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Eklendi...");
                formAna fr = new formAna();
                fr.Show();
                this.Hide();
            }
        }

        private void profilResmi_Click(object sender, EventArgs e)
        {
            resimdata();
        }

        private void formKaydol_Load(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtAd_Enter(object sender, EventArgs e)
        {
            if (txtAd.Text == "Ad")
            {
                txtAd.Text = "";
                txtAd.ForeColor = Color.Black;
            }
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                txtAd.Text = "Ad";
                txtAd.ForeColor = Color.Gray;
            }
        }

        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "Soyad")
            {
                txtSoyad.Text = "";
                txtSoyad.ForeColor = Color.Black;
            }
        }

        private void txtSoyad_Leave(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "")
            {
                txtSoyad.Text = "Soyad";
                txtSoyad.ForeColor = Color.Gray;
            }
        }

        private void txtPosta_Enter(object sender, EventArgs e)
        {
            if (txtPosta.Text == "E-Posta")
            {
                txtPosta.Text = "";
                txtPosta.ForeColor = Color.Black;
            }
        }

        private void txtPosta_Leave(object sender, EventArgs e)
        {
            if (txtPosta.Text == "")
            {
                txtPosta.Text = "E-Posta";
                txtPosta.ForeColor = Color.Gray;
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Text = "";
                txtSifre.ForeColor = Color.Black;
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre";
                txtSifre.ForeColor = Color.Gray;
            }
        }

        private void txtSifreOnay_Enter(object sender, EventArgs e)
        {
            if (txtSifreOnay.Text == "Şifreyi Onayla")
            {
                txtSifreOnay.Text = "";
                txtSifreOnay.ForeColor = Color.Black;
            }
        }

        private void txtSifreOnay_Leave(object sender, EventArgs e)
        {
            if (txtSifreOnay.Text == "")
            {
                txtSifreOnay.Text = "Şifreyi Onayla";
                txtSifreOnay.ForeColor = Color.Gray;
            }
        }
    }
}