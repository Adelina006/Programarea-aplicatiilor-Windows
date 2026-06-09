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
    public partial class Form1 : Form
    {
        private List<Student> _studenti;
        private StudentiRepo _repo;

        public Form1()
        {
            InitializeComponent();

            tbeNume.TextLabel = "Nume";
            tbeMedie.TextLabel = "Medie";
            tbeMatricol.TextLabel = "Matricol";

            _studenti = new List<Student>();

            _repo = new StudentiRepo();

            dgvStudenti.ReadOnly = true;

            RefreshLista();



        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student s;
            bool esteValid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(tbeNume.TextDinTextBox))
            {
                esteValid = false;
                errorProvider1.SetError(tbeNume, "Nume Invalid");
            }
            if (!esteValid)
            {
                return;

            }
            else
            {

                Int32.TryParse(tbeMatricol.TextDinTextBox, out int matricol);
                decimal.TryParse(tbeMedie.TextDinTextBox, out decimal medie);
                s = new Student(0, tbeNume.TextDinTextBox.ToString(), matricol, medie);

                _studenti.Add(s);
                tbeMatricol.TextDinTextBox = "";
                tbeNume.TextDinTextBox = "";
                tbeMedie.TextDinTextBox = "";
            }

           
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _repo.Stergere();
            foreach (Student student in _studenti)
            {
                _repo.Adaugare(student);
            }
            _studenti = _repo.GetAll();
            RefreshLista();
        }

        public void RefreshLista()
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = _studenti;
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvStudenti_DoubleClick(object sender, EventArgs e)
        {
            Student s = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            using (var form = new FormEditare(s))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _studenti.Clear();
                    _studenti = _repo.GetAll();
                    RefreshLista();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 20);
            Brush pensula = Brushes.Black;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            e.Graphics.DrawString("Medii Studenti", font, pensula, x, y);

            y += 40;

            e.Graphics.DrawString("Nume", font, pensula, x, y);
            e.Graphics.DrawString("Medie", font, pensula, x+300, y);

            y += 40;

            foreach (Student student in _studenti)
            {
                e.Graphics.DrawString(student.Nume, font, pensula, x, y);
                e.Graphics.DrawString(student.Medie.ToString(), font, pensula, x + 300, y);
                y += 20;
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
