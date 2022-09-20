using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAgentieTurism_BaltariuAndrei
{
    class Hotel : Location
    {
        private
        bool piscina;


        private Hotel(int nrStele) : base(1, "Hotel", 1, false, "")
        {
            SetRating(nrStele);
        }

        public bool GetPiscina()
        {
            return piscina;
        }

        public void SetPiscina(bool p)
        {
            this.piscina = p;
        }

        public override string ToString()
        {
            return base.ToString() + " are piscina: " + piscina;
        }
    }
}
