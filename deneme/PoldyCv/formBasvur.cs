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
            SqlCommand komut = new SqlCommand("Select * from Cv_Kisiler where KisiMail=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPosta.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
            }
        }
    }
}
