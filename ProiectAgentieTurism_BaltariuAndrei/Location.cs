using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProiectAgentieTurism_BaltariuAndrei
{
    public class Location : ArataTot, IComparable
    {
        public int cod;
        public string tipLocatie;
        public int Rating;
        public bool allInclusive;
        public string adresa;

        public Location(int cod, string tipLocatie, int Rating, bool allInclusive, string adresa)
        {
            SetCod(cod);
            SetTipLocatie(tipLocatie);
            SetRating(Rating);
            SetAllInclusive(allInclusive);
            SetAdresa(adresa);
        }

        public Location()
        {
        }

        public int GetCod()
        {
            return cod;
        }

        public string GetTipLocatie()
        {
            return tipLocatie;
        }

        public int GetNrStele()
        {
            return (Rating < 0 ? 0 : (Rating > 5 ? 5 : Rating));
        }

        public bool GetAllInclusive()
        {
            return allInclusive;
        }

        public string GetAdresa()
        {
            return adresa;
        }

        public void SetCod(int c)
        {
            if (c == 0)
            {
                MessageBox.Show("Codul nu poate fi 0!");
            }
            else
            {
                this.cod = c;
            }
        }

        public void SetTipLocatie(string t)
        {
            string tip = t.ToLower();
            if (!tip.Equals("pensiune") && !tip.Equals("vila") && !tip.Equals("hotel"))
            {
                tip = "Indisponibil";
                this.tipLocatie = tip;
                return;
            }

            this.tipLocatie = t;
        }

        public void SetRating(int n)
        {
            int nr = (n < 0 ? 0 : (n > 5 ? 5 : n));
            this.Rating = nr;
        }

        public void SetAllInclusive(bool i)
        {
            this.allInclusive = i;
        }

        public void SetAdresa(string a)
        {
            this.adresa = a;
        }

        public override string ToString()
        {
            return $"Locatie:  - tip: {tipLocatie}" +
                   $"          - nrStele: {Rating}" +
                   $"          - allInclusive: {allInclusive}" +
                   $"          - adresa: {adresa}";
        }

        public override void arataTot()
        {
            throw new NotImplementedException();
        }




        //public int CompareTo(object obj)
        //{
        //    Location l = (Location)obj;                           //implementare IComparable
        //    if ((string)this > (int)obj)
        //        return -1;
        //    else
        //        if ((float)this < (float)s)
        //        return 1;
        //    else
        //        return string.Compare(this.nume, s.nume);
        //}

        public int CompareTo(object obj)
        {
            Location l = (Location)obj;
            return string.Compare(this.tipLocatie, l.tipLocatie);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static explicit operator string(Location v)
        {
            throw new NotImplementedException();
        }
    }

}


