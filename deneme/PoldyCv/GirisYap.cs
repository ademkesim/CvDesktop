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
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {
            txtParola.UseSystemPasswordChar = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtParola.UseSystemPasswordChar = !txtParola.UseSystemPasswordChar;
        }

        
    }
}
