using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Vanzare_bilete
{
    public class BiletSenior : Bilet
    {
        private int _varsta;
        public int VarstaClient
        {
            get
            {
                return _varsta;
            }
            set
            {
                if (value < 60)
                    throw new ArgumentException("Varsta invalida");
                else
                    _varsta = value;
            }
        }

        public BiletSenior(string nume, int sala, TipFilm tip, DateTime data, Client client, int loc, double pret, int varsta) : base( nume,  sala,  tip,  data,  client,  loc, pret)
        {
                VarstaClient = varsta;
        }

        public override double GetReducere()
        {
            return PretBaza * 0.3;
        }
    }
}
