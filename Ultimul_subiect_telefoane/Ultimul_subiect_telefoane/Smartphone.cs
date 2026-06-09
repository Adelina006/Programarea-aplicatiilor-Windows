using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimul_subiect_telefoane
{
    public class Smartphone :IComparable<Smartphone>
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Stoc {  get; set; }
        public decimal Pret { get; set; }
        public DateTime DataApartie { get; set; }
        public int IdProducator { get; set; }

        public Smartphone(int id, string model, int stoc, decimal pret, DateTime data, int idp)
        {
             Id = id;
            Model = model;
            Stoc = stoc;
            Pret = pret;
            DataApartie = data;
            IdProducator = idp;
        }

        public Smartphone()
        {
                
        }

        public int CompareTo(Smartphone other)
        {
            if(this.Model.CompareTo(other.Model) == 0)
            {
                return this.Pret.CompareTo(other.Pret);
            }
            else
            {
                return this.Model.CompareTo(other.Model);
            }
        }

        public static explicit operator int(Smartphone phone)
        {
            return phone.Stoc;
        }
    }
}
