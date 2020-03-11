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
    public partial class formKaydol : Form
    {
        public formKaydol()
        {
            InitializeComponent();
        }

        private void formKaydol_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            formAna fr = new formAna();
            fr.Show();
            this.Hide();
        }
    }
}
