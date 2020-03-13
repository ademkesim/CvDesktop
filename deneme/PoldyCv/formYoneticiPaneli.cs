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
using System.Diagnostics;

namespace PoldyCv
{
    public partial class formYoneticiPaneli : Form
    {
        public formYoneticiPaneli()
        {
            InitializeComponent();
        }
        public string ad;
        public string mail;
        Baglanti bgl = new Baglanti();
        private void formYoneticiPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Basvuruid,BasvuruDepartman,BasvuruUnvan,BasvuruOnYazı From Cv_Basvuru ", bgl.baglanti());
            da.Fill(dt);
            dataBasvurular.DataSource = dt;

            SqlCommand komut3 = new SqlCommand("Select count(*) From Cv_Basvuru",bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblToplamBasvuruSayisi.Text = dr3[0].ToString();
            }

            SqlCommand komut4 = new SqlCommand("Select * From Cv_Kisiler where KisiRutbe=1", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            Byte[] data = new byte[0];
            
            while (dr4.Read())
            {
                data = (Byte[])(dr4[5]);
                ad = dr4[1].ToString();
            }
            lblMerhaba.Text = "Merhaba " + ad;
            MemoryStream mem = new MemoryStream(data);
            picProfile.Image = Image.FromStream(mem);

            SqlCommand komut5 = new SqlCommand("Select DepartmanAd from Cv_Departmanlar", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                cmbDepartmanSec.Items.Add(dr5[0]);
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
           
            SqlCommand komut2 = new SqlCommand("Update Cv_Departmanlar set DepartmanAd=@p1,Departmanihtiyaç+=@p2 where DepartmanAd=@p3",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", cmbDepartmanSec.Text);
            komut2.Parameters.AddWithValue("@p2",txtKacKisi.Text);
            komut2.Parameters.AddWithValue("@p3", cmbDepartmanSec.Text);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataBasvurular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataBasvurular.SelectedCells[0].RowIndex;
            tasiyici = dataBasvurular.Rows[secilen].Cells[0].Value.ToString();
            MessageBox.Show(tasiyici);
        }
        public string tasiyici;
        private void dataBasvurular_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataBasvurular.SelectedCells[0].RowIndex;
            tasiyici = dataBasvurular.Rows[secilen].Cells[0].Value.ToString();
            MessageBox.Show(tasiyici);
        }
        public byte[] ap;
        private void button1_Click_2(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select BasvuruPdf from Cv_Basvuru where Basvuruid=" + tasiyici, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            
            if (dr.Read())
            {
                this.ap = (byte[])(dr[0]);
            }
            MemoryStream ms = new MemoryStream(ap);
            ms.Position = 0;
            File.WriteAllBytes(@"D:\mypdf.pdf", ms.ToArray());
            Process.Start(@"D:\mypdf.pdf");
        }
    }
}
