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
    public partial class DepartmanEkle : Form
    {
        public DepartmanEkle()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Cv_Departmanlar (DepartmanAd,Departmanihtiyaç)values(@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p2",0);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Departman Eklendi");
            this.Hide();
        }

        private void DepartmanEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
