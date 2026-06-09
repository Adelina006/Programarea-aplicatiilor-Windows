using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiet_studenti
{
   
    public partial class FormEditare : Form
    {
        public Student student;
        private StudentiRepo _repo;

        public FormEditare(Student s)
        {
            InitializeComponent();

         txtNume.Text= s.Nume.ToString();
            txtNume.ReadOnly = true;
            txtMatricol.Text = s.Matricol.ToString();
            txtMatricol.ReadOnly = true;
            txtMedie.Text = s.Medie.ToString();
         
            student = s;

            _repo = new StudentiRepo();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.Id = student.Id;
            stud.Nume = student.Nume;
            stud.Matricol = student.Matricol;
            decimal.TryParse(txtMedie.Text, out decimal nota);
            stud.Medie = nota;

            _repo.Update(stud);
            this.DialogResult = DialogResult.OK;
        }
    }
}
