using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Vanzare_bilete
{
    public class BiletStudent : Bilet
    {
       public  string NumarLegitimatie {  get; set; }

        public string Facultate { get; set; }

        public BiletStudent(string nume, int sala, TipFilm tip, DateTime data, Client client, int loc, double pret, string legittimatie, string facultate): base( nume, sala,tip, data, client, loc, pret)
        {
            NumarLegitimatie = legittimatie;
            Facultate = facultate;
        }

        public override double GetReducere()
        {
            return 0.2 * PretBaza;
        }

        public override bool esteValid()
        {
            if (base.esteValid() && !string.IsNullOrEmpty(NumarLegitimatie))
            {
                return true;
            }
            else
                return false;
        }
    }
}
