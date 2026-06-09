using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregatire_Vilcea
{
        public abstract class Carte : IComparable<Carte>, ICloneable
    {
        public string Titlu {  get; set; }
        public string Autor { get; set; }
        public int An {  get; set; }
        public GenLiterar Gen { get; set; }
        public decimal pret {  get; set; }

        public abstract object Clone();

        public int CompareTo(Carte other)
        {
            return string.Compare(Titlu, other.Titlu, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class CarteFizica : Carte
    {
        public string Raft { get; set; }

        public override object Clone()
        {
            var clona = new CarteFizica()
            {
                Titlu = Titlu,
                Autor = Autor,
                An = An,
                Gen = Gen,
                pret = pret,
                Raft = Raft
            };

            return clona;
        }
    }

    public class CarteDigitala : Carte
    {
        public string Format { get; set; }

        public override object Clone()
        {
            var clona = new CarteDigitala()
            {
                Titlu = Titlu,
                Autor = Autor,
                An = An,
                Gen = Gen,
                pret = pret,
                Format = Format
            };

            return clona;
        }
    }
}
