using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_Urmarire_Comenzi
{
    public class Comanda
    {
        private static int _contor = 0;
        public string NumarComanda { get; }
        public string NumeClient {  get; }
        public string EmailClient { get; }
       public  List<Produs> Produse {  get; }
        public StareComanda Stare { get; set; }
        public DateTime DataPlasare { get; }

        public Comanda(string nume, string email)
        {
            NumarComanda = $"CMD-{++_contor:d3}";
            NumeClient = nume;
            EmailClient = email;
            Produse = new List<Produs>();
            Stare = StareComanda.Plasata;
            DataPlasare = DateTime.Now;
        }

        public decimal GetValoareTotala()
        {
            return Produse.Sum(produs => produs.Cantitate * produs.Pret);
        }

        public void AdaugaProdus(Produs P)
        {
            Produse.Add(P);
        }

        public override string ToString()
        {
            return $"Numar: {NumarComanda} | Client: {NumeClient} | Valoare: {GetValoareTotala()}";
        }


    }
}
