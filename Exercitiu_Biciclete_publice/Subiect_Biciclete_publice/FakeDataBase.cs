using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_Biciclete_publice
{
    public class FakeDataBase
    {
        public static List<Utilizator> utilizatori = new List<Utilizator>()
        {
            new Utilizator(1, "Ana Maria", 60),
            new Utilizator(2, "Ion Ionel", 78),
            new Utilizator(3, "Alex Rizea", 90),
             new Utilizator(1, "Alesia Maria", 60),
              new Utilizator(1, "Ioana Maria", 60)

        };


        public static List<Biciclete> biciclete = new List<Biciclete>()
        {
            new Biciclete(1, "Statia 1", 20),
             new Biciclete(2, "Statia 2", 10),
              new Biciclete(3, "Statia 3", 25)
        };


    }
}
