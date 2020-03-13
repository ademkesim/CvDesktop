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
            SqlCommand komut = new SqlCommand("insert into Cv_Cvler (CvAd,CvSoyad,CvDoğumTarihi,CvDoğumYeri,CvMedeniDurum,CvÖğrenimDurum,CvOkul,CvOkulBaslangic,CvOkulBitiş,CvAdres,CvCepNo,CvMail,CvYabanciDil,CvYabanciDilSeviye,CvYetkinlikler,CvReferans) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15)", bgl.baglanti());

        }
    }
}
