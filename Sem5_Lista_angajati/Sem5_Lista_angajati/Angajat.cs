using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem5_Lista_angajati
{
    public class Angajat
    {
        public string Nume {  get; set; }
        public string Prenume { get; set; }
        public string Departament { get; set; }
        public decimal Salariu { get; set; }
        public DateTime DataAangajarii { get; set; }
        public bool EstePermanent { get; set; }

        public override string ToString()
        {
            return $"{Nume} {Prenume}";
        }

        public  string GetNumeComplet()
        {
            return ToString();
        }
    }
}
