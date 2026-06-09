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
    public partial class Form1 : Form
    {
        private CarteRepo _carteRepo;
        public Form1()
        {
            InitializeComponent();

            _carteRepo = new CarteRepo();

            lvCarti.View = View.Details;
            lvCarti.FullRowSelect = true;
            lvCarti.MultiSelect = false;
            lvCarti.GridLines = true;
            lvCarti.AllowColumnReorder = true;

            int latime = lvCarti.ClientSize.Width;
            lvCarti.Columns.Add("Titlu", (int)(0.3 * latime), HorizontalAlignment.Left);
            lvCarti.Columns.Add("Autor", (int)(0.3* latime), HorizontalAlignment.Left);
            lvCarti.Columns.Add("An", (int)(0.2 * latime), HorizontalAlignment.Center);
            lvCarti.Columns.Add("Gen", (int)(0.2 * latime), HorizontalAlignment.Center);

            btnEditeaza.Enabled = false;
            btnSterge.Enabled = false;

            Refresh();

        }

        public void Refresh()
        {
            lvCarti.Items.Clear();
            var carti = _carteRepo.GetAll();
            foreach(Carte c in carti)
            {
                ListViewItem item = new ListViewItem(c.Titlu);
                item.SubItems.Add(c.Autor);
                item.SubItems.Add(c.AnAparitie.ToString());
                item.SubItems.Add(c.Gen.ToString());
                item.Tag = c;

                lvCarti.Items.Add(item);
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (FormCarte form = new FormCarte())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            var carte = lvCarti.SelectedItems[0].Tag as Carte;
            using (FormCarte form = new FormCarte(carte.Id))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    Refresh();
                }
            }
        }

        private void lvCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditeaza.Enabled = true;
            btnSterge.Enabled = true;
        }
    }
}
