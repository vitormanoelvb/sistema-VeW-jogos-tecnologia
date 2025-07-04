using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeW_Games_Tecnologia
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void btnVoltarMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal frm = new MenuPrincipal();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void lblGitHubVitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/vitormanoelvb",
                UseShellExecute = true
            });
        }

        private void linkGitWauclidson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/WAUCLIDSON",
                UseShellExecute = true
            });
        }
    }
}
