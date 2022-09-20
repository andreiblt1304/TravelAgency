using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAgentieTurism_BaltariuAndrei
{
    class LocationList : ICloneable    //clasa tip ICloneable
    {
        private List<Location> listaLocatii = new List<Location>();

        public List<Location> ListaLocatii
        {
            get { return this.listaLocatii; }
        }

        public object Clone()
        {
            return ((ICloneable)this).Clone();
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public static LocationList operator +(LocationList list, Location l)   //supraincarcare operator +
        {
            LocationList copie = (LocationList)list.Clone();
            copie.listaLocatii.Add(l);
            return copie;
        }


        public Location this[int index]         //supraincarcare index
        {
            get
            {
                if (listaLocatii != null && index >= 0 && index < listaLocatii.Count)
                {
                    return listaLocatii[index];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
