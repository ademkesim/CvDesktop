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
namespace PoldyCv
{
    public partial class CvOlustur : Form
    {
        public CvOlustur()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CvOlustur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Cv_Cvler (CvAd,CvSoyad,CvDogumTarihi,CvDogumYeri,CvMedeniDurum,CvOgrenimDurum,CvOkul,CvOkulBaslangic,CvOkulBitis,CvAdres,CvCepNo,CvMail,CvYabanciDil,CvYabanciDilSeviye,CvYetkinlikler,CvReferans) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskdogumtarihi.Text);
            komut.Parameters.AddWithValue("@p4", txtdogumyeri.Text);
            komut.Parameters.AddWithValue("@p6", cmbogrenimdurumu.Text);
            komut.Parameters.AddWithValue("@p7", txtokul.Text);
            komut.Parameters.AddWithValue("@p8", mskbaslangic.Text);
            komut.Parameters.AddWithValue("@p9", mskbitis.Text);
            komut.Parameters.AddWithValue("@p10", rchadres.Text);
            komut.Parameters.AddWithValue("@p11", mskcep.Text);
            komut.Parameters.AddWithValue("@p12", txtmail.Text);
            komut.Parameters.AddWithValue("@p13", txtyabancıdil.Text);
            komut.Parameters.AddWithValue("@p14", cmbyabancıdilseviye.Text);
            komut.Parameters.AddWithValue("@p15", rchyetkinlik.Text);
            komut.Parameters.AddWithValue("@p16", rchreferans.Text);

            if (checkBox1.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", checkBox1.Checked);
            }
            if (checkBox2.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", checkBox2.Checked);
            }

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Cv'niz Oluşturuldu");
            formBasvur fb = new formBasvur();
            
            fb.Show();
            this.Hide();


        }
    }
}
