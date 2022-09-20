using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace ProiectAgentieTurism_BaltariuAndrei
{
    public class AccesData : Location
    {

        public List<Location> aduTot(string tipCladire)
        {
            //var eroare = MessageBox.Show("Nu exista informatii in baza de date!");

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Agentie")))
            {

                var rezultat = connection.Query<Location>($"SELECT * FROM Locatii").ToList();
                {
                    return rezultat;
                }
            }
        }

        public List<Location> aduSpecific(string tipCladire)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Agentie")))
            {
                
                var rezultat = connection.Query<Location>($"SELECT * FROM Locatii WHERE tipCladire = '{tipCladire}'").ToList();
                    {
                        return rezultat;
                    }
                
            }
        }

        public void adaugaPachet(int c, string t, int r, bool i, string a)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Agentie")))
            {
                
                List<Location> locatii = new List<Location>();

                locatii.Add(new Location {cod = c, tipLocatie = t, Rating = r, allInclusive = i, adresa = a });

                //connection.Execute("dbo.adaugaPachet @cod, @tipLocatie, @Rating, @allInclusive, @adresa", locatii);


                //SqlCommand cmd = new SqlCommand($"INSERT INTO [AgentieTurism].[dbo].[Locatii]('cod', 'tipCladire', 'rating', 'allInclusive', 'adresa') VALUES(@c, @t, @r, @i, @a)", locatii);
                //
                var rezultat = connection.Query<Location>($"INSERT INTO Locatii ('cod', 'tipCladire', 'rating', 'allInclusive', 'adresa') VALUES ('{cod}', '{tipLocatie}, '{Rating}, '{allInclusive}', '{adresa}')").ToList();
            }
        }
    }
}
