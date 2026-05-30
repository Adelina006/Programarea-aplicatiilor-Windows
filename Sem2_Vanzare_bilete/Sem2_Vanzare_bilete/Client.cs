using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Vanzare_bilete
{
    public class Client
    {
        public string Nume {  get; set; }
        public string Prenume { get; set; }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                if (value.Contains('@') && value.Contains('.'))
                    _email = value;
                else
                    throw new ArgumentException("Emailul este invalid");
            }
        }

        private string _telefon;
        public string Telefon
        {
            get
            {
                return _telefon;
            }
            set
            {
                if (value.Length == 10)
                    _telefon = value;
                else
                    throw new ArgumentException("Telefonul este invalid");
            }
        }
    }
}
