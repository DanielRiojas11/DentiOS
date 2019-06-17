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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void TextBoxRecomendedbyAddP_TextChanged(object sender, EventArgs e)
        {
        }

        private void ButtonAddP_Click(object sender, EventArgs e)
        {
            (this.Owner as Form1).NewPatientButton.Enabled = true;
            Hide();
        }
    }
}
