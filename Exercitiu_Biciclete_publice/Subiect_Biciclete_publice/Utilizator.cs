using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Biciclete_publice
{
    [Serializable]
    public class Utilizator
    {
       
        private int _codB;
        public int CodB
        {
            get { return _codB; }
            set { _codB = value; }
        }

        private string _nume;
        public string Nume
        {
            get { return _nume; } set { _nume = value; }
        }

        private int _durata;
        public int Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }

        public Utilizator(int cod, string nume, int durata)
        {
            CodB = cod;
            Nume = nume;
            Durata = durata;
        }

        public override string ToString()
        {
            return $"{Nume} - {Durata}";
        }

        public Utilizator()
        {
                
        }
    }
}
