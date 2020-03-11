using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoldyCv
{
    public partial class formAna : Form
    {
        public formAna()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            formKaydol fr = new formKaydol();
            fr.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            formGirisYap fr = new formGirisYap();
            fr.Show();
            this.Hide();
        }
    }
}
