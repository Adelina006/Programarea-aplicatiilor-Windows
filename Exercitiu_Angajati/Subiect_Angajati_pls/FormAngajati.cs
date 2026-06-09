using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_Angajati_pls
{
    public partial class FormAngajati : Form
    {
        private List<Companie> _comp;
        public bool Editare;
        private AngajatiRepo _repo;
        private Angajat angFinal;
        public FormAngajati(List<Companie> _companii, Angajat a = null)
        {
            InitializeComponent();

           Editare = true;
            _repo = new AngajatiRepo();
            angFinal = a;

            _comp = new List<Companie>(_companii);
            Companie c = new Companie()
            {
                Id = 0,
                Nume = "Fara Companie"
            };
            _comp.Add(c);

            cmbCompanie.DataSource = _comp;
            cmbCompanie.ValueMember = "Id";
            cmbCompanie.DisplayMember = "Nume";

            if( a == null)
            {
                Text = "Adugare angajat";
                Editare = false;
            }
            else
            {
                Text = "Editare Angajat";
                txtNume.Text = a.Nume;
                dtpData.Value = a.DataNasterii;
                cmbCompanie.SelectedItem = a.IdCompanie;
                Editare = true;
            }


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool esteValid = true;
            if(string.IsNullOrEmpty(txtNume.Text)) 
            {
                errorProvider1.SetError(txtNume, "Nume invalid");
                esteValid = false;
            }
            if(dtpData.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpData, "Data invalid");
                esteValid = false;
            }

            if(!esteValid)
            {
                return;
            }
            else
            {
               if(!Editare)
                {
                    var ang = new Angajat(0, txtNume.Text, dtpData.Value, (int)cmbCompanie.SelectedValue);
                    _repo.Add(ang);
                    this.DialogResult= DialogResult.OK;
                }
                else
                {
                    var ang = new Angajat(angFinal.Id, txtNume.Text, dtpData.Value, (int)cmbCompanie.SelectedValue);
                    _repo.Update(ang);
                    this.DialogResult= DialogResult.OK;
                }
            }
           
        }
    }
}
