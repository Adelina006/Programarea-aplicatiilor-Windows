using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect2025_gestiune_angajati
{
    public partial class FormAngajati : Form
    {
        private Angajat angFinal;
        private List<Companie> companieList;
        private AngajatiRepo repo;
        bool editare;
        public FormAngajati(Angajat a = null)
        {
            InitializeComponent();
            repo = new AngajatiRepo();

            companieList = new List<Companie>();
            companieList.Add(new Companie(1, "Companie 1"));
            companieList.Add(new Companie(2, "Companie 2"));
            companieList.Add(new Companie(3, "Companie 3"));
            companieList.Add(new Companie(0, "Fara companie"));
            cmbCompanie.DataSource = companieList;
            cmbCompanie.DisplayMember = "Nume";
            cmbCompanie.ValueMember = "Id";

            if(a == null)
            {
                Text = "adaugare angajat";
                editare = false;
            }
            else
            {
                Text = "edtare Angajat";
                txtNume.Text = a.Nume;
                dtpData.Value = a.DataNasterii;
                cmbCompanie.SelectedItem = a.IdCompanie;
                editare = true;
            }

        }

        private void FormAngajati_Load(object sender, EventArgs e)
        {

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            angFinal = new Angajat();
            errorProvider1.Clear();
            bool esteVlaid = true;
            if(string.IsNullOrEmpty(txtNume.Text))
            {
                errorProvider1.SetError(txtNume, "numele este obligatoriu");
                esteVlaid=false;

            }
            if(dtpData.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpData, "data Invalida");
                esteVlaid=false;
            }

            if(!esteVlaid)
            {
                return;
            }
            else
            {
                if (editare == false)
                {
                    angFinal.Nume = txtNume.Text;
                    angFinal.IdCompanie = (int)cmbCompanie.SelectedValue;
                    angFinal.DataNasterii = dtpData.Value;

                    repo.Add(angFinal);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    
                }
            }
        }
    }
}
