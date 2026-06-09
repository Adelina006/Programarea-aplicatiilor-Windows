using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem6_Catalog_carti
{
    public partial class FormCarte : Form
    {
        private CarteRepo repo;
        private Carte carteFinal;
        private bool editare;
        public FormCarte(Guid? id = null)
        {
            InitializeComponent();
            repo = new CarteRepo();

            numAn.Minimum = 1000;
            numAn.Maximum = DateTime.Now.Year;
            numAn.Value = DateTime.Now.Year;

            carteFinal = new Carte();

            var genuri = Enum.GetValues(typeof(GenCarte));
            cmbGen.DataSource = genuri;

            if( id == null)
            {
                Text = "Adaugare carte";
              
                carteFinal.Id = Guid.NewGuid();
                editare = false;
            }
            else
            {
                Text = "Editare carte";
                var carte = repo.GetById((Guid)id);
                txtAutor.Text = carte.Autor;
                txtTitlu.Text = carte.Titlu;
                numAn.Value = carte.AnAparitie;
                cmbGen.SelectedItem = carte.Gen;
                editare = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool esteValid = true;
         
            if(string.IsNullOrEmpty(txtAutor.Text))
                {
                    errorProvider1.SetError(txtAutor, "Autor invalid");
                    esteValid = false;
                }
            if(string.IsNullOrEmpty(txtTitlu.Text))
            {
                errorProvider1.SetError(txtTitlu, "Titlu invalid");
                esteValid = false;
            }
            if(esteValid == false)
            {
                return;
            }
            else
            {
                carteFinal.Autor = txtAutor.Text;
                carteFinal.Titlu = txtTitlu.Text;
                carteFinal.AnAparitie = (int)numAn.Value;
                carteFinal.Gen = (GenCarte)cmbGen.SelectedItem;



                if(editare == false)
                {
                    repo.Add(carteFinal);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    repo.Update(carteFinal);
                    this.DialogResult = DialogResult.OK;
                }
            }
            
        }
    }
}
