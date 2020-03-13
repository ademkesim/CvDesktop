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
    public partial class formYoneticiPaneli : Form
    {
        public formYoneticiPaneli()
        {
            InitializeComponent();
        }

        Baglanti bgl = new Baglanti();
        private void formYoneticiPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Cv_Basvuru ", bgl.baglanti());
            da.Fill(dt);
            dataBasvurular.DataSource = dt;

            SqlCommand komut3 = new SqlCommand("Select count(*) From Cv_Basvuru",bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblToplamBasvuruSayisi.Text = dr3[0].ToString();
            }

            SqlCommand komut4 = new SqlCommand("Select KisiResim From Cv_Kisiler where kisiid=1",bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            if (dr4.Read())
            {
                picProfile.ImageLocation= dr4[0].ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void işİlanıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIlanEkle_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut2 = new SqlCommand("Update Cv_Departmanlar set DepartmanAd=@p1,Departmanihtiyaç+=@p2",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", cmbDepartmanSec.Text);
            komut2.Parameters.AddWithValue("@p2",txtKacKisi.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show(txtKacKisi.Text+"Yeni iş ilanı eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartmanSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select Departmanihtiyaç From Cv_Departmanlar Where DepartmanAd=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", cmbDepartmanSec.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read())
            {
                label1.Text = dr[0].ToString();
            }
               
           
            bgl.baglanti().Close();
        }    
    }
}
