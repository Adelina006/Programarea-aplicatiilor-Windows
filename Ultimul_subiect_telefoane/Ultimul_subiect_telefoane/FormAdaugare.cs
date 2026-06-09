using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimul_subiect_telefoane
{
    public partial class FormAdaugare : Form
    {
        private List<Producator> producatorList;
        private Smartphone telefon;
        private TelefoaneRepo _repo;
        public FormAdaugare(List<Producator> p,   Smartphone t = null)
        {
            InitializeComponent();
            producatorList = new List<Producator>(p);
            cmbProducatori.DataSource= producatorList;
            cmbProducatori.DisplayMember = "Denumire";
            cmbProducatori.ValueMember = "Id";

            _repo = new TelefoaneRepo();

            if(t != null)
            {
                Text = "Editare";
                txtModel.Text = t.Model;
                numStoc.Value = t.Pret;
                numPret.Value = t.Pret;
                dtpData.Value = t.DataApartie;
                cmbProducatori.SelectedValue = t.IdProducator;

            }

            telefon = t;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool esteValid = true;
            if(dtpData.Value > DateTime.Now)
            {
                esteValid = false;
                errorProvider1.SetError(dtpData, "Data invalida");
            }
            if(numPret.Value < 0)
            {
                esteValid = false;
                errorProvider1.SetError(numPret, "Pret invalid");
            }
            if (numStoc.Value < 0)
            {
                esteValid = false;
                errorProvider1.SetError(numStoc, "Stoc invalid");
            }

            if(!esteValid)
            {
                return;
            }
            else
            {
                if( telefon == null)
                {
                    string model = txtModel.Text;
                    int stoc =(int) numStoc.Value;
                    decimal pret = numPret.Value;
                    DateTime data = dtpData.Value;
                    int Idp = cmbProducatori.SelectedIndex;
                    Smartphone tele = new Smartphone(0, model, stoc, pret, data, Idp);

                    _repo.Add(tele);
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    string model = txtModel.Text;
                    int stoc = (int)numStoc.Value;
                    decimal pret = numPret.Value;
                    DateTime data = dtpData.Value;
                    int Idp = cmbProducatori.SelectedIndex;
                    int id = telefon.Id;
                    Smartphone tele = new Smartphone(id, model, stoc, pret, data, Idp);
                    _repo.Update(tele);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
