using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem5_Lista_angajati
{
    public partial class Form1 : Form
    {
        BindingList<Angajat> _angajati = new BindingList<Angajat>()
        {
            new Angajat()
            {
                Nume = "Popescu",
                Prenume = "Ion",
                Departament = "Vanzari",
                Salariu = 5700,
                DataAangajarii = new DateTime(2021, 11,29),
                EstePermanent = true
            }
        };
        public Form1()
        {
            InitializeComponent();

            dgvAngajati.DataSource = _angajati;
            cmbFiltruDepartament.Items.Add("Toate");
            cmbFiltruDepartament.Items.Add("IT");
            cmbFiltruDepartament.Items.Add("HR");
            cmbFiltruDepartament.Items.Add("Financiar");
            cmbFiltruDepartament.Items.Add("Vanzari");
            cmbFiltruDepartament.SelectedItem = "Toate";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            using( FormAngajat form = new FormAngajat())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    _angajati.Add(form.AngajatRezultat);
                    lblStatus.Text = "s a adaugat angajatul";
                }
            }
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            var index = dgvAngajati.SelectedRows[0].Index;
            var a = _angajati[index];

            using (FormAngajat form = new FormAngajat(a))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    _angajati[index] = form.AngajatRezultat;
                    lblStatus.Text = "S a editat angajatul";
                }
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var index = dgvAngajati.SelectedRows[0].Index;
            var ang = _angajati[index];
            if(index == -1)
            {
                return;
            }
            else
            {
              if(  MessageBox.Show("Doriti sa stergeti", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _angajati.Remove(ang);
                }
               
            }
        }

        private void cmbFiltruDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFiltruDepartament.SelectedItem.ToString() == "Toate")
            {
                dgvAngajati.DataSource = _angajati;
            }
            else
            {
                var dep = cmbFiltruDepartament.SelectedItem.ToString();
                var filtarti = _angajati.Where(angajat => angajat.Departament == dep).ToList();
                var listaFiltrata = new BindingList<Angajat>(filtarti);
                dgvAngajati.DataSource = listaFiltrata;
            }
        }
    }
}
