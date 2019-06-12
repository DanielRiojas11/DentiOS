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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PanelHis.Hide();
            panelA.Hide();
        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MaximizeButton.Visible = false;
            RestoreButton.Visible = true;
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            RestoreButton.Visible = false;
            MaximizeButton.Visible = true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            PanelHis.Hide();
            panelA.Hide();
        }


        private void MenuButton_Click(object sender, EventArgs e)
        {
            if(SideBar.Width == 192)
            {
                SideBar.Visible = false;
                SideBar.Width = 60;
                PanelLeft.Width = 70;
                LineaSideBar.Width = 60;
                bunifuTransition1.Show(SideBar);
            }
            else
            {
                SideBar.Visible = false;
                SideBar.Width = 192;
                PanelLeft.Width = 212;
                LineaSideBar.Width = 192;
                bunifuTransition2.Show(SideBar);
            }
        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void HistorialButton_Click_1(object sender, EventArgs e)
        {
            PanelHis.Show();
            panelA.Hide();
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panelh_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Panelhis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void PanelA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdeudosButton_Click(object sender, EventArgs e)
        {
            panelA.Show();
        }

        private void ButtonAddDeuda_Click(object sender, EventArgs e)
        {
            AddAdeudo addAdeudo = new AddAdeudo();
            addAdeudo.Owner = this;
            buttonAddDeuda.Enabled = false;
            addAdeudo.Show();


        }
    }
}
