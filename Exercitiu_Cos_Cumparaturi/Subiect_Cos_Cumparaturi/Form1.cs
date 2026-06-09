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
using System.Xml.Serialization;

namespace Subiect_Cos_Cumparaturi
{
    public partial class Form1 : Form
    {
        private static CosCumparaturi cos;
        public Form1()
        {
            InitializeComponent();
            cos = new CosCumparaturi();
            var p = new Produs(1, "Lapte", 2, 10);
            var p2 = new Produs(2, "Mieer", 5, 15.5);
            cos = cos + p;
            cos = cos + p2;

            lvProduse.Columns.Add("Id");
            lvProduse.Columns.Add("Denumire");
            lvProduse.Columns.Add("Cantitate");
            lvProduse.Columns.Add("Pret");
            lvProduse.Columns.Add("Valoare");

            RefreshLV();

        }

        public void RefreshLV()
        {
            lvProduse.Items.Clear();
            for (int i = 0; i < cos.produse.Length; i++)
            {
                ListViewItem item = new ListViewItem(cos.produse[i].Id.ToString());
                item.SubItems.Add(cos.produse[i].Denumire);
                item.SubItems.Add(cos.produse[i].Cantitate.ToString());
                item.SubItems.Add(cos.produse[i].Pret.ToString());
                item.SubItems.Add(cos.produse[i].Valoare.ToString());
                item.Tag = cos.produse[i];

                lvProduse.Items.Add(item);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var form = new FormAdugare( null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Produs p = form.final;
                    cos = cos + p;
                   
                    RefreshLV();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (lvProduse.SelectedItems.Count > 0)
            {
                Produs p = lvProduse.SelectedItems[0].Tag as Produs;
                if (p != null)
                {
                    using (var form = new FormAdugare(p))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                         
                           
                            RefreshLV();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nu ati selectat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (lvProduse.SelectedItems.Count > 0)
            {
                var index = lvProduse.SelectedIndices[0];
                for(int i = index; i < cos.produse.Length -1; i++)
                {
                    cos.produse[i] = cos.produse[i + 1];
                }
                Array.Resize(ref cos.produse, cos.produse.Length - 1);

                RefreshLV();
                
            }
            else
            {
                MessageBox.Show("Nu ati selectat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 20);
            Brush pensula = Brushes.Black;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            double sum = 0;

            y += 30;

            for(int i = 0; i < cos.produse.Length; i++)
            {
                sum += cos.produse[i].Valoare;
                e.Graphics.DrawString(cos.produse[i].ToString(), font, pensula, x, y);
                y += 30;
            }

            e.Graphics.DrawString($"Suma {sum}", font, pensula, x, y);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Fisier xml|(*.xml)";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer ser = new XmlSerializer(typeof(CosCumparaturi));
                    using(FileStream fs = new FileStream(sfd.FileName, FileMode.Create)
                    {
                       ser.Serialize(fs, cos);
                    }
                }
            }
        }
    }
}
