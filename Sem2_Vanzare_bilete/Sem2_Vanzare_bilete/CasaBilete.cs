using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Vanzare_bilete
{
    public class CasaBilete
    {
      public  List<Bilet> Bilete {  get; set; }

        public CasaBilete()
        {
                Bilete = new List<Bilet>();
        }

        public void AdaugaBilete(Bilet b)
        {
            Bilete.Add(b);
        }
        //public double GetIncasariTotale()
        //{
        //    double suma = 0;
        //    foreach (var b in Bilete)
        //    {
        //        suma += b.CalculeazaPretFinal();
        //    }
        //    return suma;
        //}
        //public double GetReduceriAcordate()
        //{
        //    double suma = 0;
        //    foreach(var b in Bilete)
        //    {
        //        suma += b.GetReducere();
        //    }
        //    return suma;
        //}

        public double GetIncasariTotale()
        {
            return Bilete.Sum(bilet => bilet.CalculeazaPretFinal());
        }

        public double GetReduceriAcordate()
        {
            return Bilete.Sum(bilet => bilet.GetReducere());
        }

        public int GetNumarBiletePerTip<T>() where T :Bilet
        {
            return Bilete.Count(bilet => bilet.GetType() == typeof(T));
        }

        public Bilet GetBiletulCelMaiScump()
        {
            return Bilete.OrderByDescending(bilet=>bilet.CalculeazaPretFinal()).FirstOrDefault();
        }
    }
}
