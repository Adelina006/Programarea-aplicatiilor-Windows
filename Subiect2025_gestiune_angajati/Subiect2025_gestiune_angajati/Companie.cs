using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect2025_gestiune_angajati
{
    public class Companie
    {
        public int Id { get; set; }
        public string Nume { get; set; }

        public Companie(int id, string nume)
        {
                Id = id;
            Nume = nume;
        }
    }
}
