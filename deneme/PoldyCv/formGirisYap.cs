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
                fb.mail = TxtMail.Text;
                fb.Show();
            }
            else
            {
                label1.Visible = true;
            }
        }
    }
}
