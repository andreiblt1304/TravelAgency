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
    public partial class meniuClient : Form
    {
        List<Location> listaLocatii = new List<Location>();

        private void updateBind()
        {
            lbRezultatOras.DataSource = listaLocatii;
            lbRezultatOras.DisplayMember = "ToString";
        }

        public meniuClient()
        {
            InitializeComponent();

            updateBind();

            meniuPrincipal meniu = new meniuPrincipal();
            meniu.Hide();
        }
        
        private void btArataTot_Click_1(object sender, EventArgs e)
        {
            AccesData db = new AccesData();

            listaLocatii = db.aduTot(txCautaOras.Text);

            updateBind();
        }

        private void btCautaOras_Click_1(object sender, EventArgs e)
        {
            AccesData db = new AccesData();

            listaLocatii = db.aduSpecific(txCautaOras.Text);

            updateBind();
        }

        private void btBack_Click_1(object sender, EventArgs e)
        {
            var meniu = new meniuPrincipal();
            this.Hide();
            meniu.Show();
        }

        private void lbRezultatOras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
