using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect2025_gestiune_angajati
{
    public class AngajatiRepo
    {
        public List<Angajat> GetAll()
        {
            return new List<Angajat>(FakeDatabase.angajati);
        }

        public void Add(Angajat angajat)
        {
            FakeDatabase.angajati.Add(angajat);
        }

        public void Update(Angajat angajat)
        {
            var ang = FakeDatabase.angajati.Where(a => a.IdCompanie == angajat.IdCompanie && a.Nume == angajat.Nume && a.DataNasterii == angajat.DataNasterii).ToList();
            if (ang.Count > 0)
            {
                foreach(Angajat a in ang)
                {
                    Stergere(a);
                }
                foreach(Angajat a in ang)
                {
                    Add(a);
                }
            }
            


        }

        public void Stergere(Angajat angajat)
        {
            FakeDatabase.angajati.Remove(angajat);
        }
    }
}
