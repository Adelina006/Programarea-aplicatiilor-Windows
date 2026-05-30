using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Vanzare_bilete
{
    public class BiletVIP : Bilet
    {
        bool IncludePopcorn { get; set; }
        bool IncludeBautura { get; set; }


        public BiletVIP(string nume, int sala, TipFilm tip, DateTime data, Client client, int loc, double pret, bool popcorn, bool bautura) : base(nume, sala, tip, data, client, loc, pret)
        {
            IncludeBautura = bautura;
            IncludePopcorn = popcorn;
        }

        public double GetExtras()
        {
            double suma = 0;
            if(IncludeBautura)
            {
                suma += 10;
            }
            if(IncludePopcorn)
            {
                suma += 15;
            }
            return suma;
        }

        public override double CalculeazaPretFinal()
        {
            return PretBaza + GetExtras();
        }
    }
}
