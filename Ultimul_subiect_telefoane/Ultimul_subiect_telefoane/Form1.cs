using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimul_subiect_telefoane
{
    public partial class Form1 : Form
    {
        private List<Producator> _producatori;
        private List<Smartphone> _telefoane;
        private TelefoaneRepo _repo;
        public Form1()
        {
            InitializeComponent();
            _producatori = new List<Producator>();
            IncarcareFisier();
            _repo = new TelefoaneRepo();
            _telefoane = _repo.GetAll();
           

            RefreshLista();

        }

        public void IncarcareFisier()
        {
            string cale = "Producatori.txt";
            if (File.Exists(cale))
            {
                using (StreamReader sr = new StreamReader(cale))
                {
                    string linie;
                    while ((linie = sr.ReadLine()) != null)
                     {
                        string[] bucati = linie.Split(',');
                        if (bucati.Length == 2)
                        {
                            int id = int.Parse(bucati[0]);
                            string denumire = bucati[1];

                            Producator p = new Producator(id, denumire);
                            _producatori.Add(p);
                        }

                    }

                }

            }
        }

        private void dgvTelefoane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void RefreshLista()
        {
            dgvTelefoane.DataSource = null;
            _telefoane.Clear();
            _telefoane = _repo.GetAll();
            _telefoane.Sort();
            dgvTelefoane.DataSource = _telefoane;
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormAdaugare(_producatori, null))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    RefreshLista();
                }
            }
        }

        private void editareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Smartphone t = dgvTelefoane.SelectedRows[0].DataBoundItem as Smartphone;
            using (var form = new FormAdaugare(_producatori, t))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshLista();
                }
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTelefoane.SelectedRows.Count > 0)
            {
                Smartphone t = dgvTelefoane.SelectedRows[0].DataBoundItem as Smartphone ;
                _repo.Delete(t);
                RefreshLista();
            }
        }

        private void stocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTelefoane.SelectedRows.Count > 0)
            {
                Smartphone t = dgvTelefoane.SelectedRows[0].DataBoundItem as Smartphone;
                MessageBox.Show($"Din {t.Model} mai sunt {(int)t} buc", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }
    }
}
