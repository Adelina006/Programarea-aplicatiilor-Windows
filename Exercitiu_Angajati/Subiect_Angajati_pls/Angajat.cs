using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Angajati_pls
{
    [Serializable]
    public class Angajat :IComparable<Angajat>
    {
        public string Nume { get; set; }
        public DateTime DataNasterii { get; set; }
        public int IdCompanie { get; set; }

        public int Id { get; set; }
        public int CompareTo(Angajat other)
        {
            int rezultat = this.Nume.CompareTo(other.Nume);
            if(rezultat != 0)
            {
                return rezultat;
            }
            else
            {
                return this.DataNasterii.CompareTo(other.DataNasterii);
            }
        }

        public Angajat(int id, string nume, DateTime data, int idc)
        {
            Id = id;
            Nume = nume;
            DataNasterii = data;
            IdCompanie = idc;
        }

        public Angajat()
        {
                
        }

        public static explicit operator bool(Angajat a)
        {
            if(a.IdCompanie != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
