using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Biciclete_publice
{
    [Serializable]
    public class Biciclete
    {
        private readonly int _codB;
        public int CodB
        {
            get { return _codB; }
        }
        private string _statie;
        public string Statie
        {
            get { return _statie; }
            set
            {
                _statie = value;
            }
        }
        private int _km;
        public int Km
        {
            get
            {
                return _km;
            }
            set
            {
                _km = value;
            }
        }

        public Biciclete(int id, string statie, int km)
        {
            _codB= id;
            Statie = statie;
            Km = km;
        }

        public Biciclete()
        {
                
        }
    }
}
