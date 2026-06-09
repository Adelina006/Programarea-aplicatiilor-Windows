using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Biciclete_publice
{
    public class Repository
    {

        public List<Biciclete> GetAllBiciclete()
        {
            return new List<Biciclete>(FakeDataBase.biciclete);
        }

        public List<Utilizator> GetAllUtilizator()
        {
            return new List<Utilizator>(FakeDataBase.utilizatori);
        }
    }
}
