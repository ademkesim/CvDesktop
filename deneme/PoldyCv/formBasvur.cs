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
            if (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
            }

            //Başvuru Paneli
                //Departmanlar Çekiliyor
            SqlCommand komut1 = new SqlCommand("Select DepartmanAd,Departmanid from Cv_Departmanlar", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1[0]);
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
            SqlCommand komut3 = new SqlCommand("insert into Cv_Basvuru (BasvuruDepartman,BasvuruUnvan,BasvuruOnYazı) values (@p1,@p2,@p3)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBox1.Text);
            komut3.Parameters.AddWithValue("@p2", comboBox2.Text);
            komut3.Parameters.AddWithValue("@p3", richTextBox1.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Başvurunuz Gerçekleşmiştir Biz sizi geri ararız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCvIndir_Click(object sender, EventArgs e)
        {
            
            }
        }
    }
