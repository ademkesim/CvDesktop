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
    }
}
