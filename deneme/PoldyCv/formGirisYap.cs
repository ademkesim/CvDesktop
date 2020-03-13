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
    public partial class formGirisYap : Form
    {
        public formGirisYap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formAna form = new formAna();
            form.Show();
            this.Hide();
        }
        Baglanti bgl = new Baglanti();
        private void formGirisYap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Cv_Kisiler where KisiMail=@p1 and KisiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMail.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader sdr = komut.ExecuteReader();
            if (sdr.Read())
            {
                formBasvur fb = new formBasvur();
                formYoneticiPaneli fyb = new formYoneticiPaneli();
                fyb.mail = TxtMail.Text;
                fb.mail = TxtMail.Text;
                if (sdr[6].ToString()=="1")
                {
                    fyb.Show();
                    this.Hide();
                }
                else
                {
                    fb.Show();
                    this.Hide();
                }
                
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void TxtMail_Enter(object sender, EventArgs e)
        {
            if (TxtMail.Text == "Mail Adresi")
            {
                TxtMail.Text = "";
                TxtMail.ForeColor = Color.Black;
            }
        }

        private void TxtMail_Leave(object sender, EventArgs e)
        {
            if (TxtMail.Text == "")
            {
                TxtMail.Text = "Mail Adresi";
                TxtMail.ForeColor = Color.Gray;
            }
        }

        private void TxtSifre_Enter(object sender, EventArgs e)
        {
            if (TxtSifre.Text == "Şifre")
            {
                TxtSifre.Text = "";
                TxtSifre.ForeColor = Color.Black;
            }
        }

        private void TxtSifre_Leave(object sender, EventArgs e)
        {
            if (TxtSifre.Text == "")
            {
                TxtSifre.Text = "Şifre";
                TxtSifre.ForeColor = Color.Gray;
            }
        }
    }
}
