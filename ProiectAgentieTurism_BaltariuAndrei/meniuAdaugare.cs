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
    public partial class meniuAdaugare : Form
    {
        public meniuAdaugare()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            var meniu = new meniuPrincipal();
            this.Hide();
            meniu.Show();
        }

        private void btnAdaugaVac_Click(object sender, EventArgs e)
        {
            int codParsat = int.Parse(txCod.Text);
            int ratingParsat = int.Parse(txRating.Text);
            bool allParsat = Convert.ToBoolean(txAll.Text);
            AccesData db = new AccesData();
            db.adaugaPachet(codParsat, txTipCladire.Text, ratingParsat, allParsat, txAdresa.Text);
            //db.adaugaPachet(txCod.Text, txTipCladire.Text, txRating.Text, txAll.Text, txAdresa.Text);
            txCod.Text = "";
            txTipCladire.Text = "";
            txRating.Text = "";
            txAll.Text = "";
            txAdresa.Text = "";
        }

        private void lbTot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
