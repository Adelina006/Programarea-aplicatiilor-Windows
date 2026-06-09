using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem6_Catalog_carti
{
    public class Carte
    {
        public Guid Id;
        public string Titlu { get; set; }
        public string Autor {  get; set; }
        public int AnAparitie { get; set; }
        public GenCarte Gen {  get; set; }


    }
}
