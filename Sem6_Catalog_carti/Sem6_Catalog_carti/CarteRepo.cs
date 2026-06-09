using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem6_Catalog_carti
{
    public class CarteRepo
    {
      public  List<Carte> GetAll()
        {
            return new List<Carte>(FakeDadabase.Carti);
        }


        public Carte GetById(Guid Id)
        {
            return FakeDadabase.Carti.Where(angajati => angajati.Id == Id).FirstOrDefault();
        }

        public void Add( Carte c)
        {
            FakeDadabase.Carti.Add(c);
        }

        public void Update(Carte c)
        {
            var index = FakeDadabase.Carti.FindIndex(a => a.Id == c.Id);
            if( index >= 0)
            {
                FakeDadabase.Carti[index] = c;
            }
        }

        public void Delete(Carte c)
        {
            FakeDadabase.Carti.RemoveAll(ca => ca.Id == c.Id);
        }
    }
}
