﻿using System;
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
    public partial class AddAdeudo : Form
    {
        public AddAdeudo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelDate_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            (this.Owner as Form1).buttonAddDeuda.Enabled = true;
            Hide();
        }

        private void PanelMainAddA_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
