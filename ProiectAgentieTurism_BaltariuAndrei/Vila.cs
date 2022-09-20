using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAgentieTurism_BaltariuAndrei
{
    class Vila : Location, IComparable
    {
        private
            bool salaMese;

        public Vila(bool salaMese) : base(1, "Vila", 1, false, "strada Fulger")
        {
            SetSalaMese(salaMese);
        }

        public bool GetSalaMese()
        {
            return salaMese;
        }

        public void SetSalaMese(bool s)
        {
            this.salaMese = s;
        }

        public override string ToString()
        {
            return base.ToString() + " are sala de mese: " + salaMese;
        }
    }
}
