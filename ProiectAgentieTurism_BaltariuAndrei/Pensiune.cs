using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAgentieTurism_BaltariuAndrei
{
    class Pensiune : Location
    {
        private
        bool gratar;
        bool curte;

        public Pensiune() : base(1, "Pensiune", 1, false, "")
        {
            SetGratar(gratar);
            SetCurte(curte);
        }

        public bool GetGratar()
        {
            return gratar;
        }

        public void SetGratar(bool g)
        {
            this.gratar = g;
        }

        public bool GetCurte()
        {
            return curte;
        }

        public void SetCurte(bool c)
        {
            this.curte = c;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + " are gratar: " + gratar + " are curte: " + curte;
        }
    }
}
