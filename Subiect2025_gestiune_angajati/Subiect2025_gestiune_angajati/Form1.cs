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
    public partial class Form1 : Form
    {
       private List<Companie> companii;
        private AngajatiRepo repo;
        public Form1()
        {

            InitializeComponent();
            repo = new AngajatiRepo();

            companii = new List<Companie>()
            {
                new Companie(1, "Companie 1"),
               

                new Companie(2, "Companie 2"),
                

                new Companie(3, "Companie 3")
               
            };


            lvAngajati.View = View.Details;
            
            int latime = lvAngajati.Width;

            lvAngajati.Columns.Add("Nume", (int)(0.3 * latime));
            lvAngajati.Columns.Add("Data Nastere", (int)(0.3 * latime));
            lvAngajati.Columns.Add("Id companie", (int)(0.3 * latime));

            RefreshLista();


        }

        void RefreshLista()
        {
            lvAngajati.Items.Clear();
            var ang = repo.GetAll();
            foreach (var i in ang)
            {
                ListViewItem item = new ListViewItem(i.Nume);
                item.SubItems.Add(i.DataNasterii.ToString());
                item.SubItems.Add(i.IdCompanie.ToString());
                item.Tag = i;

                lvAngajati.Items.Add(item);

            }
        }

        private void btnAdaugareAngajat_Click(object sender, EventArgs e)
        {
           using (FormAngajati form =  new FormAngajati())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    RefreshLista();
                }
            }
        }

        private void lvAngajati_DoubleClick(object sender, EventArgs e)
        {
            var angajat = lvAngajati.SelectedItems[0].Tag as Angajat;
            using (FormAngajati form = new FormAngajati(angajat))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshLista();
                }
            }
        }
    }
}
