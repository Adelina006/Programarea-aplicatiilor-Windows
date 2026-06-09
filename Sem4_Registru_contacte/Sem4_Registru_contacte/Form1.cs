using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem4_Registru_contacte
{
    public partial class Form1 : Form
    {
       private List<Contact> Contacte = new List<Contact>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNume.Text))
            {
                MessageBox.Show("Nume Invalid", "eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(string.IsNullOrEmpty(txtPrenume.Text))
            {
                MessageBox.Show("Prenume invalid", "eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Telefon invalid", "eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Contact c = new Contact();
            c.Nume = txtNume.Text.Trim();
            c.Prenume = txtPrenume.Text.Trim();
            c.Email = txtEmail.Text.Trim();
            c.Telefon = txtTelefon.Text.Trim();
            c.NotificariActive = chkNotificari.Checked;

            Contacte.Add(c);

            RefreshLista(Contacte);

            txtNume.Text = string.Empty;
            txtPrenume.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            chkNotificari.Checked = false;
            txtNume.Focus();

            lblStatus.Text = $"Contact adugat. Total : {Contacte.Count()} contacte";
        }

        public void RefreshLista(List<Contact> Contacte)
        {
            lstContacte.Items.Clear();
            foreach(Contact c in Contacte)
            {
                lstContacte.Items.Add(c);
            }
        }

        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            var nume = txtCautare.Text.Trim();
            var listaFiltrata  =  Contacte.Where(contact => contact.ToString().ToLower().Contains(nume.ToLower())).ToList();

            RefreshLista(listaFiltrata);
            lblStatus.Text = $"Se afiseaza {listaFiltrata.Count()} din {Contacte.Count()}";

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            var Desters = lstContacte.SelectedIndex;
            if (Desters == -1)
            {
                MessageBox.Show("Nu s a selectat nimic", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var contact = Contacte[Desters];
              if(  MessageBox.Show("Sunteti sigur?", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contacte.Remove(contact);
                    RefreshLista(Contacte);
                }
                lblStatus.Text = $"Contact sters. Total : {Contacte.Count()} contacte";

            }
        }
    }
}
