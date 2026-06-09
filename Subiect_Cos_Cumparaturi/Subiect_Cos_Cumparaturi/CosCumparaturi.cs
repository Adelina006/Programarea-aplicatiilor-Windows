using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Cos_Cumparaturi
{
    [Serializable]
     public class CosCumparaturi
    {
        public  Produs[] produse;

        public CosCumparaturi()
        {
            produse = new Produs[0];
        }

        public static CosCumparaturi operator +(CosCumparaturi cos, Produs produs)
        {
            Array.Resize(ref cos.produse, cos.produse.Length + 1);
            cos.produse[cos.produse.Length - 1] = produs;

            return cos;

        }



    }
}
