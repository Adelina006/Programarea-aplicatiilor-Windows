using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiet_studenti
{
    public partial class TextBoxEtichetat : UserControl
    {
        public TextBoxEtichetat()
        {
            InitializeComponent();
        }

        public string TextLabel
        {
            get
            {
                return label.Text;
            }
            set
            {
                label.Text = value;
            }
        }

        public string TextDinTextBox
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }
    }
}
