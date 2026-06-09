using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_Cos_Cumparaturi
{
    public partial class FormAdugare : Form
    {
      
       
       public Produs final = new Produs();
        Produs _p;
        public FormAdugare( Produs p)
        {
            InitializeComponent();

            if(p == null)
            {
                Text = "Adaugare";
            }
            else
            {
                Text = "editare";
                txtDenumire.Text = p.Denumire;
                txtId.Text = p.Id.ToString();
                numCantitate.Value = p.Cantitate;
                numPret.Value = (decimal)p.Pret;
            }

          
            _p = p;
            


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool esteValid = true;
            errorProvider1.Clear();
          
            Int32.TryParse(txtId.Text, out int id);
            if(id < 0)

            {
                errorProvider1.SetError(txtId, "invalid");
                esteValid = false;
            }
            if(esteValid)
            {
                if (_p == null)
                {

                    final.Id = id;
                    final.Denumire = txtDenumire.Text;
                    final.Pret = (double)numPret.Value;
                    final.Cantitate = (int)numCantitate.Value;

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    _p.Id = id;
                    _p.Denumire = txtDenumire.Text;
                    _p.Pret = (double)numPret.Value;
                    _p.Cantitate = (int)numCantitate.Value;

                    this.DialogResult = DialogResult.OK;
                }
            }
               

            
            else
            {
                MessageBox.Show("invalid" , "eroare", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

          


        }
    }
}
