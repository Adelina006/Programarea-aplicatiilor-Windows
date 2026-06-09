using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiet_studenti
{
    public class Student
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        private int _matricol;
        public int Matricol
        {
            get
            {
                return _matricol;
            }
            set
            {
                if(value > 0)
                {
                    _matricol = value;
                }
                else
                {
                    MessageBox.Show("Matrico invalid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private decimal _medie;
        public decimal Medie
        {
            get
            {
                return _medie;
            }
            set
            {
                if (value > 0)
                {
                    _medie = value;
                }
                else
                {
                    MessageBox.Show("Medie invalida", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Student(int id, string nume, int matricol, decimal medie)
        {
            Id = id;
            Nume = nume;
            Matricol = matricol;
            Medie = medie;
        }

        public Student()
        {
                
        }
    }
}
