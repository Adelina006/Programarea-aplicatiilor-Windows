using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace Subiect_Angajati_pls
{
    public partial class Form1 : Form
    {
        private List<Companie> _companii;
        private List<Angajat> _angajati;
        private AngajatiRepo _repo;
        public Form1()
        {
            InitializeComponent();
            _companii = new List<Companie>()
            {
                new Companie()
                {
                    Id = 1,
                    Nume = "Companie 1"
                },
                new Companie()
                {
                    Id = 2,
                    Nume = "Companie 2"
                },
                new Companie()
                {
                    Id = 3,
                    Nume = "Companie 2"
                }

            };

            _repo = new AngajatiRepo();

            _angajati = new List<Angajat>();
            _angajati = _repo.GetAll();

            lvAngajati.View = View.Details;
            int lungime = lvAngajati.Width;
            lvAngajati.Columns.Add("Id", (int)(0.2 * lungime));
            lvAngajati.Columns.Add("Nume", (int)(0.3 * lungime));
            lvAngajati.Columns.Add("Data Nasterii", (int)(0.3 * lungime));
            lvAngajati.Columns.Add("Id Companie", (int)(0.3 * lungime));

            RefreshLista();

        }

        public void RefreshLista()
        {
            lvAngajati.Items.Clear();
            _angajati= _repo.GetAll();
            _angajati.Sort();

            foreach(var a in _angajati)
            {
                ListViewItem item = new ListViewItem(a.Id.ToString());
                item.SubItems.Add(a.Nume.ToString());
                item.SubItems.Add(a.DataNasterii.ToString());
                item.SubItems.Add(a.IdCompanie.ToString());
                item.Tag = a;

                lvAngajati.Items.Add(item);

            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            using (var form = new FormAngajati(_companii, null))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    RefreshLista();
                }
            }
        }

        private void lvAngajati_DoubleClick(object sender, EventArgs e)
        {
            Angajat a = lvAngajati.SelectedItems[0].Tag as Angajat;
            using (var form = new FormAngajati(_companii, a))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    RefreshLista();
                }
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            Angajat a = lvAngajati.SelectedItems[0].Tag as Angajat;
            if (a != null)
            {
                if (MessageBox.Show("Doriti sa stergeti?", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repo.Delete(a);
                    RefreshLista();
                }
            }
        }

        private void btnVerificare_Click(object sender, EventArgs e)
        {
            List<Angajat> ang = _repo.GetAll();
            bool totiAu = true;
            foreach(var a in  ang)
            {
                if(!(bool)a)
                {
                    totiAu = false;
                }
            }
            if(totiAu)
            {
                MessageBox.Show("Toti au companie");
            }
            else
            {
                MessageBox.Show("Nu toti au companie");
            }
        }

        private void btnXLM_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Fisier Xml|*.xml";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer s = new XmlSerializer(typeof(List<Angajat>));
                using( FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    s.Serialize(fs, _angajati);
                }
            }
        }
    }
}
