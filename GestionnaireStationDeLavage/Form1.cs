using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionnaireStationDeLavage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnDashboard.Height;
            panelSlide.Top = btnDashboard.Top;
        }

        private void btnEmployer_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnEmployer.Height;
            panelSlide.Top = btnEmployer.Top;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnCustomer.Height;
            panelSlide.Top = btnCustomer.Top;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnService.Height;
            panelSlide.Top = btnService.Top;
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnMoney.Height;
            panelSlide.Top = btnMoney.Top;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnReport.Height;
            panelSlide.Top = btnReport.Top;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnSetting.Height;
            panelSlide.Top = btnSetting.Top;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnLogout.Height;
            panelSlide.Top = btnLogout.Top;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
