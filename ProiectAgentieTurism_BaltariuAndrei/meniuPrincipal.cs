using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAgentieTurism_BaltariuAndrei
{
    public partial class meniuPrincipal : Form
    {
        public meniuPrincipal()
        {
            InitializeComponent();
        }

        private void btAngajat_Click(object sender, EventArgs e)
        {
            var a = new meniuAdaugare();
            this.Hide();
            a.Show();
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            var b = new meniuClient();
            this.Hide();
            b.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
