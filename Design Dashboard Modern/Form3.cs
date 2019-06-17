using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class AddConsult : Form
    {
        public AddConsult()
        {
            InitializeComponent();
        }

        private void LabelObservationsAddC_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddC_Click(object sender, EventArgs e)
        {
            (this.Owner as Form1).buttonAddConsult.Enabled = true;
            Hide();
        }
    }
}
