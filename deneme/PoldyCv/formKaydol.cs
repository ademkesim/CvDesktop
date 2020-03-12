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
            FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            SqlCommand komut2 = new SqlCommand("insert into Cv_Kisiler (KisiResim) values(@resim)", bgl.baglanti());
            komut2.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
            try
            {
                komut2.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                bgl.baglanti().Close();
            }

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreOnay.Text)
            {
                MessageBox.Show("Lütfen Şifrenizi Doğru Giriniz");

            }
            else
            {
                SqlCommand komut = new SqlCommand("Update  Cv_Kisiler set KisikAdi=@p1,KisiAd=@p2,KisiSoyad=@p3,KisiMail=@p4,KisiSifre=@p5  ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p4", txtPosta.Text);
                komut.Parameters.AddWithValue("@p5", txtSifre.Text);


                MessageBox.Show("Kayıt Eklendi...");
                bgl.baglanti().Close();
                formAna fr = new formAna();
                fr.Show();
                this.Hide();
            }
        }

        private void profilResmi_Click(object sender, EventArgs e)
        {
            resimdata();
        }
    }
}