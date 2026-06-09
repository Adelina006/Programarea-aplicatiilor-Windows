using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Cos_Cumparaturi
{
    [Serializable]
    public class Produs
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _denumire;
        public string Denumire
        {
            get
            {
                return _denumire;

            }
            set
            {
                _denumire = value;
            }
        }
        private int _cantitate;
        public int Cantitate
        {
            get
            {
                return _cantitate;
            }
            set
            {
                _cantitate = value;
            }
        }

        private double _pret;
        public double Pret
        {
            get
            {
                return _pret;

            }
            set
            {
                _pret = value;
            }
        }
        
        public double Valoare
        {
            get
            {
                return Cantitate * Pret;
            }
           
        }

        public Produs(int id, string denumire, int cantitate, double pret)
        {
            Id = id;
            Denumire = denumire;
            Cantitate = cantitate;
            Pret = pret;
        }

        public override string ToString()
        {
            return $"{Denumire}-{Pret} -{Cantitate} - {Valoare}";
        }

        public Produs()
        {
                
        }
    }
}
