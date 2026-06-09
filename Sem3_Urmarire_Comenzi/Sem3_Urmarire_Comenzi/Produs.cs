using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Urmarire_Comenzi
{
    public class Produs
    {
        public string Nume { get; set; }
        public decimal Pret {  get; set; }
        public int Cantitate { get; set; }

        public Produs(string nume, decimal pret, int cant)
        {
                Nume = nume;
            Pret = pret;
            Cantitate = cant;
        }
    }
}
