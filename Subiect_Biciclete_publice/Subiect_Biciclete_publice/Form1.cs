using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Subiect_Biciclete_publice
{
    public partial class Form1 : Form
    {
        private List<Biciclete> _biciclete;
        private List<Utilizator> _utilizatori;
        private Repository _repo;
        public Form1()
        {
            InitializeComponent();

            _repo = new Repository();
            lvBiciclete.View = View.Details;

            int lungime = lvBiciclete.Width;

            lvBiciclete.Columns.Add("Cod", (int)(0.2 * lungime));
            lvBiciclete.Columns.Add("Statie", (int)(0.3 * lungime));
            lvBiciclete.Columns.Add("Km", (int)(0.3 * lungime));

            _biciclete = _repo.GetAllBiciclete();
            _utilizatori = _repo.GetAllUtilizator();

            RefreshBiciclete();

        }

        public void RefreshBiciclete()
        {
            lvBiciclete.Items.Clear();
            _biciclete.Clear();
            _biciclete = _repo.GetAllBiciclete();
            foreach (Biciclete b in _biciclete)
            {
                ListViewItem item = new ListViewItem(b.CodB.ToString());
                item.SubItems.Add(b.Statie);
                item.SubItems.Add(b.Km.ToString());
                item.Tag = b;

                lvBiciclete.Items.Add(item);
            }
        }

        public void RefreshUtilizatori(Biciclete b)
        {
            List<Utilizator> listaFiltrata = new List<Utilizator>();
            _utilizatori.Clear();
            _utilizatori = _repo.GetAllUtilizator();
            foreach (Utilizator u in _utilizatori)
            {
                if (u.CodB == b.CodB)
                {
                    listaFiltrata.Add(u);
                }
            }
            lstUtilizatori.DataSource = null;
            lstUtilizatori.DataSource = listaFiltrata;

        }

        public double CalculeazaSuma(Biciclete b)
        {
            double sum = 0;
            _utilizatori.Clear();
            _utilizatori = _repo.GetAllUtilizator();
            foreach (Utilizator u in _utilizatori)
            {
                if (u.CodB == b.CodB)
                {
                    int durata = 0;
                    durata = (u.Durata - 30) / 10;
                    sum += (durata * 2);
                }
            }

            return sum;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBiciclete.SelectedItems.Count > 0)
            {
                Biciclete b = lvBiciclete.SelectedItems[0].Tag as Biciclete;
                RefreshUtilizatori(b);

                double sum = CalculeazaSuma(b);
                txtSuma.Text = sum.ToString() + " euro";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 20);
            Brush pensula = Brushes.Black;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            e.Graphics.DrawString("Raport biciclete", font, pensula, x, y);

            y += 40;

            e.Graphics.DrawString("Cod Bicicleta", font, pensula, x, y);
            e.Graphics.DrawString("Utilizatori", font, pensula, x + 150, y);

            _utilizatori.Clear();
           _biciclete.Clear();
            y += 30;
            _utilizatori = _repo.GetAllUtilizator();
            _biciclete = _repo.GetAllBiciclete();
            foreach(Biciclete b in _biciclete)
            {
                y += 20;
                e.Graphics.DrawString(b.CodB.ToString(), font, pensula, x , y);
                foreach(Utilizator u in _utilizatori)
                {
                    if(u.CodB == b.CodB)
                    {
                        e.Graphics.DrawString(u.Nume, font, pensula, x + 150, y);
                        y += 20;
                    }
                }

            }


        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fisier Binar |(*.dat)";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                BinaryFormatter format = new BinaryFormatter();
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    format.Serialize(fs, _biciclete);
                }


            }

            SaveFileDialog sfd2 = new SaveFileDialog();
            sfd2.Filter = "Fisier Binar |(*.dat)";
            if (sfd2.ShowDialog() == DialogResult.OK)
            {

                BinaryFormatter format = new BinaryFormatter();
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    format.Serialize(fs, _utilizatori);
                }


            }


        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrafic form = new FormGrafic();
            form.ShowDialog();
        }
    }
}
