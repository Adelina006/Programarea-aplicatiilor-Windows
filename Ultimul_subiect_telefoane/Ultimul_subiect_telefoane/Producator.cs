using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimul_subiect_telefoane
{
    public class Producator
    {
        public int Id { get; set; }
        public string Denumire { get; set; }


        public Producator(int id, string nume)
        {
            Id = id;
            Denumire = nume;

        }
    }
}
