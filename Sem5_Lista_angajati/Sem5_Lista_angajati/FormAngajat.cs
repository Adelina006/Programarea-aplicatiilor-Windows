using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem5_Lista_angajati
{
    public partial class FormAngajat : Form
    {
        public Angajat AngajatRezultat { get; private set; }

        public FormAngajat(Angajat a = null)
        {
            InitializeComponent();
            List<string> Departamente = new List<string>();
            Departamente.Add("IT");
            Departamente.Add("HR");
            Departamente.Add("Financiar");
            Departamente.Add("Vanzari");
            cmbDepartament.DataSource = Departamente;

            if(a == null)
            {
                Text = "Adaugare angajat Nou";
            }
            else
            {
                Text = $"Editare Angajat {a.Nume} {a.Prenume}"; 
                txtNume.Text = a.Nume;
                txtPrenume.Text = a.Prenume;
                cmbDepartament.SelectedItem = a.Departament;
                txtSalariu.Text = a.Salariu.ToString();
                dtpDataAngajare.Value = a.DataAangajarii;
                chkPermanent.Checked = a.EstePermanent;
            }

          

           

        }

        private void FormAngajat_Load(object sender, EventArgs e)
        {

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool esteValid = true;
            if(string.IsNullOrEmpty(txtNume.Text))
            {
                errorProvider1.SetError(txtNume, "Numele este obligatoriu");
                esteValid = false;
            }
            if(string.IsNullOrEmpty(txtPrenume.Text))
            {
                errorProvider1.SetError(txtPrenume, "Prenumele este obligatoriu");
                esteValid = false;

            }
            if(!decimal.TryParse(txtSalariu.Text, out decimal salariu ))
            {
                errorProvider1.SetError(txtSalariu, "Salariu invalid");
                esteValid = false;
            }
            else
            {
                if(salariu < 0 )
                {
                    errorProvider1.SetError(txtSalariu, "Salariu nu poate sa fie invalid");
                    esteValid = false;
                }
            }

            if(!esteValid)
            {
                return;
            }
            else
            {
                AngajatRezultat = new Angajat()
                {
                    Nume = txtNume.Text,
                    Prenume = txtPrenume.Text,
                    Salariu = salariu,
                    Departament = cmbDepartament.SelectedItem.ToString(),
                    DataAangajarii = dtpDataAngajare.Value,
                    EstePermanent = chkPermanent.Checked

                };

                DialogResult = DialogResult.OK;
            }
        }
    }
}
