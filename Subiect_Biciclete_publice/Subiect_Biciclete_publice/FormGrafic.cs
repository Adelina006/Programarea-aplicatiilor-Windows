using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_Biciclete_publice
{
    public partial class FormGrafic : Form
    {
        private List<Biciclete> biciclete;
        private Repository repository;
        public FormGrafic()
        {
            InitializeComponent();
            repository = new Repository();
            biciclete = repository.GetAllBiciclete();
        }

        private void FormGrafic_Paint(object sender, PaintEventArgs e)
        {
            int x = 30;

            foreach(Biciclete b in biciclete)
            {
                int inaltime = b.Km * 5;

                e.Graphics.FillRectangle(Brushes.BlueViolet, x, 300 - inaltime, 30, inaltime);
               
                e.Graphics.DrawString(b.CodB.ToString(), this.Font, Brushes.Black, x, 250 - inaltime);
                x += 60;
            }

        

        }
    }
}
