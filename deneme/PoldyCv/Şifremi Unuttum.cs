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
using System.Net.Mail; 

namespace PoldyCv
{
    public partial class Şifremi_Unuttum : Form
    {
        public Şifremi_Unuttum()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        public string sifre;
        public string mail;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Cv_Kisiler where KisiMail=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                sifre = dr["KisiSifre"].ToString();
                mail = dr["KisiMail"].ToString();
                

            }
            if (mail == textBox1.Text)
            {
                MailMessage mesajim = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("selcuktf@gmail.com", "SelcukPoldy2020");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                mesajim.To.Add(textBox1.Text);
                mesajim.From = new MailAddress("selcuktf@gmail.com");
                mesajim.Subject = "Şifre Hatırlatma";
                mesajim.Body = ("Şifreniz:" + sifre);
                smtp.Send(mesajim);

            }
            else
            {

                MessageBox.Show("Mail Adresinizi Yanlış Girdiniz");
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "E Posta")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "E Posta";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
       
    }
