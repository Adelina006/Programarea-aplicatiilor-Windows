using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Vanzare_bilete
{
    public class Bilet : IValabil, IPretCalculabil
    {
        public string NumeFilm;
        public int NumarSala;
       public TipFilm TipFilm;
        public DateTime ExpiraLa;
        public Client Client;
        private int _nrLoc;
        public int NrLoc
        {
            get
            {
                return _nrLoc;
            }
            set
            {
                if (value >= 1 && value <= 200)
                    _nrLoc = value;
                else
                    throw new ArgumentException("Loc invalid");
            }
        }
        private double _pretBaza;
        public double PretBaza
        {
            get
            {
                return _pretBaza;
            }
            set
            {
                if (value > 0)
                    _pretBaza = value;
                else
                    throw new ArgumentException("Pret invalid");
            }
        }
        public Bilet(string nume, int sala, TipFilm tip, DateTime data, Client client, int loc, double pret)
        {
                NumeFilm = nume;
            NumarSala = sala;
            TipFilm = tip;
            ExpiraLa = data;
            Client = client;
            NrLoc = loc;
            PretBaza = pret;
        }

        public virtual double GetReducere()
        {
            return 0;
        }

        public virtual double CalculeazaPretFinal()
        {
            return PretBaza - GetReducere();
        }

        public virtual bool esteValid()
        {
            if (ExpiraLa < DateTime.Now)
                return true;
            else
                return false;
        }
    }
}
