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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Net;
namespace PoldyCv
{
    public partial class formBasvur : Form
    {
        public formBasvur()
        {
            InitializeComponent();
        }
        public string mail;
        Baglanti bgl = new Baglanti();
        private void formBasvur_Load(object sender, EventArgs e)
        {
            txtPosta.Text = mail;
            //Kişi Bilgileri
            SqlCommand komut = new SqlCommand("Select * from Cv_Kisiler where KisiMail=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPosta.Text);
            SqlDataReader dr = komut.ExecuteReader();
            Byte[] data = new byte[0];
            if (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                data = (Byte[])(dr[5]);
            }
            MemoryStream mem = new MemoryStream(data);
            picProfile.Image = System.Drawing.Image.FromStream(mem);
            //Point leri temizleme.
            foreach (var series in grafikDepartman.Series)
            {
                series.Points.Clear();
            }
            //Başvuru Paneli
            //Departmanlar Çekiliyor
            SqlCommand komut1 = new SqlCommand("Select * from Cv_Departmanlar", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            int i = 0;
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[1]);
                grafikDepartman.Series["Aranan Eleman Sayisi"].Points.Add(Convert.ToDouble(dr1[2]));
                grafikDepartman.Series["Aranan Eleman Sayisi"].Points[i].AxisLabel = dr1[1].ToString();
                i += 1;
            }

            bgl.baglanti().Close();

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Unvanlar Çekiliyor
            comboBox2.Items.Clear();
            SqlCommand komut2 = new SqlCommand("Select UnvanAd From Cv_Unvanlar Where DepartmanAd=@p3", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p3", comboBox1.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnBasvur_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into Cv_Basvuru (BasvuruDepartman,BasvuruUnvan,BasvuruOnYazı,BasvuruPdf) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBox1.Text);
            komut3.Parameters.AddWithValue("@p2", comboBox2.Text);
            komut3.Parameters.AddWithValue("@p3", richTextBox1.Text);
            komut3.Parameters.AddWithValue("@p4", File.ReadAllBytes(@"C:\\Users\\ademk\\source\repos\\Poldy4\\deneme\\PoldyCv\\Cv.pdf"));
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başvurunuz Tamamlanmıştır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string TurkceKarakter(string text)
        {

            text = text.Replace("İ", "\u0130");

            text = text.Replace("ı", "\u0131");

            text = text.Replace("Ş", "\u015e");

            text = text.Replace("ş", "\u015f");

            text = text.Replace("Ğ", "\u011e");

            text = text.Replace("ğ", "\u011f");

            text = text.Replace("Ö", "\u00d6");

            text = text.Replace("ö", "\u00f6");

            text = text.Replace("ç", "\u00e7");

            text = text.Replace("Ç", "\u00c7");

            text = text.Replace("ü", "\u00fc");

            text = text.Replace("Ü", "\u00dc");

            return text;
        }
        private void btnCvIndir_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();

            PdfWriter.GetInstance(document, new FileStream(@"C:\Users\ademk\source\repos\Poldy4\deneme\PoldyCv\Cv.pdf", FileMode.Create));

            BaseFont arial = BaseFont.CreateFont("C:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            iTextSharp.text.Font font = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);



            if (document.IsOpen() == false)
            {

                document.Open();

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\Users\ademk\source\repos\Poldy4\deneme\PoldyCv\vesikalik.jpg");
                img.ScalePercent(30f, 20f);
                //Unvanlar Çekiliyor
                comboBox2.Items.Clear();
                SqlCommand komut4 = new SqlCommand("Select * From Cv_Cvler Where CvMail=@p1", bgl.baglanti());
                komut4.Parameters.AddWithValue("@p1", txtPosta.Text);
                SqlDataReader dr4 = komut4.ExecuteReader();
                string text = "deneme";
                while (dr4.Read())
                {
                    text =
                        "Kişisel Bilgiler \n" +
                        "--------------------" +
                        "\n Ad :" + dr4[1] +
                        "\n Soyad : " + dr4[2] +
                        "\n Doğum Tarihi : " + dr4[3] +
                        "\n Doğum Yılı : " + dr4[4] +
                        "\n Medeni Durum : " + dr4[5] +
                        "\n ----------------------------------------" +
                        "\n Eğitim Bilgileri" +
                        "\n--------------------" +
                        "\n Öğrenim Seviyesi :" + dr4[6] +
                        "\n Okul Adı : " + dr4[7] +
                        "\n Okul Başlangıç : " + dr4[8] +
                        "\n Okul Bitiş : " + dr4[9] +
                        "\n --------------------" +
                        "\n Adres Bilgileri" +
                        "\n ---------------------" +
                        "\n Adres : " + dr4[10] +
                        "\n --------------------" +
                        "\n İletişim Bilgileri" +
                        "\n ---------------------" +
                        "\n Cep Numarası : " + dr4[11] +
                        "\n Mail Adresi : " + dr4[12] +
                        "\n --------------------" +
                        "\n Yabancı Dil Bilgileri" +
                        "\n ---------------------" +
                        "\n Yabancı Dil : " + dr4[13] +
                        "\n Yabancı Dil Seviye : " + dr4[14] +
                        "\n --------------------" +
                        "\n Yabancı Dil Bilgileri" +
                        "\n ---------------------" +
                        "\n Yetkinlikler : " + dr4[15] +
                        "\n ----------------------------" +
                        "\n Referanslar : " + dr4[15]
                                  ;
                }
                bgl.baglanti().Close();
                document.Add(img);




                text = TurkceKarakter(text);
                document.Add(new Paragraph(text, font));
                MessageBox.Show("Cv'niz Oluşturulmuştur.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                document.Close();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
